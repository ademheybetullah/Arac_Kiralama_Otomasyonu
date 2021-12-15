using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerBusiness
    {
        GenericRepository<Customer> repo = new GenericRepository<Customer>();
        public List<Customer> GetCustomerList()
        {
            return repo.List();
        }
        public void DeleteCustomer(Customer customer)
        {
            repo.Delete(customer);
        }
        public void AddCustomer(Customer customer)
        {
            repo.Insert(customer);
        }
        public void CustomerUpdate(Customer customer)
        {
            repo.Update(customer);
        }
    }
}
