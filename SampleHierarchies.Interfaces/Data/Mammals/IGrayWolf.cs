using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Interfaces.Data.Mammals
{
    public interface IGrayWolf : IMammal
    {
        bool PackHunter { get; set; }
        bool HowlingCommunication { get; set; }
        string CarnivorousDiet { get; set; }
        bool StrongJaws { get; set; }
        string GoodSenseOfSmell { get; set; }
    }
}
