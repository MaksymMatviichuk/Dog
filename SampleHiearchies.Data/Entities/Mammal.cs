using SampleHierarchies.Interfaces.Data.Mammals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Data.Entities
{
    public class Mammal : Animal, IMammal
    {
        public Mammal(int id, int age, string species, string description, string behaviorDescription, float height, float weight, int numberOfLegs, bool hasFur)
            : base(id, age, species, description, behaviorDescription, height, weight)
        {
            NumberOfLegs = numberOfLegs;
            HasFur = hasFur;
        }
        public int NumberOfLegs { get; set; }
        public bool HasFur { get; set; }
    }
}
