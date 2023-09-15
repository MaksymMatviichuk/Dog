using SampleHierarchies.Interfaces.Data.Mammals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Data.Entities
{
    public class BengalTiger : Mammal, IBengalTiger
    {
        public BengalTiger(int id, int age, string species, string description,
                           string behaviorDescription, float height, float weight,
                           int numberOfLegs, bool hasFur, bool ApexPredator,
                           float LargeSize, string CamouflageFur,
                           bool PowerfulLegs, bool SolitaryBehavior)
            : base(id, age, species, description, behaviorDescription, height, weight, numberOfLegs, hasFur)
        {
            this.ApexPredator = ApexPredator;
            this.LargeSize = LargeSize;
            this.CamouflageFur = CamouflageFur;
            this.PowerfulLegs = PowerfulLegs;
            this.SolitaryBehavior = SolitaryBehavior;
        }

        public bool ApexPredator { get; set; }
        public float LargeSize { get; set; }
        public string CamouflageFur { get; set; }
        public bool PowerfulLegs { get; set; }
        public bool SolitaryBehavior { get; set; }
    }
}
