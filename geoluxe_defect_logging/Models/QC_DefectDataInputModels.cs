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
        [Key]
        [Required]
        [Display(Name = "Slab ID")]
        public string SlabID { get; set; }
    }

    public class SlabDetailPartialModels
    {
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
    }

    public class DefectDetailPartialModels
    {
        [Display(Name = "Dist. X (mm)")]
        public string DistX { get; set; }

        [Display(Name = "Dist. Y (mm)")]
        public string DistY { get; set; }

        public string DefectType { get; set; }

        public bool Reprocess { get; set; }
    }

    public class DefectListPartialModels
    {
        [Display(Name = "Status")]
        public bool Status { get; set; }
    }
}