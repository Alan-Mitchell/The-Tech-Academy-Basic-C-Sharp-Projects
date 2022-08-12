using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureesController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        public ActionResult Admin()
        {


            return View(db.Insurees.ToList());
        }
        // GET: Insurees
        public ActionResult Index()
        {


            return View(db.Insurees.ToList());
        }

        // GET: Insurees/Details/5
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

        // GET: Insurees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insurees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateofBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageTypes,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = CalcQuote(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insurees/Edit/5
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

        // POST: Insurees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateofBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageTypes,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insurees/Delete/5
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

        // POST: Insurees/Delete/5
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

        public decimal CalcQuote(Insuree insuree)
        {
            decimal quotePrice = 50m;

            if (insuree.CarYear < 2000 )
            {

                quotePrice += 25;
            }
            if (insuree.CarYear > 2015 )
            {
                quotePrice += 25;
            }
            if (insuree.CarMake == "Porsche")
            {
                quotePrice += 25;
            }
            if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera" )
            {
                quotePrice += 25;
            }
            if (DateTime.Now.Year - insuree.DateofBirth.Year <= 18)
            {
                quotePrice += 100;
            }
            if (DateTime.Now.Year -insuree.DateofBirth.Year >= 19 && DateTime.Now.Year- insuree.DateofBirth.Year <= 25  )
            {
                quotePrice += 50;
            }
            if (DateTime.Now.Year - insuree.DateofBirth.Year >= 26)
            {
                quotePrice += 25;
            }
            if (insuree.SpeedingTickets > 0)
            {
                quotePrice += insuree.SpeedingTickets * 10;
            }
            if(insuree.DUI == true)
            {
                quotePrice += quotePrice * .25m;
            }
            if (insuree.CoverageTypes == true)
            {
                quotePrice += .50m * quotePrice;
            }
            return quotePrice;





        }

        
        
    }
}
