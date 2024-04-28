using lingua.Models;
using lingua.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace lingua.Controllers
{
	public class ProfileController : Controller
	{
		private readonly LinguaContext _context;
		public ProfileController(LinguaContext context)
		{
			_context = context;
		}
		public async Task<IActionResult> Index()
		{
			var profiles = _context.Profiles.Include(b => b.User);
			return View(await profiles.ToListAsync());
		}

		public IActionResult Create()
		{
			ViewData["Users"] = new SelectList(_context.Users, "UserId", "Email");
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(ProfileViewModel model)
		{
			if (ModelState.IsValid)
			{
				var profile = new Profile()
				{
					EnglishLevel = model.EnglishLevel,
					UserId = model.UserId
				};
				_context.Add(profile);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			ViewData["Users"] = new SelectList(_context.Users, "UserId", "Email", model.UserId);
			return View(model);
		}
	}
}
