using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReservationBusiness
    {
        GenericRepository<Reservation> repo = new GenericRepository<Reservation>();
        public List<Reservation> GetRsvListByCarId(int id)
        {
            return repo.ListById(x => x.CarId == id);
        }
        public List<Reservation> GetRsvListByCompanyId(int id)
        {
            return repo.ListById(x => x.CompanyId == id);
        }
        public void DeleteReservation(Reservation reservation)
        {
            repo.Delete(reservation);
        }
        public void AddReservation(Reservation reservation)
        {
            repo.Insert(reservation);
        }
        public void UpdateReservation(Reservation reservation)
        {
            repo.Update(reservation);
        }
        public List<Reservation> ListAllReservations()
        {
            return repo.List();
        }
        public List<Reservation> ListRsvByUserId(int id)
        {
            return repo.ListById(x => x.UserId == id);
        }
        public Reservation GetRsvByRsvId(int id)
        {
            return repo.Get(x => x.ReservationId == id);
        }
    }
}
