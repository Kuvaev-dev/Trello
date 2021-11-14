using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTrello.Models
{
    public class TrelloTaskList
    {
        public int ID { get; set; }

        public int BoardID { get; set; }

        public string Name { get; set; }

        public ICollection<TrelloTask> Tasks { get; set; }
    }
}
