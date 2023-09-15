using SampleHierarchies.Interfaces.Data.Mammals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Data.Entities
{
    public class CommonBottlenoseWhale : Mammal, ICommonBottlenoseWhale
    {
        public CommonBottlenoseWhale(int id, int age, string species, string description,
                                     string behaviorDescription, float height, float weight,
                                     int numberOfLegs, bool hasFur, bool Echolocation,
                                     bool ToothedWhale, int LongLifespan, bool SociableBehavior,
                                     string FeedsOnSquid)
            : base(id, age, species, description, behaviorDescription, height, weight, numberOfLegs, hasFur)
        {
            this.Echolocation = Echolocation;
            this.ToothedWhale = ToothedWhale;
            this.LongLifespan = LongLifespan;
            this.SociableBehavior = SociableBehavior;
            this.FeedsOnSquid = FeedsOnSquid;
        }

        public bool Echolocation { get; set; }
        public bool ToothedWhale { get; set; }
        public int LongLifespan { get; set; }
        public bool SociableBehavior { get; set; }
        public string FeedsOnSquid { get; set; }

        public void NavigateUsingEcholocation()
        {
            Console.WriteLine("Navigate using echolocation");
        }

        public void CommunicateWithPodMembers()
        {
            Console.WriteLine("Communicate with pod members");
        }

        public void DiveForPrey()
        {
            Console.WriteLine("Dive for prey");
        }
    }
}