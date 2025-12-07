using DesigenPattern.ChainOfResponsibility.ChainOfResbonsibility;
using DesigenPattern.ChainOfResponsibility.Dal;
using DesigenPattern.ChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesigenPattern.ChainOfResponsibility.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel customerProccess)
        {
            Employee treasuer = new Treasurer();
            Employee managerAssistantant = new ManagerAssistantant();
            Employee manager = new Manager();
            Employee areaDireactor = new AreaDirector();

            treasuer.SetNextApprove(managerAssistantant);
            managerAssistantant.SetNextApprove(manager);
            manager.SetNextApprove(areaDireactor);

            treasuer.ProcessRequest(customerProccess);
            return View();
        }
    }
}
