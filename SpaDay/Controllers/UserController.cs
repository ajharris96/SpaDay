using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/user/add")]
        public IActionResult Add()
        {
            if(ViewBag.passverified == null)
            {
                ViewBag.passverified = true;
            }
            
            return View();
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {

            ViewBag.username = newUser.Username;
            ViewBag.email = newUser.Email;
            ViewBag.date = newUser.Created;
            if (newUser.VerifyPassword(verify))
            {
                ViewBag.passverified = true;
                
                return View("Index");
            }
             
          
            ViewBag.passverified = false;
            return View("Add");
            
            
        }
    }
}
