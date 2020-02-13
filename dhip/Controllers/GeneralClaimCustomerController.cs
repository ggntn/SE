using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using dhip.ViewModels;
using dhip.Models.db;

namespace dhip.Controllers
{
    public class GeneralClaimCustomerController : Controller
    {
        // GET: GeneralClaimCustomer
        public ActionResult Index()
        {
            return View();
        }

        // GET: GeneralClaimCustomer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GeneralClaimCustomer/Create
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Test()
        {
            return View();
        }

        // POST: GeneralClaimCustomer/Create

        //[ValidateAntiForgeryToken]
        [HttpPost]
        public JsonResult Create(CreateFromInsuranceViewModel form)
        {
            DhiphayaContext dhiphaya = new DhiphayaContext();
            var customerForm = new CustomerForm();
            customerForm.date = form.date;
            customerForm.incidentDate = form.incidentDate;
            customerForm.timeIncidentDate = form.timeIncidentDate;
            customerForm.nameClaim = form.nameClaim;
            customerForm.phoneClaim = form.phoneClaim;
            customerForm.emailClaim = form.emailClaim;
            customerForm.nameContact = form.nameContact;
            customerForm.phoneContact = form.phoneContact;
            customerForm.emailContact = form.emailContact;
            customerForm.insuranceNo = form.insuranceNo;
            customerForm.place = form.place;
            customerForm.soi = form.soi;
            customerForm.road = form.emailClaim;
            customerForm.province = form.province;
            customerForm.typeHouse = form.typeHouse;
            customerForm.floor = form.floor;
            customerForm.wall = form.wall;
            customerForm.ceiling = form.ceiling;
            customerForm.roof = form.roof;
            customerForm.glass = form.glass;
            customerForm.etc = form.etc;

            customerForm.meterialFloorSelect = form.meterialFloorSelect;
            customerForm.piecesFloor = form.piecesFloor;
            customerForm.unitFloor = form.unitFloor;

            customerForm.meterialWallSelect = form.meterialWallSelect;
            customerForm.piecesWall = form.piecesWall;
            customerForm.unitWall = form.unitWall;

            customerForm.meterialCeilingSelect = form.meterialCeilingSelect;
            customerForm.piecesCeiling = form.piecesCeiling;
            customerForm.unitCeiling = form.unitCeiling;

            customerForm.meterialRoofSelect = form.meterialRoofSelect;
            customerForm.piecesRoof = form.piecesRoof;
            customerForm.unitRoof = form.unitRoof;

            customerForm.meterialGlassSelect = form.meterialGlassSelect;
            customerForm.piecesGlass = form.piecesGlass;
            customerForm.unitGlass = form.unitGlass;

            customerForm.meterialEtcSelect = form.meterialEtcSelect;
            customerForm.piecesEtc = form.piecesEtc;
            customerForm.unitEtc = form.unitEtc;

            customerForm.incidentPrice = form.incidentPrice;
            customerForm.causeIncident = form.causeIncident;
            customerForm.causeIncidentDetail = form.causeIncidentDetail;

            dhiphaya.CustomerForm.Add(customerForm);
            dhiphaya.SaveChanges();
            //var test2 = dhiphaya.Customer.FirstOrDefault(x => x.selfServiceFormId == model.selfServiceFormId && x.registrationGuid == item);
            //CreateFromInsuranceViewModel test
            //var a = test;
            //try
            //{
            //    // TODO: Add insert logic here

            //    return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
            //    return View();
            //}
            return Json(new { status = true, message = "true!" });
        }

        // GET: GeneralClaimCustomer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GeneralClaimCustomer/Edit/5
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

        // GET: GeneralClaimCustomer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GeneralClaimCustomer/Delete/5
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