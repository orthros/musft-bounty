using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BountyCount.Controllers
{
    public class DashboardController : Controller
    {
        UserBounty db = new UserBounty();

        // GET: Dashboard
        public ActionResult Index()
        {
            var topUsers = db.Users.OrderByDescending(x => x.BountiesCompleted).Take(10);
            return View("Index",topUsers);
        }
    }
}