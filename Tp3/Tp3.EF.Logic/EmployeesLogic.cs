using System;
using System.Collections.Generic;
using System.Linq;
using Tp7.Entities;

namespace Tp7.Logic
{
    public class EmployeesLogic : BaseLogic, IABMLogic<Employees>
    {
        public void Add(Employees newEmployee)
        {
            try
            {
                context.Employees.Add(newEmployee);

                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void Delete(int id)
        {
            try
            {
                var EmployeeAEliminar = context.Employees.Find(id);
                context.Employees.Remove(EmployeeAEliminar);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public List<Employees> GetAll()
        {
            try
            {
                return context.Employees.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public int MaxID()
        {
            try
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
            catch (Exception ex)
            {

                throw ex;
            }
            

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
