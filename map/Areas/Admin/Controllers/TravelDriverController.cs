using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Transactions;
using DataLayer.Context;
using DataLayer.Entites;
using DataLayer.Entites;
using Kavenegar;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModel;
using DataLayer.Context;
using DataLayer.Entites;
using Microsoft.AspNetCore.Hosting;
using driver.Controllers;

namespace Admin.Controllers {
    
    public class TravelDriverController : BaseController {
       
        public TravelDriverController (Contextdb _db,IWebHostEnvironment env):base(_db,env)
         {
         }

        public IActionResult TravelDriver () {
           var qlist=db.tbl_Travels.OrderByDescending(a=>a.Id).ToList();
           ViewBag.List=qlist;
            return View ();
        }

         public IActionResult Driver () {
           var qlist=db.Tbl_driver.OrderByDescending(a=>a.Id).ToList();
           ViewBag.List=qlist;
            return View ();
        }

        public IActionResult active(int id)
        {
            var qlist = db.Tbl_driver.Where(a => a.Id == id).SingleOrDefault();
            if (qlist != null)
            {
                qlist.state = true;
                db.Tbl_driver.Update(qlist);
                db.SaveChanges();
            }
            return RedirectToAction("driver","Traveldriver",new{area="Admin"});
        }
        public IActionResult dactive(int id)
        {
            var qlist = db.Tbl_driver.Where(a => a.Id == id).SingleOrDefault();
            if (qlist != null)
            {
                qlist.state = false;
                db.Tbl_driver.Update(qlist);
                db.SaveChanges();
            }
            return RedirectToAction("driver","Traveldriver",new{area="Admin"});
        }
        
        
          public IActionResult TravelDetails () {
            return View ();
        }
               public IActionResult CurrentRequests () {
            return View ();
        }

    }
}