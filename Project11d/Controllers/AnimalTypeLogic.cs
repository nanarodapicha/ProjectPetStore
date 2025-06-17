using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11d.Controllers
{
    public class AnimalTypeLogic
    {
        public List<AnimalType> GetAllAnimalTypes()
        {
            using (AnimalsContext animalsDbContext = new AnimalsContext())
            {
                return animalsDbContext.AnimalTypes.ToList();
            }
        }
        public string GetAnimalTypeById(int id)
        {
            using (AnimalsContext animalsDbContext = new AnimalsContext())
            {
                return animalsDbContext.AnimalTypes.Find(id).Name;
            }
        }
    }
}
