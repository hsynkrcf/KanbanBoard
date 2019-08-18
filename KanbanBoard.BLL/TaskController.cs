using KanbanBoard.DAL;
using KanbanBoard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoard.BLL
{
    public class TaskController
    {
        TaskManagement _taskManagement;
        public TaskController()
        {
            _taskManagement = new TaskManagement();
        }

        public bool Add(Tasks task)
        {
            int result = _taskManagement.Insert(task);
            return result > 0;
        }

        public bool Update(Tasks task)
        {
            int result = _taskManagement.Update(task);
            return result > 0;
        }

        public bool Delete(int taskID)
        {
            int result = _taskManagement.Delete(taskID);
            return result > 0;
        }

        public Tasks GetTask(int taskID)
        {
            return _taskManagement.GetTaskByID(taskID);
        }
        public int GetTaskByLastAdded()
        {
            return _taskManagement.GetTaskByLastAdded();
        }
        public List<Tasks> GetTasksByBoardID(int taskID)
        {
            return _taskManagement.GetTaskByBoardID(taskID);
        }

    }
}
