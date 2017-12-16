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

        // POST: Index
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Index(SlabIDPartialModels models)
        {
            //string SlabID = models.SlabID;
            TempData["SlabID"] = models.SlabID;
            return RedirectToAction("SlabDetailPartial", "QC_DefectDataInput", TempData["SlabID"]);
        }

        // GET: Slab Detail
        public ActionResult SlabDetail(SlabDetailPartialModels models)
        {
            //string MatType = TempData["MatType"].ToString();
            //string SlabID = models.SlabID;

            //string SlabID = ViewBag.SlabID;
            //string OrderNo = ViewBag.OrderNo;
            //string MatType = ViewBag.MatType;

            string SlabID = models.SlabID;
            string OrderNo = models.OrderNo;
            string MatType = models.MatType;

            return View();
        }

        // GET: Test
        public ActionResult TestView()
        {
            return View();
        }


        //// POST: Slab Detail 
        //[HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]
        //public ActionResult SlabDetail(FormCollection form)
        //{
        //    //string SlabID = form["SlabID"];

        //    string SlabWidth_1 = form["SlabWidth_1"];
        //    string SlabWidth_2 = form["SlabWidth_2"];

        //    //string SlabLength_1 = form["SlabLength_1"];
        //    //string SlabLength_2 = form["SlabLength_2"];

        //    //string SlabThickness_1 = form["SlabThickness_1"];
        //    //string SlabThickness_2 = form["SlabThickness_2"];
        //    //string SlabThickness_3 = form["SlabThickness_3"];
        //    //string SlabThickness_4 = form["SlabThickness_4"];
        //    //string SlabThickness_5 = form["SlabThickness_5"];
        //    //string SlabThickness_6 = form["SlabThickness_6"];

        //    //string Shades = form["Shades"];

        //    //if (ModelState.IsValid)
        //    //{
        //    //    Response.Write("<script>alert('Pass');</script>");
        //    //}
        //    //else
        //    //{
        //    //    Response.Write("<script>alert('Fail');</script>");
        //    //}
        //    ViewBag.message = "ViewBAG1";
        //    return RedirectToAction("Test", "QC_DefectDataInput", ViewBag.message);
        //}


        // GET : Slab ID Partial View
        public ActionResult SlabIDPartial()
        {
            return View();
        }

        public ActionResult SlabIDPartialReadOnly()
        {
            return View();
        }

        // GET : Slab Detail Partial View
        public ActionResult SlabDetailPartial(SlabDetailPartialModels models)
        {
            //string SlabID = TempData["SlabID"].ToString();
            //string OrderNo = "XXXXX";
            //string MatType = "N/A";

            models.SlabID = TempData["SlabID"].ToString();
            models.OrderNo = "XXXXX";
            models.MatType = "N/A";

            if (models.SlabID != null)
            {
                string str = models.SlabID.Substring(0, 2);

                switch (str)
                {
                    case "10":
                        models.MatType = "ALIVERI";
                        break;
                    case "20":
                        models.MatType = "BLUETTE";
                        break;
                    case "30":
                        models.MatType = "DIONYSOS";
                        break;
                    case "40":
                        models.MatType = "ERAMO";
                        break;
                    case "50":
                        models.MatType = "NESTOS GRAY";
                        break;
                    case "60":
                        models.MatType = "NESTOS ROYAL";
                        break;
                    case "70":
                        models.MatType = "PALISSANDRO";
                        break;
                }
            }

            //ViewBag.SlabID = SlabID;
            //ViewBag.OrderNo = OrderNo;
            //ViewBag.MatType = MatType;

            //TempData["SlabID"] = SlabID;
            //TempData["OrderNo"] = OrderNo;
            //TempData["MatType"] = MatType;

            return RedirectToAction("SlabDetail", "QC_DefectDataInput", models);
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