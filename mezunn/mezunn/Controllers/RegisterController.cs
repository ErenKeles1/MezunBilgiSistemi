using BussinesLayer.Concrete;
using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace mezunn.Controllers
{
    public class RegisterController : Controller
    {

        RegisterManager rm = new RegisterManager();



       


        [HttpGet]
        
        public ActionResult AddRegister()
        {
            
            return View();

        }
        [HttpPost]
        public ActionResult AddRegister(Register p)
        {
            rm.GetAddRegister(p);
           
            
            return RedirectToAction("HomePage", "Home");
        }



    }
}