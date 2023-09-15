using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Interfaces.Data.Mammals
{
    public interface ICommonBottlenoseWhale : IMammal
    {
        bool Echolocation { get; set; }
        bool ToothedWhale { get; set; }
        int LongLifespan { get; set; }
        bool SociableBehavior { get; set; }
        string FeedsOnSquid { get; set; }

        void NavigateUsingEcholocation();
        void CommunicateWithPodMembers();
        void DiveForPrey();
    }
}
