using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11d
{
    public class AnimalsContext:DbContext
    {
        public AnimalsContext() : base("AnimalsContext")
        {

        }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<AnimalType> AnimalTypes { get; set; }
    }
}
