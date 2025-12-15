using DesigenpPattern.Observer.Dal;
using DesigenpPattern.Observer.Models;
using DesigenpPattern.Observer.ObserverPattern;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DesigenpPattern.Observer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ObserverObject _Observerobject;

        public DefaultController(UserManager<AppUser> userManager, ObserverObject observer)
        {
            _userManager = userManager;
            _Observerobject = observer;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            var appUser = new AppUser()
            {
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                UserName = model.UserName
            };
            var result = await _userManager.CreateAsync(appUser, model.Password);
            if (result.Succeeded)
            {
                _Observerobject.NotifyObserver(appUser);
                return View();
            }
            return View();
        }
    }
}
