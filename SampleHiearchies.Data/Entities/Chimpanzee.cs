using SampleHierarchies.Interfaces.Data.Mammals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Data.Entities
{
    public class Chimpanzee : Mammal, IChimpanzee
    {
        public Chimpanzee(int id, int age, string species, string description, 
                          string behaviorDescription, float height, float weight,
                          int numberOfLegs, bool hasFur, 
                          bool opposableThumbs, string complexSocialBehavior, bool toolUse,
                          int highIntelligence, string flexibleDiet)
            : base(id, age, species, description, behaviorDescription, height, weight, numberOfLegs, hasFur)
        {
            OpposableThumbs = opposableThumbs;
            ComplexSocialBehavior = complexSocialBehavior;
            ToolUse = toolUse;
            HighIntelligence = highIntelligence;
            FlexibleDiet = flexibleDiet;
        }

        public bool OpposableThumbs { get; set; }
        public string ComplexSocialBehavior { get; set; }
        public bool ToolUse { get; set; }
        public int HighIntelligence { get; set; }
        public string FlexibleDiet { get; set; }
    }
}
