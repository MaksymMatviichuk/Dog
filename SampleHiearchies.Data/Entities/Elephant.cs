using SampleHierarchies.Interfaces.Data.Mammals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SampleHierarchies.Data.Entities
{
    public class Elephant : Mammal, IElephant
    {
        public Elephant(int id, int age, string species, string description,
                        string behaviorDescription, float height, float weight,
                        int numberOfLegs, float TuskLength, string SocialBehavior, bool hasFur) 
            : base(id, age, species, description, behaviorDescription, height, weight, numberOfLegs, hasFur)
        {
            this.TuskLength = TuskLength;
            this.SocialBehavior = SocialBehavior;
        }

        public float TuskLength { get; set; }
        public string SocialBehavior { get; set; }
    }
}
