using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Foundation.GlassMapper;
using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Foundation.GlassMapper.Models;
using Sitecore.Feature.Navigation.Models;

namespace Sitecore.Feature.Navigation.Controllers
{
    public class NavigationController : GlassController
    {
        // GET: Navigation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PrimaryMenu()
        {
            var homeItem = SitecoreContext.GetItem<HomeItem>("08D1C4DA-CEB5-4B91-99D2-7A35B58CFC17");
            return View(homeItem);
        }
    }
}