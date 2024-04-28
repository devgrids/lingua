using lingua.Models;
using lingua.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lingua.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ApiProfileController : ControllerBase
	{
		private readonly LinguaContext _context;

		public ApiProfileController(LinguaContext context)
		{
			_context = context;
		}

		public async Task<List<ProfileUserViewModel>> Get()
			=> await _context.Profiles.Include(b => b.User)
			.Select(b => new ProfileUserViewModel
			{
				EnglishLevel = (byte)b.EnglishLevel,
				UserId = (int)b.UserId
			})
			.ToListAsync();
	}


}
