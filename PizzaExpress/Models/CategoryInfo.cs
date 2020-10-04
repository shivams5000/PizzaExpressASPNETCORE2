using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaExpress.Models
{
    /// <summary>
    /// public properties for Catgory Table
    /// CategoryID is Primary Key
    /// </summary>
    public class CategoryInfo
    {
        [Key]
        public int CategoryID { get; set; }
        
        [Required]
        [StringLength(200)]
        public string CategoryName { get; set; }

        public ICollection<ProductInfo> Products { get; set; }
    }
}
