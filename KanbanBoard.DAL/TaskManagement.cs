using KanbanBoard.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoard.DAL
{
    public class TaskManagement
    {
        Helper h;
        public TaskManagement()
        {
            h = new Helper();
        }

        public int Insert(Tasks task)
        {
            string query = "INSERT INTO Task(StatusID,Description,BoardID) VALUES(@statusID,@description,@boardID)";
            List<SqlParameter> parameters = GetParameters(task, true);
            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }

        public int Update(Tasks task)
        {
            string query = "UPDATE Task SET Description = @description, StatusID = @statusID,IsActive=@isActive WHERE ID = @taskID and BoardID=@boardID";
            List<SqlParameter> parameters = GetParameters(task, false);
            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }

        List<SqlParameter> GetParameters(Tasks task, bool isInsert)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (!isInsert)
            {
                parameters.Add(new SqlParameter("@taskID", task.ID));
            }
            parameters.Add(new SqlParameter("@boardID", task.BoardID));
            parameters.Add(new SqlParameter("@statusID", task.StatusID));
            parameters.Add(new SqlParameter("@isActive", task.IsActive));
            parameters.Add(new SqlParameter("@description", task.Description));
            return parameters;
        }
        
        public int GetTaskByLastAdded()
        {
            int ID = 0;

            string query = "SELECT Max(ID) FROM Task";
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                ID = (int)reader[0];
            }

            return ID;
        }

        public int Delete(int boardID)
        {
            string query = "DELETE FROM Task WHERE BoardID = @boardID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@boardID",
                    Value = boardID
                }
            });

            return h.MyExecuteQuery(query);
        }

        public Tasks GetTaskByID(int taskID)
        {
            Tasks currentTask = new Tasks();
            string query = "SELECT * FROM Task WHERE ID = @ID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@ID",
                    Value = taskID
                }
            });

            SqlDataReader reader = h.MyExecuteReader(query);
            reader.Read();
            currentTask.ID = taskID;
            currentTask.StatusID = (int)reader["StatusID"];
            currentTask.Description = reader["Description"].ToString();
            currentTask.IsActive = (bool)reader["IsActive"];
            currentTask.BoardID=(int)reader["BoardID"];
            reader.Close();
            return currentTask;
        }
        public List<Tasks> GetTaskByBoardID(int boardID)
        {
            List<Tasks> list = new List<Tasks>();
            Tasks currentTask;
            string query = "SELECT * FROM Task WHERE BoardID = @boardID and IsActive=@isActive";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@boardID",
                    Value = boardID
                },
                 new SqlParameter()
                {
                    ParameterName = "@isActive",
                    Value = 1
                }
            });

            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentTask = new Tasks();
                currentTask.BoardID = boardID;
                currentTask.ID = (int)reader["ID"];
                currentTask.StatusID = (int)reader["StatusID"];
                currentTask.IsActive = (bool)reader["IsActive"];
                currentTask.Description = reader["Description"].ToString();
                list.Add(currentTask);
            }
            reader.Close();
            return list;
        }
    }
}
