using SampleHierarchies.Interfaces.Data.Mammals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Data.Entities
{
    public class GrayWolf : Mammal, IGrayWolf
    {
        public GrayWolf(int id, int age, string species, string description,
                        string behaviorDescription, float height, float weight,
                        int numberOfLegs, bool hasFur, bool PackHunter,
                        bool HowlingCommunication, string CarnivorousDiet,
                        bool StrongJaws, string GoodSenseOfSmell)
            : base(id, age, species, description, behaviorDescription, height, weight, numberOfLegs, hasFur)
        {
            this.PackHunter = PackHunter;
            this.HowlingCommunication = HowlingCommunication;
            this.CarnivorousDiet = CarnivorousDiet;
            this.StrongJaws = StrongJaws;
            this.GoodSenseOfSmell = GoodSenseOfSmell;
        }

        public bool PackHunter { get; set; }
        public bool HowlingCommunication { get; set; }
        public string CarnivorousDiet { get; set; }
        public bool StrongJaws { get; set; }
        public string GoodSenseOfSmell { get; set; }

    }
}
