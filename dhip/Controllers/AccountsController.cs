using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dhip.Models.db;
using dhip.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dhip.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        DhiphayaContext dhiphayaContext = new DhiphayaContext();

        public ActionResult Index()
        {
            var acc = from a in dhiphayaContext.Account select a;
            return View();
        }

        public ActionResult Validate(AccountsViewModel user)
        {
            var _user = (from a in dhiphayaContext.Account
                         where (a.Email == user.Email && a.Password == user.Password)
                         select new AccountsViewModel
                         {
                             Email = user.Email,
                             Password = user.Password,
                             Role = a.Role
                         }).FirstOrDefault();
            if (_user != null)
            {
                if (_user.Role == "Admin     ")
                {
                    return Json(new { status = true, message = "Admin Login Successfull!", isAdmin = true });
                }
                if (_user.Role == "Customer  ")
                {
                    return Json(new { status = true, message = "Customer Login Successfull!", isAdmin = false });
                }
            }
            return Json(new { status = true, message = "Login Unsuccessfull!" });
            //var _user = dhiphayaContext.Account.Where(userAdmin => userAdmin.Email == user.Email);

            //if (_user.Where(_user => _user.Password == user.Password).Any())
            //{
            //    if (_user.Where(_user => _user.Role == "Admin"))
            //    {
            //        return Json(new { status = true, message = "Login Successfull!" });
            //    }
            //}
            //else
            //{
            //    return Json(new { status = false, message = "Invalid Email!" });
            //}

            //if (_admin.Any())
            //{
            //    if (_admin.Where(s => s.Password == admin.Password).Any())
            //    {

            //        return Json(new { status = true, message = "Login Successfull!" });
            //    }
            //    else
            //    {
            //        return Json(new { status = false, message = "Invalid Password!" });
            //    }
            //}
            //else
            //{
            //    return Json(new { status = false, message = "Invalid Email!" });
            //}
        }


        // GET: Accounts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Accounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accounts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Accounts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Accounts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Accounts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Accounts/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}