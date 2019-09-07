using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Registration_MVC.Models;

namespace Registration_MVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult list()
        {
            List<UserModel> userlist = new List<UserModel>();
            var user = new UserModel(1,"Harshdeep","a","a","123","Male","aa.jpg",1);
            userlist.Add(user);

            user = new UserModel(1, "Deep", "a", "a", "123", "Male", "aa.jpg", 1);
            userlist.Add(user);

            user = new UserModel(1, "Raj", "a", "a", "123", "Male", "aa.jpg", 1);
            userlist.Add(user);

            user = new UserModel(1, "Abhishek", "a", "a", "123", "Male", "aa.jpg", 1);
            userlist.Add(user);

            return View(userlist);
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            UserModel userModel = new UserModel();
            userModel.StateId = new StateModel();
            SelectList countryList = new SelectList(userModel.StateId.GetCountries,"CountryId","CountryName");
            SelectList stateList = new SelectList(userModel.GetStates, "StateId", "StateName");

            ViewBag.CountryId = countryList;
            ViewBag.StateId = stateList;
            return View();
        }


        [HttpPost]
        public ActionResult SignUp(UserModel userModel)
        {
            userModel.StateId = new StateModel();
            SelectList countryList = new SelectList(userModel.StateId.GetCountries, "CountryId", "CountryName");
            SelectList stateList = new SelectList(userModel.GetStates, "StateId", "StateName");

            ViewBag.CountryId = countryList;
            ViewBag.StateId = stateList;
            return View();
        }

        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }


        [HttpPost]
        public ActionResult SignIn(UserModel userModel)
        {
            return View();
        }

    }
}