using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11d
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Age { get; set; }
        public int AnimalTypeId { get; set; } //fk
        public AnimalType AnimalTypes { get; set; }
    }
}
