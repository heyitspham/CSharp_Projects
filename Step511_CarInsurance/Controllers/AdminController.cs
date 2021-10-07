using Step511_CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Step511_CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                //var insurees = db.Insurees.Where(x => x.Removed == null).ToList();
                var insurees = (from c in db.Insurees
                               select c).ToList();
                var Insurees = new List<Insuree>();
                foreach (var ins in insurees)
                {
                    var insuree = new Insuree();
                    insuree.Id = ins.Id;
                    insuree.FirstName = ins.FirstName;
                    insuree.LastName = ins.LastName;
                    insuree.EmailAddress = ins.EmailAddress;
                    insuree.Quote = ins.Quote;
                    Insurees.Add(insuree);
                }
                return View(Insurees);
            }
        }

    }
}