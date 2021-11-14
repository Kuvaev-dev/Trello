using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTrello.Models
{
    public class TrelloBoard
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public ICollection<TrelloTaskList> TaskLists { get; set; }
    }
}
