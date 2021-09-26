using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp5.Linq.Entities
{
    public class DtoProductsCategories
    {
        [Required]
        [StringLength(40)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(15)]
        public string CategoryName { get; set; }

    }
}
