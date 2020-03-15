using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MVC.Models
{
    public class BooksController : Controller
    {
        private readonly MVCContext _context;

        public BooksController(MVCContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var Book = new MVC.Models.Books()
            {
               
            };
            return View(Book);
        }
        
        public async Task<IActionResult> List()
        {
            return View(await _context.Book.ToListAsync());
        }
    }
}
