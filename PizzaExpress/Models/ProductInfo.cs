﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaExpress.Models
{
    /// <summary>
    /// Public Properties for Product Table
    /// ProductID is primary key
    /// </summary>
    public class ProductInfo
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [StringLength(200)]
        public string ProductTitle { get; set; }

        [Required]
        [StringLength(200)]
        public string PhotoName { get; set; }

        [Required]
        [StringLength(20)]
        public string ExtName { get; set; }

        [Required]
        [StringLength(200)]
        public string PhotoType { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public int CategoryID { get; set; }

        public CategoryInfo Category { get; set; }

        [NotMapped]
        public BufferedSingleFileUploadDb FileUpload { get; set; }
    }
    public class BufferedSingleFileUploadDb
    {
        [Required]
        [Display(Name = "File")]
        public IFormFile FormFile { get; set; }
    }
}
