using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyTrello.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTrello.Controllers
{
    public class TaskListController : Controller
    {
        private readonly TrelloDbContext _context;

        public TaskListController(TrelloDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int id)
        {
            this.ViewData["BoardName"] = this._context.Board.FirstOrDefault(b => b.ID == id).Name;
            var taskLists = this._context.TaskList.Where(t => t.BoardID == id);
            return View(taskLists);
        }
    }
}
