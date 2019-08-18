using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoard.Model
{
   public class Tasks
    {
        public int ID { get; set; }
        public int StatusID { get; set; }
        public int BoardID { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
