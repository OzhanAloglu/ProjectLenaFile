using ProjectLena.Business.Concrete;
using ProjectLena.DataAccess.Concrete;
using ProjectLena.DataAccess.EntityFramework;
using ProjectLena.DataAccess.Migrations;
using ProjectLena.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LenaProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        UserManager userManager = new UserManager(new EfUserDal());

        [HttpGet]
        public ActionResult Index()
        {

            return View();

        }

        [HttpPost]
        public ActionResult Index(User u)
        {         
            Context db = new Context();
            var info = db.Users.FirstOrDefault(x => x.UserName == u.UserName && x.Password == u.Password);

            if (info != null)
            {
                FormsAuthentication.SetAuthCookie(info.UserName, false);
                Session["UserName"] = info.UserName;
                return RedirectToAction("Index", "Form");
            }

            else
            {
                return RedirectToAction("Index");
            }

        }

        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(User user)
        {
            userManager.AddUser(user);
            return RedirectToAction("Index");


        }
    }
}