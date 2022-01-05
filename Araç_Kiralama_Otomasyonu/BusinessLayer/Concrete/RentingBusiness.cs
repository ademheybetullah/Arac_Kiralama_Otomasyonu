using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class RentingBusiness
    {
        GenericRepository<Renting> repo = new GenericRepository<Renting>();
        public List<Renting> GetRengingListById(int id)
        {
            return repo.ListById(x => x.CarId == id);
        }
        public List<Renting> GetRengingListByCompanyId(int id)
        {
            return repo.ListById(x => x.CompanyId == id);
        }
        public void DeleteRenting(Renting renting)
        {
            repo.Delete(renting);
        }
        public void AddRenting(Renting renting)
        {
            repo.Insert(renting);
        }
        public void UpdateRenting(Renting renting)
        {
            repo.Update(renting);
        }
        public List<Renting> ListAllRentings()
        {
            return repo.List();
        }
        public List<Renting> ListRentingsByUserId(int id)
        {
            return repo.ListById(x=>x.UserId==id);
        }
        public Renting GetRentingByRentingId(int id)
        {
            return repo.Get(x => x.RentingId == id);
        }
    }
}
