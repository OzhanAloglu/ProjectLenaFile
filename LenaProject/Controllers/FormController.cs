using FluentValidation.Results;
using ProjectLena.Business.Concrete;
using ProjectLena.Business.ValidationRules.FluentValidation;
using ProjectLena.DataAccess.Concrete;
using ProjectLena.DataAccess.EntityFramework;
using ProjectLena.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace LenaProject.Controllers
{
    [Authorize]
    public class FormController : Controller
    {
        
        FormManager formManager = new FormManager(new EfFormDal());
        Context context = new Context();
       
        public ActionResult Index(string p)
        {
            var values = from x in context.Forms select x;

            if (!string.IsNullOrEmpty(p))
            {
                values=values.Where(m=>m.FormName.Contains(p));

            }

            return View(values.ToList());
        }



        [HttpGet]
        public ActionResult AddForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddForm(Form form)
        {
          
            form.CreateAt = DateTime.Now;
            formManager.FormAdd(form);
            return RedirectToAction("Index");

        }


        [HttpGet]
        public ActionResult FormDetails(int id)
        {
            var formValue = formManager.GetByID(id);
            return View(formValue);
        }
    }
}