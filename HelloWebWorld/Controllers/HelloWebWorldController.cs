using System;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace HelloWebWorld.Controllers {

    public class HelloWebWorldController : Controller { 
        public ActionResult index(){
            ViewBag.Message = "Hello E&A Web World";
            return View();
        }
    }
}
