using Chewie.Web.Models;
using ServicesLib.WithInterfaces;
using System.Web.Mvc;

namespace Chewie.Web.Controllers
{
    public class InterfacedController : Controller
    {
        private readonly IServiceB serviceB;

        public InterfacedController(IServiceB serviceB)
        {
            this.serviceB = serviceB;
        }

        public ActionResult Index()
        {
            var model = new TheServiceMessage
            {
                Message = this.serviceB.HitItChewie()
            };

            return View(model);
        }
    }
}