using Chewie.Web.Models;
using ServicesLib.WithInterfaces;
using System.Web.Mvc;

namespace Chewie.Web.Controllers
{
    public class NoInterfaceController : Controller
    {
        private readonly ServiceNoInterfaceB serviceB;

        public NoInterfaceController(ServiceNoInterfaceB serviceB)
        {
            this.serviceB = serviceB;
        }

        public ActionResult Index()
        {
            var model = new TheServiceMessage
            {
                Message = this.serviceB.HelpMeObiWanKenobi()
            };

            return View(model);
        }
    }
}