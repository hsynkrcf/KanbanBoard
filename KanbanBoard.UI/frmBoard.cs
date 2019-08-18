using KanbanBoard.BLL;
using KanbanBoard.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanBoard.UI
{
    public partial class frmBoard : Form
    {
        BoardController _boardController;
        TaskController _taskController;
        List<Tasks> tasks;
        int _boardID;
        Tasks task1;
        public frmBoard(int boardID)
        {
            _taskController = new TaskController();
            tasks = new List<Tasks>();
            InitializeComponent();
            _boardController = new BoardController();
            _boardID = boardID;

        }

        public void AddTask(List<Tasks> tasks)
        {
            foreach (var item in tasks)
            {
                Label lbl = new Label();
                lbl.Name = "lbl." + item.ID;
                lbl.Text = item.Description;
                lbl.BorderStyle = BorderStyle.FixedSingle;
                lbl.AutoSize = false;
                lbl.MouseDown += Lbl_MouseDown;
                lbl.ContextMenuStrip = contextMenuStrip1;
                lbl.Left = 10;
                if (item.StatusID == (int)Status.ToDo)
                {
                    lbl.Top = GetTop(pnlToDo);
                    pnlToDo.Controls.Add(lbl);
                }
                else if (item.StatusID == (int)Status.Doing)
                {
                    lbl.Top = GetTop(pnlDoing);
                    pnlDoing.Controls.Add(lbl);
                }
                else
                {
                    lbl.Top = GetTop(pnlDone);
                    pnlDone.Controls.Add(lbl);
                }
            }
        }
        private void Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;

            if (e.Button == MouseButtons.Right)
            {
                task1 = new Tasks();
                string ad = lbl.Name;
                string[] parts = ad.Split('.');
                int taskID = Convert.ToInt32(parts[1]);
                task1.ID = taskID;
                task1.BoardID = _boardID;
                task1.Description = lbl.Text;
                task1.IsActive = true;
                contextMenuStrip1.Show();
            }
            else
            {
                lbl = sender as Label;
                lbl.DoDragDrop(sender, DragDropEffects.Move);
            }

        }

        int GetTop(Panel pnl)
        {
            int top = 0;
            foreach (Label item in pnl.Controls)
            {
                top += item.Height + 10;
            }

            return top;
        }

        private void pnlToDo_DragDrop(object sender, DragEventArgs e)
        {
            Label lbl = e.Data.GetData(typeof(Label)) as Label;
            Panel pnl = sender as Panel;
            lbl.Parent.Controls.Remove(lbl);
            lbl.Top = GetTop(pnl);
            pnl.Controls.Add(lbl); foreach (Control item in Controls)
            {
                if (Convert.ToInt32(item.Tag) == 1 || Convert.ToInt32(item.Tag) == 2 || Convert.ToInt32(item.Tag) == 3)
                {
                    foreach (Label item1 in item.Controls)
                    {
                        Tasks task = new Tasks();
                        string ad = item1.Name;
                        string[] parts = ad.Split('.');
                        int taskID = Convert.ToInt32(parts[1]);
                        task.ID = taskID;
                        task.BoardID = _boardID;
                        task.Description = item1.Text;
                        task.IsActive = true;
                        if (Convert.ToInt32(item.Tag) == (int)Status.ToDo)
                        {
                            task.StatusID = (int)Status.ToDo;
                        }
                        else if (Convert.ToInt32(item.Tag) == (int)Status.Doing)
                        {
                            task.StatusID = (int)Status.Doing;
                        }
                        else if (Convert.ToInt32(item.Tag) == (int)Status.Done)
                        {
                            task.StatusID = (int)Status.Done;
                        }
                        _taskController.Update(task);
                    }
                }
                else
                {
                    continue;
                }
            }
        }

        private void pnlToDo_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void frmBoard_Load(object sender, EventArgs e)
        {
            FillList();
        }

        private void FillList()
        {
            pnlToDo.Controls.Clear();
            pnlDoing.Controls.Clear();
            pnlDone.Controls.Clear();
            tasks = _taskController.GetTasksByBoardID(_boardID);
            AddTask(tasks);
        }
        private void newTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewTask frm = new frmNewTask(_boardID, 0);
            frm.ShowDialog();
            FillList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            task1.IsActive = false;
            task1.StatusID = (int)Status.Removed;
            bool result = _taskController.Update(task1);
            if (result)
            {
                MessageBox.Show("Sılme Islemı Basarılı");
            }
            else
            {
                MessageBox.Show("Hata olustu");
            }
            FillList();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewTask frm = new frmNewTask(task1.ID, task1.ID);
            frm.ShowDialog();
            FillList();
        }

        private void updateBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewBoard frm = new frmNewBoard(_boardID);
            frm.ShowDialog();
            FillList();
        }
    }
}
