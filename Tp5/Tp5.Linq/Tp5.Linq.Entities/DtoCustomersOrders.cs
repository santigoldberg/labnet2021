using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp5.Linq.Entities
{
    public class DtoCustomersOrders
    {
        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }

        public int OrderID { get; set; }

        public DateTime? OrderDate { get; set; }



    }
}
