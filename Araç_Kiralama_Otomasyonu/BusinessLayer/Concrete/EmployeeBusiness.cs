using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EmployeeBusiness
    {
        GenericRepository<Employee> repo = new GenericRepository<Employee>();
        public List<Employee> GetEmployeeList()
        {
            return repo.List();
        }
        public List<Employee> GetEmployeeListByCompanyId(int id)
        {
            return repo.ListById(x => x.CompanyId == id);
        }
        public Employee GetEmployeeByEmployeeId(int id)
        {
            return repo.Get(x => x.EmployeeId == id);
        }
        public void DeleteEmployee(Employee employee)
        {
            repo.Delete(employee);
        }
        public void AddEmployee(Employee employee)
        {
            repo.Insert(employee);
        }
        public void EmployeeUpdate(Employee employee)
        {
            repo.Update(employee);
        }
    }
}
