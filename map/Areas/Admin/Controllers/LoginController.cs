using System.Diagnostics;
using System.Data.Common;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Entites;
using Microsoft.AspNetCore.Mvc;
using ViewModel;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using driver.Controllers;
using Microsoft.AspNetCore.Http;
using map.Models;

namespace Admin.Controllers {

   

    public class LoginController : BaseController {
       
        public LoginController (Contextdb _db,IWebHostEnvironment env):base(_db,env)
        {}
           
       

        public IActionResult Index () {

            if ( msg !=null)
            {
               ViewBag.msg=msg;
                msg=null;
            }

            if (User.Identity.GetId() != "")
            {
                return RedirectToAction("privacy", "Home", new { area = "Admin" });
            }
 
            return View ();
        }

         public IActionResult Register () {

            if ( msg !=null)
            {
               ViewBag.msg=msg;
                msg=null;
            }

            if (User.Identity.GetId() != "")
            {
                return RedirectToAction("privacy", "Home", new { area = "Admin" });
            }
 
            return View ();
        }

        public IActionResult reg(Vm_driver user)
        {
            if (db.Tbl_driver.Any(a => a.Username == user.Username ))
            {
                msg="این نام کاربری قبلا ثبت شده است";
                 return RedirectToAction("register", "login", new { area = "Admin" });

                
            }
            if (db.Tbl_driver.Any(a => a.phone == user.phone ))
            {
                msg="این شماره تلفن قبلا ثبت شده است";
                 return RedirectToAction("register", "login", new { area = "Admin" });

                
            }
            if (db.Tbl_driver.Any(a => a.pelak == user.pelak ))
            {
                msg="این پلاک قبلا ثبت شده است";
                 return RedirectToAction("register", "login", new { area = "Admin" });

                
            }

            Tbl_driver driver=new Tbl_driver()
            {
                NameFamily=user.NameFamily,
                phone=user.phone,
                type_car=user.type_car,
                pelak=user.pelak,
                Username=user.Username,
                state=false,
                Password=user.Password,
                profile_img="9.jpg"
             


            };
            db.Tbl_driver.Add(driver);
            db.SaveChanges();

            msg="اطلاعات شما با موفقیت ثبت شد لطفا منتظر تماس ما باشید یا  با ما تماس بگیرید.04435236333";
             return RedirectToAction("register", "login", new { area = "Admin" });
        }
        






        public IActionResult CheckLogin (Vm_driver user)
         {
            var qdriver=db.Tbl_driver.Where(a => a.Username =="Admin" && a.Password== user.Password).SingleOrDefault();
             
             if (qdriver!=null)
             {
                  var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier,qdriver.Id.ToString()),
                    new Claim(ClaimTypes.Name,"Admin")
                };

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal(identity);

                    var properties = new AuthenticationProperties
                    {
                        IsPersistent = true
                    };

                    HttpContext.SignInAsync(principal, properties);
                    return RedirectToAction("privacy", "Home", new { area = "Admin" });
                
             }
             else
             {
                  msg="نام کاربری یا رمز عبور شما اشتباه است";

                  
                   return RedirectToAction("index","login",new { area = "Admin"});
                  

                  
             }
            return View ();
        }
    }
}