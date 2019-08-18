using KanbanBoard.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoard.DAL
{
    public class BoardManagement
    {
        Helper h;
        public BoardManagement()
        {
            h = new Helper();
        }
        public int Insert(Board board)
        {
            string query = "Insert into Board(Name) Values(@boardName)";
            List<SqlParameter> parameters = GetParameters(board);
            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }
        public int Update(Board board)
        {
            string query = "Update Board Set [Name]=@boardName where ID=@boardID";
            List<SqlParameter> parameters = GetParameters(board);
            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }
        public List<SqlParameter> GetParameters(Board board)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@boardID", board.ID));
            parameters.Add(new SqlParameter("@boardName", board.Name));
            return parameters;
        }

        public int Delete(int boardID)
        {
            string query = "delete from Board Where ID=@boardID";
            h.AddParametersToCommand(new List<SqlParameter>()
            { new SqlParameter()
            {
                ParameterName = "@boardID", Value=boardID
            } });
            return h.MyExecuteQuery(query);
        }

        public Board GetBoardByID(int boardID)
        {
            Board currentBoard = new Board();
            string query = "Select * from Board where ID=@boardID";
            h.AddParametersToCommand(new List<SqlParameter>()
            { new SqlParameter()
            {
                ParameterName = "@boardID", Value=boardID
            } });
            SqlDataReader reader = h.MyExecuteReader(query);
            currentBoard.ID = boardID;
            while (reader.Read())
            {
                currentBoard.Name = reader["Name"].ToString();
            }  
            reader.Close();
            return currentBoard;
        }

        public List<Board> GetAllBoards()
        {
            Board currentBoard = null;
            List<Board> boards = new List<Board>();
            string query = "select * from Board";
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentBoard = new Board();
                currentBoard.ID = (int)reader["ID"];
                currentBoard.Name = reader["Name"].ToString();
                boards.Add(currentBoard);
            }

            reader.Close();
            return boards;
        }
    }
}
