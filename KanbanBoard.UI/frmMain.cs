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
    public partial class frmMain : Form
    {
        BoardController _boardController;
        TaskController _taskController;
        public frmMain()
        {
            InitializeComponent();
            _boardController = new BoardController();
            _taskController = new TaskController();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            FillList();
        }
        void FillList()
        {
            lstBoards.DataSource = _boardController.GetListOfBoard().ToList();
            lstBoards.ValueMember = "ID";
            lstBoards.DisplayMember = "Name";

        }

        private void boardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewBoard newBoard = new frmNewBoard(0);
            newBoard.ShowDialog();
            FillList();
        }

        private void newTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstBoards.SelectedIndex < 0)
            {
                MessageBox.Show("Board seçiniz.");
                return;
            }
            int boardID = Convert.ToInt32(lstBoards.SelectedValue);
            frmNewTask frm = new frmNewTask(boardID, 0);
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstBoards.SelectedIndex < 0)
            {
                MessageBox.Show("Board seçiniz.");
                return;
            }
            int boardID = (int)lstBoards.SelectedValue;
            frmBoard frm = new frmBoard(boardID);
            frm.ShowDialog();
            FillList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstBoards.SelectedIndex < 0)
            {
                MessageBox.Show("Board seçiniz.");
                return;
            }

            int boardID = (int)lstBoards.SelectedValue;
            Board selectedBoard = _boardController.GetBoard(boardID);

            bool tResult = _taskController.Delete(boardID);
            bool bResult = _boardController.Delete(boardID);
            if (bResult && bResult)
            {
                MessageBox.Show("Board başarıyla silindi");
            }
            else
            {
                MessageBox.Show("Bır hata olustu");
            }
            FillList();
        }
    }
}
