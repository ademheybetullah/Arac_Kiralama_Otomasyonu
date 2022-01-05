using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CompanyBusiness
    {
        GenericRepository<Company> repo = new GenericRepository<Company>();
        public List<Company> GetCompanyList()
        {
            return repo.List();
        }
        public Company GetById(int id)
        {
            return repo.Get(x=>x.CompanyId==id);
        }
        public void DeleteCompany(Company company)
        {
            repo.Delete(company);
        }
        public void AddCompany(Company company)
        {
            repo.Insert(company);
        }
        public void CompanyUpdate(Company company)
        {
            repo.Update(company);
        }
    }
}
