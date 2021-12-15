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
        public List<Car> GetCarList()
        {
            return repo.List();
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
    }
}
