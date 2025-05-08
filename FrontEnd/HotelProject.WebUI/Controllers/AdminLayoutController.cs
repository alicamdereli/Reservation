using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult PreLoaderPartial()
        {
            return PreLoaderPartial();
        }

        public PartialViewResult NavHeaderPartial()
        {
            return NavHeaderPartial();
        }

        public PartialViewResult HeaderPartial()
        {
            return HeaderPartial();
        }

        public PartialViewResult SideParPartial()
        {
            return SideParPartial();
        }

        public PartialViewResult FooterPartial()
        {
            return FooterPartial();
        }

        public PartialViewResult ScriptPartial()
        {
            return ScriptPartial();
        }
    }
}