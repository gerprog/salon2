using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Salon.Domain.Models;

namespace Salon.Domain.Controllers
{
    public class SalonController : Controller
    {
        //
        // GET: /Salon/

        public string Index()
        {
            return "Hello from Salon.Index()";
        }
        //
        // GET: /Salon/Browse?treatmentType=Hair

        public ActionResult Browse(string TreatmentType)
        {
            var TreatmentTypeModel = new TreatmentType { Name = TreatmentType };
            return View(TreatmentTypeModel);
        }
        //
        // GET: /Salon/Details/5

        public ActionResult Details(int id)
        {
            var TreatmentName = new TreatmentName { TreatmentTitle = "TreatmentName " + id };
            return View(TreatmentName);
        }
    }
}
