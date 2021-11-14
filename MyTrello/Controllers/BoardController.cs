using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTrello.Data;
using Microsoft.EntityFrameworkCore;

namespace MyTrello.Controllers
{
    public class BoardsController : Controller
    {
        private readonly TrelloDbContext _context;

        public BoardsController(TrelloDbContext context)
        {
            _context = context;
        }

        // GET: Boards
        public async Task<IActionResult> Index()
        {
            return View(await _context.Board.ToListAsync());
        }
    }
}
