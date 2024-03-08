﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuySell.Models
{
    public class Laptop
    {
        [Display(Name = "Laptop ID")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Accessory Brand is required.")]
        [Display(Name = "Accessory Brand")]
        public int AccessoryBrandID { get; set; }

        [Required(ErrorMessage = "Operating System is required.")]
        [Display(Name = "Operating System")]
        public string OperatingSystem { get; set; }

        [Required(ErrorMessage = "Ram is required.")]
        [Display(Name = "Ram")]
        public string Ram { get; set; }

        [Required(ErrorMessage = "Processor is required.")]
        [Display(Name = "Processor")]
        public string Processor { get; set; }

        [Required(ErrorMessage = "Hard Disk is required.")]
        [Display(Name = "Hard Disk")]
        public string HardDisk { get; set; }

        [Required(ErrorMessage = "Ad ID.")]
        [Display(Name = "Ad")]
        public int AdID { get; set; }

        public virtual AccessoryBrand AccessoryBrand { get; set; }
        public virtual Ad Ad { get; set; }
    }
}
