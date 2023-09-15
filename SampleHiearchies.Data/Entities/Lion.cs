using SampleHierarchies.Interfaces.Data.Mammals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Data.Entities
{
    public class Lion : Mammal, ILion
    {
        public Lion(int id, int age, string species, string description, string behaviorDescription, float height, float weight,
                    int numberOfLegs, bool hasFur, bool apexPredator, bool packHunter,
                    string mane, bool roaringCommunication, bool territoryDefense)
            : base(id, age, species, description, behaviorDescription, height, weight, numberOfLegs, hasFur)
        {
            ApexPredator = apexPredator;
            PackHunter = packHunter;
            Mane = mane;
            RoaringCommunication = roaringCommunication;
            TerritoryDefense = territoryDefense;
        }

        public bool ApexPredator { get; set; }
        public bool PackHunter { get; set; }
        public string Mane { get; set; }
        public bool RoaringCommunication { get; set; }
        public bool TerritoryDefense { get; set; }

    }
}
