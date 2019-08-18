using KanbanBoard.DAL;
using KanbanBoard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoard.BLL
{
    public class BoardController
    {

        BoardManagement _boardManagement;
        public BoardController()
        {
            _boardManagement = new BoardManagement();
        }

        public bool Add(Board board)
        {
            int result = _boardManagement.Insert(board);
            return result > 0;
        }

        public bool Update(Board board)
        {
            int result = _boardManagement.Update(board);
            return result > 0;
        }

        public bool Delete(int boardID)
        {
            int result = _boardManagement.Delete(boardID);
            return result > 0;
        }

        public Board GetBoard(int boardID)
        {
            return _boardManagement.GetBoardByID(boardID);
        }

        public List<Board> GetListOfBoard()
        {
            return _boardManagement.GetAllBoards();
        }
    }
}
