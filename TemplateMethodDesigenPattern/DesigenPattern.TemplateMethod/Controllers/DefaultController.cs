using DesigenPattern.TemplateMethod.TemplatePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesigenPattern.TemplateMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.V1 = netflixPlans.PlanType("Temel plan");
            ViewBag.V2 = netflixPlans.CountPerson(1);
            ViewBag.V3 = netflixPlans.Price(120);
            ViewBag.V4 = netflixPlans.Content("Film - Dizi");
            ViewBag.V5 = netflixPlans.Resoulution("1080px");

            return View();
        }
    }
}
