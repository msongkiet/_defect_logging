using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace geoluxe_defect_logging.Models
{
    public class QC_DefectDataInputModels
    {

    }

    public class SlabIDPartialModels
    {
        [Required(ErrorMessage = "Slab ID is required")]
        [StringLength(5)]
        [Display(Name = "Slab ID")]
        public string SlabID { get; set; }
        
        // Initailize model
        public SlabIDPartialModels()
            {
                SlabID = "";
            }
    }

    public class SlabDetailPartialModels
    {
        public string SlabID { get; set; }
        [Display(Name = "Order No.")]
        public string OrderNo { get; set; }
        [Display(Name = "Mat. Type")]
        public string MatType { get; set; }

        public string SlabWidth_1 { get; set; }
        public string SlabWidth_2 { get; set; }

        public string SlabLength_1 { get; set; }
        public string SlabLength_2 { get; set; }

        public string SlabThickness_1 { get; set; }
        public string SlabThickness_2 { get; set; }
        public string SlabThickness_3 { get; set; }
        public string SlabThickness_4 { get; set; }
        public string SlabThickness_5 { get; set; }
        public string SlabThickness_6 { get; set; }

        public string Shades { get; set; }

        // Initailize model
        public SlabDetailPartialModels()
        {
            OrderNo = "";
            MatType = "";
            SlabWidth_1 = "";
            SlabWidth_2 = "";
            SlabLength_1 = "";
            SlabLength_2 = "";
            SlabThickness_1 = "";
            SlabThickness_2 = "";
            SlabThickness_3 = "";
            SlabThickness_4 = "";
            SlabThickness_5 = "";
            SlabThickness_6 = "";
        }
    }

    public class DefectDetailPartialModels
    {
        [Display(Name = "Dist. X (mm)")]
        public string DistX { get; set; }

        [Display(Name = "Dist. Y (mm)")]
        public string DistY { get; set; }

        public string DefectType { get; set; }

        public bool Reprocess { get; set; }

        // Initailize model
        public DefectDetailPartialModels()
        {
            DistX = "";
            DistY = "";
            DefectType = "";
            Reprocess = false;
        }
    }

    public class DefectListPartialModels
    {
        [Display(Name = "Status")]
        public string Status { get; set; }

        // Initailize model
        public DefectListPartialModels()
        {
            Status = "" ;
        }
    }
}