using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CarBusiness
    {
        GenericRepository<Car> repo = new GenericRepository<Car>();
        public List<Car> GetCarList(int id)
        {
            return repo.ListById(x => x.CompanyId==id);
        }
        public void DeleteCar(Car car)
        {
            repo.Delete(car);
        }
        public void AddCar(Car car)
        {
            repo.Insert(car);
        }
        public void CarUpdate(Car car)
        {
            repo.Update(car);
        }
        public List<Car> ListAllCar()
        {
            return repo.List();
        }
        public Car GetCarById(int id)
        {
            return repo.Get(x => x.CarId == id);
        }
    }
}
