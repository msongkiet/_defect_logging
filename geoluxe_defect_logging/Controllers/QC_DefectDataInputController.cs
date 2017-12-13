using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using geoluxe_defect_logging.Models;

namespace geoluxe_defect_logging.Controllers
{
    public class QC_DefectDataInputController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        //// POST: Index
        //[HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]
        //public ActionResult Index(IndexModels models)
        //{
        //    string Slab_ID = models.Slab_ID;
        //    return RedirectToAction("SlabDetail", "QC_DefectDataInput", models);
        //}

        //// GET: Slab_Detail 
        //public ActionResult SlabDetail(IndexModels models)
        //{
        //    string Slab_ID = models.Slab_ID;
        //    ViewBag.Message = Slab_ID;
        //    return View();
        //}

        //// POST: Slab_Detail 
        //[HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]
        //public ActionResult SlabDetail(FormCollection form)
        //{
        //    string Slab_ID = form["Slab_ID"];

        //    string SlabWidth_1 = form["SlabWidth_1"];
        //    string SlabWidth_2 = form["SlabWidth_2"];

        //    string SlabLength_1 = form["SlabLength_1"];
        //    string SlabLength_2 = form["SlabLength_2"];

        //    string SlabThickness_1 = form["SlabThickness_1"];
        //    string SlabThickness_2 = form["SlabThickness_2"];
        //    string SlabThickness_3 = form["SlabThickness_3"];
        //    string SlabThickness_4 = form["SlabThickness_4"];
        //    string SlabThickness_5 = form["SlabThickness_5"];
        //    string SlabThickness_6 = form["SlabThickness_6"];

        //    string Shades = form["Shades"];

        //    if (ModelState.IsValid)
        //    {
        //        Response.Write("<script>alert('Pass');</script>");
        //    }
        //    else
        //    {
        //        Response.Write("<script>alert('Fail');</script>");
        //    }

        //    return RedirectToAction("DefectDetail", "QC_DefectDataInput");
        //}


        // GET : Slab ID Partial View
        public ActionResult SlabIDPartial()
        {
            return View();
        }

        // GET : Slab Detail Partial View
        public ActionResult SlabDetailPartial()
        {
            return View();
        }

        // GET : Defect Detail Partial View
        public ActionResult DefectDetailPartial()
        {
            return View();
        }

        // GET : Defect List Partial View
        public ActionResult DefectListPartial()
        {
            return View();
        }
    }
}