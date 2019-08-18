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
    public partial class frmNewBoard : Form
    {
        BoardController _boardController;
        Board board;
        int _boardID = 0;
        public frmNewBoard(int boardID)
        {
            InitializeComponent();
            _boardController = new BoardController();
            _boardID = boardID;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoardName.Text))
            {
                MessageBox.Show("Tahta adı boş geçilemez.");
                return;
            }
            if (_boardID == 0)
            {
                board = new Board();
                board.Name = txtBoardName.Text;
                bool result = _boardController.Add(board);
                if (result)
                {
                    MessageBox.Show("Yeni tahtanız başarıyla oluşturuldu.");
                }
                else
                {
                    MessageBox.Show("Bır hata olustu");
                }
            }
            else
            {
                board.Name = txtBoardName.Text;
                bool result = _boardController.Update(board);
                if (result)
                {
                    MessageBox.Show("Guncelleme basarılı");
                }
                else
                {
                    MessageBox.Show("Bır hata olustu");
                }
            }

            this.Close();
        }

        private void frmNewBoard_Load(object sender, EventArgs e)
        {
            if (_boardID != 0)
            {
                board = _boardController.GetBoard(_boardID);
                txtBoardName.Text = board.Name;
            }

        }

    }
}
