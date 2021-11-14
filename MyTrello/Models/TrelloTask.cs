using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTrello.Models
{
    public class TrelloTask
    {
        public int ID { get; set; }

        public int TaskListID { get; set; }

        public string Text { get; set; }
    }
}
