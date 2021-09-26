using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp5.Linq.Entities;

namespace Tp5.Linq.Logic
{
    public class CustomersLogic : BaseLogic , IABMLogic<Customers>
    {
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public void Add(Customers newCustomer)
        {
            context.Customers.Add(newCustomer);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var customerAEliminar = context.Customers.First(c => c.CustomerID == id.ToString());
        }

        public void Update(Customers customer)
        {
            var customerUpdate = context.Customers.First(c => c.CustomerID == customer.CustomerID);

            customerUpdate.CompanyName = customer.CompanyName;

            context.SaveChanges();
        }
    }
}
