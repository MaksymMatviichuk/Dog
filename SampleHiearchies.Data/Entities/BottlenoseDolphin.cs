using SampleHierarchies.Interfaces.Data.Mammals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Data.Entities
{
    public class BottlenoseDolphin : Mammal, IBottlenoseDolphin
    {
        public BottlenoseDolphin(int id, int age, string species, string description,
                                 string behaviorDescription, float height, float weight,
                                 int numberOfLegs, bool hasFur, bool Echolocation,
                                 string SocialBehavior, bool PlayfulBehavior, int LargeBrain,
                                 bool HighSpeedSwimming)
            : base(id, age, species, description, behaviorDescription, height, weight, numberOfLegs, hasFur)
        {
            this.Echolocation = Echolocation;
            this.SocialBehavior = SocialBehavior;
            this.PlayfulBehavior = PlayfulBehavior;
            this.LargeBrain = LargeBrain;
            this.HighSpeedSwimming = HighSpeedSwimming;
        }

        public bool Echolocation { get; set; }
        public string SocialBehavior { get; set; }
        public bool PlayfulBehavior { get; set; }
        public int LargeBrain { get; set; }
        public bool HighSpeedSwimming { get; set; }

    }
}
