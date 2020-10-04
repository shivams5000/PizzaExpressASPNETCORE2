using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaExpress.Models
{
    /// <summary>
    /// public properties for Enquiry Table
    /// EnquiryID is Primary Key
    /// </summary>
    public class EnquiryInfo
    {
        [Key]
        public int EnquiryID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Mobile { get; set; }

        [Required]
        [StringLength(200)]
        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }

        public DateTime EnquiryDate { get; set; }

    }
}
