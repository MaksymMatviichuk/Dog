using SampleHierarchies.Interfaces.Data.Mammals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Data.Entities
{
    public class Dog : Mammal, IDog
    {
        public Dog(int id, int age, string species, string description, 
                   string behaviorDescription, float height, float weight, 
                   int numberOfLegs, bool hasFur, string breed, bool isTrained)
            : base(id, age, species, description, behaviorDescription, height, weight, numberOfLegs, hasFur)
        {
            Breed = breed;
            IsTrained = isTrained;
        }
        public string Breed { get; set; }
        public bool IsTrained { get; set; }
    }
}
