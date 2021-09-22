using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp3.EF.Entities;

namespace Tp3.EF.Logic
{
    public class EmployeesLogic : BaseLogic, IABMLogic<Employees>
    {
        public void Add(Employees newEmployee)
        {
            context.Employees.Add(newEmployee);

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var EmployeeAEliminar = context.Employees.Find(id);
            context.Employees.Remove(EmployeeAEliminar);
            context.SaveChanges();
        }

        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }

        public int MaxID()
        {
            int maxId = 0;
            foreach (Employees employee in this.GetAll())
            {
                if (maxId < employee.EmployeeID)
                {
                    maxId = employee.EmployeeID;
                }

            }
            return maxId;

        }

        public void Update(Employees employee)
        {
            var employeeUpdate = context.Employees.Find(employee.EmployeeID);

            employeeUpdate.FirstName = employee.FirstName;

            employeeUpdate.LastName = employee.LastName;

            context.SaveChanges();
        }
    }
}
