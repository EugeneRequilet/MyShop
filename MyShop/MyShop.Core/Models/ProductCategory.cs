using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyShop.Core.Models
{
    public class ProductCategory : BaseEntity
    {
        // The Id is inherited from the BaseEntity Class

        [Required]
        [DisplayName("Category Description")]
        public string Category { get; set; }
    }
}
