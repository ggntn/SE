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
    public class GeneralClaimAdminController : Controller
    {
        DhiphayaContext dhiphayaContext = new DhiphayaContext();
        // GET: GeneralClaimAdmin
        public ActionResult Index()
        {

            return View();
        }
        public IActionResult DetailsTest(int formId)
        {
            CreateFromInsuranceViewModel model = new CreateFromInsuranceViewModel();
            var dataFormId = (from a in dhiphayaContext.CustomerForm
                              where a.formId == formId
                              select a
                              ).FirstOrDefault();
            return View(dataFormId);
        }


        public JsonResult GetListClaim()
        {

            var aa = (from a in dhiphayaContext.CustomerForm
                      select new CreateFromInsuranceViewModel
                      {
                          nameClaim = a.nameClaim,
                          insuranceNo = a.insuranceNo,
                          formId = a.formId,
                      }).ToList();

            return Json(aa);
        }
        public JsonResult GetListData(int houseId)
        {

            //var guy = int
            var data = (from a in dhiphayaContext.Product4
                        from b in dhiphayaContext.ProductDetail
                        from c in dhiphayaContext.Category
                        from d in dhiphayaContext.Unit
                        where 
                        a.CategoryId == houseId &&
                        a.DetailId  == b.productDetailId &&
                        a.productId  == b.productId &&
                        a.UnitId == d.unitId 
                        
                        //b.productId == a.productId &&
                        //a.DetailId == b.productDetailId
                        select new AdminClaimViewModel
                        {
                            //categoryId = houseId,
                            name = b.Name,
                            price = b.price,
                            laborCost = b.laborCost,
                            unit = d.Name,
                        }).Distinct().ToList();
            //var aa = (from a in dhiphayaContext.CustomerForm
            //          select new CreateFromInsuranceViewModel
            //          {
            //              nameClaim = a.nameClaim,
            //              insuranceNo = a.insuranceNo,
            //              formId = a.formId,
            //          }).ToList();

            return Json(data);
        }

        //// GET: GeneralClaimAdmin/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: GeneralClaimAdmin/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: GeneralClaimAdmin/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: GeneralClaimAdmin/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: GeneralClaimAdmin/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: GeneralClaimAdmin/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: GeneralClaimAdmin/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}