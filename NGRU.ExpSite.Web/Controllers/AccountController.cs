using System.Web.Mvc;
using NGRU.ExpSite.Library.Models;
using NGRU.ExpSite.Library.Services;

namespace NGRU.ExpSite.Web.Controllers
{
	public class RegistrationController : Controller
	{
		private readonly AccountService _accountSerice;

		public RegistrationController(AccountService accountSerice)
		{
			_accountSerice = accountSerice;
		}

		public ActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Register(RegisterModel model)
		{
			if (!ModelState.IsValid)
			{
				return View(model);
			}
			else
			{
				var result = _accountSerice.RegisterUser(model);

				if (result.IsSuccess == false)
				{
					ModelState.AddModelError("", result.GetErrorsText());
					return View(model);
				}
				else
				{
					return RedirectToAction("Index", "Home");
				}
			}
		}


	}
}