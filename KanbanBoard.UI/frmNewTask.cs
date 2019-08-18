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
    public partial class frmNewTask : Form
    {
        TaskController _taskController;
        BoardController _boardController;
        Tasks currentTask;
        int _boardID = 0;
        int _taskID = 0;
        Tasks task;
        public frmNewTask(int boardID, int taskID)
        {
            InitializeComponent();
            _boardID = boardID;
            _boardController = new BoardController();
            _taskController = new TaskController();
            _taskID = taskID;
            task = new Tasks();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTask.Text))
            {
                MessageBox.Show("Görev boş geçilemez.");
                return;
            }
            if (_taskID != 0)
            {
                task.Description = txtTask.Text;
                bool result = _taskController.Update(task);
                if (result)
                {
                    MessageBox.Show("Guncelleme Basarılı");
                }
                else
                {
                    MessageBox.Show("Bır hata olustu");
                }
            }
            else
            {

                currentTask = new Tasks();
                currentTask.StatusID = (int)Status.ToDo;
                currentTask.Description = txtTask.Text;
                currentTask.BoardID = _boardID;
                currentTask.IsActive = true;
                bool result = _taskController.Add(currentTask);
                if (result)
                {
                    int taskID = _taskController.GetTaskByLastAdded();
                    MessageBox.Show("Görev oluşturuldu.");
                }
                else
                {
                    MessageBox.Show("Hata");
                }
                this.Close();
            }
        }

        private void frmNewTask_Load(object sender, EventArgs e)
        {
            if (_taskID != 0)
            {
                task = _taskController.GetTask(_taskID);
                txtTask.Text = task.Description;
                btnCreate.Text = "Update";
            }
            else
            {
                btnCreate.Text = "Create";
            }
        }
    }
}
