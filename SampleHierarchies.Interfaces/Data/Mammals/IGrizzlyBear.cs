using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Interfaces.Data.Mammals
{
    public interface IGrizzlyBear : IMammal
    {
        bool Hibernation { get; set; }
        string OmnivorousDiet { get; set; }
        float LargeSize { get; set; }
        bool CurvedClaws { get; set; }
        string GoodSenseOfSmell { get; set; }
    }
}
