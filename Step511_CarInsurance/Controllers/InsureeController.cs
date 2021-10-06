using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Step511_CarInsurance.Models;

namespace Step511_CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }
        
        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public decimal Calculate(DateTime dob, int year, string make, string model, bool duiInfo, int tickets, bool coverageType)
        {
            decimal quote = 50;
            int age = DateTime.Now.Subtract(dob).Days;
            age = age / 365;

            if (age <= 18)
            {
                quote += 100;
            }
            if (19 <= age && age <= 25)
            {
                quote += 50;
            }
            if (25 < age)
            {
                quote += 25;
            }
            if (year < 2000)
            {
                quote += 25;
            }
            if (year > 2015)
            {
                quote += 25;
            }
            if (make == "Porsche")
            {
                quote += 25;
            }
            if (make == "Porsche" && model == "911 Carrera")
            {
                quote += 25;
            }
            if (tickets > 0)
            {
                quote += (tickets * 10);
            }
            if (duiInfo == true)
            {
                quote = quote * Convert.ToDecimal(1.25);
            }
            if (coverageType == true)
            {
                quote = quote * Convert.ToDecimal(1.50);
            }
            return quote;
        }

        [HttpPost]
        public ActionResult CreateAndCalculate(string firstName, string lastName, string emailAddress, DateTime dateOfBirth, int carYear, string carMake, string carModel, bool dui, int speedingTickets, bool coverageType, decimal quote)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(dateOfBirth.ToString()) || string.IsNullOrEmpty(carYear.ToString()) || string.IsNullOrEmpty(carMake.ToString()) || string.IsNullOrEmpty(carModel.ToString()) || string.IsNullOrEmpty(speedingTickets.ToString()) || string.IsNullOrEmpty(quote.ToString()))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (InsuranceEntities db = new InsuranceEntities())
                {
                    var insuree = new Insuree();
                    insuree.FirstName = firstName;
                    insuree.LastName = lastName;
                    insuree.EmailAddress = emailAddress;
                    insuree.DateOfBirth = dateOfBirth;
                    insuree.CarYear = carYear;
                    insuree.CarMake = carMake;
                    insuree.CarModel = carModel;
                    insuree.DUI = dui;
                    insuree.SpeedingTickets = speedingTickets;
                    insuree.CoverageType = coverageType;
                    insuree.Quote = Calculate(dateOfBirth, carYear, carMake, carModel, dui, speedingTickets, coverageType);

                    db.Insurees.Add(insuree);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
        }
    }
}
