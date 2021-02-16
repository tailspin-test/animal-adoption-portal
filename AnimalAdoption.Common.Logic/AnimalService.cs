using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAdoption.Common.Logic
{
    public class AnimalService
    {
        public Animal[] ListAnimals => new Animal[] {
            new Animal { Id = 1, Name = "Ribbit", Age = 1, Description = "forg :)" },
            new Animal { Id = 2, Name = "Geck", Age = 2, Description = "Sticky feetsies" },
            new Animal { Id = 3, Name = "Hiss", Age = 4, Description = "Danger noodle" },
        };
    }
}
