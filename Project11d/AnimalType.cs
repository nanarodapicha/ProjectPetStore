using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11d
{
    public class AnimalType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Animal> Animals { get; set; }
    }
}
