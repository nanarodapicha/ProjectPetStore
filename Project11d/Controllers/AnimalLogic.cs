using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11d.Controllers
{
    public class AnimalLogic
    {
        public Animal GetAnimalById(int id)
        {
            using (AnimalsContext animalsDbContext = new AnimalsContext())
            {
                Animal findAnimal = animalsDbContext.Animals.Find(id);
                if (findAnimal != null)
                {
                    animalsDbContext.Entry(findAnimal).Reference(d => d.AnimalTypes).Load();
                }
                return findAnimal;
            }
        }
        public List<Animal> GetAllAnimals()
        {
            using (AnimalsContext animalDbContext = new AnimalsContext())
            {
                return animalDbContext.Animals.Include("AnimalTypes").ToList();
            }
        }
        public void AddAnimal(Animal dog)
        {
            using (AnimalsContext animalsDbContext = new AnimalsContext())
            {
                animalsDbContext.Animals.Add(dog);
                animalsDbContext.SaveChanges();
            }
        }
        public void UpdateAnimal(int id, Animal jivotno)
        {
            using (AnimalsContext animalsDbContext = new AnimalsContext())
            {
                Animal animal = animalsDbContext.Animals.Find(id);
                if (animal != null)
                {

                }
                animal.Name = jivotno.Name;
                animal.Age = jivotno.Age;
                animal.AnimalTypeId = jivotno.AnimalTypeId;
                animalsDbContext.SaveChanges();
            }
        }
        public void DeleteAnimal(int id)
        {
            using (AnimalsContext animalsDbContext = new AnimalsContext())
            {
                Animal jivotno = animalsDbContext.Animals.Find(id);
                animalsDbContext.Animals.Remove(jivotno);
                animalsDbContext.SaveChanges();
            }
        }
    }

}
