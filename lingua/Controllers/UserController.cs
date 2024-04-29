using lingua.dal;
using lingua.Models;
using Microsoft.AspNetCore.Mvc;

namespace lingua.Controllers
{
	public class UserController : Controller
	{
		public IActionResult Index()
		{
			dalUser dbUser = new dalUser();
			var userList = dbUser.GetUserList();
			//ViewBag.userList = userList;
			return View(userList);

		}
	}
}
