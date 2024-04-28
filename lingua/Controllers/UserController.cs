using lingua.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lingua.Controllers
{
    public class UserController : Controller
    {
        private readonly LinguaContext _context;
        public UserController(LinguaContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }
    }
}
