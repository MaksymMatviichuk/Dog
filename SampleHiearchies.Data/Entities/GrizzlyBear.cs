using SampleHierarchies.Interfaces.Data.Mammals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Data.Entities
{
    public class GrizzlyBear : Mammal, IGrizzlyBear
    {
        public GrizzlyBear(int id, int age, string species, string description,
                           string behaviorDescription, float height, float weight,
                           int numberOfLegs, bool hasFur, bool Hibernation,
                           string OmnivorousDiet, float LargeSize, bool CurvedClaws,
                           string GoodSenseOfSmell)
            : base(id, age, species, description, behaviorDescription, height, weight, numberOfLegs, hasFur)
        {
            this.Hibernation = Hibernation;
            this.OmnivorousDiet = OmnivorousDiet;
            this.LargeSize = LargeSize;
            this.CurvedClaws = CurvedClaws;
            this.GoodSenseOfSmell = GoodSenseOfSmell;
        }

        public bool Hibernation { get; set; }
        public string OmnivorousDiet { get; set; }
        public float LargeSize { get; set; }
        public bool CurvedClaws { get; set; }
        public string GoodSenseOfSmell { get; set; }

    }
}
