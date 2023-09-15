using SampleHierarchies.Interfaces.Data.Mammals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Data.Entities
{
    public class PolarBear : Mammal, IPolarBear
    {
        public PolarBear(int id, int age, string species, string description,
                        string behaviorDescription, float height, float weight,
                        int numberOfLegs, bool hasFur, string FurCoat, 
                        string LargePaws, string CarnivorousDiet, bool SemiAquatic,
                        string SenseOfSmell) : base(id, age, species, description, behaviorDescription, height, weight, numberOfLegs, hasFur)
        {
            this.FurCoat = FurCoat;
            this.LargePaws = LargePaws;
            this.CarnivorousDiet = CarnivorousDiet;
            this.SemiAquatic = SemiAquatic;
            this.SenseOfSmell = SenseOfSmell;
        }

        public string FurCoat { get; set; }
        public string LargePaws { get; set; }
        public string CarnivorousDiet { get; set; }
        public bool SemiAquatic { get; set; }
        public string SenseOfSmell { get; set; }

    }
}
