using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImageBusiness
    {
        GenericRepository<Image> repo = new GenericRepository<Image>();

        public List<Image> ListImageById(int id)
        {
            return repo.ListById(x => x.CarId == id);
        }
        public void AddImage(Image image)
        {
            repo.Insert(image);
        }
        public List<Image> ListAllImage()
        {
            return repo.List();
        }
    }
}
