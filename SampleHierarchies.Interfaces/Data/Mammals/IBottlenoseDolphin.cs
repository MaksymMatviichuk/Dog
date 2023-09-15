using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Interfaces.Data.Mammals
{
    public interface IBottlenoseDolphin : IMammal
    {
        bool Echolocation { get; set; }
        string SocialBehavior { get; set; }
        bool PlayfulBehavior { get; set; }
        int LargeBrain { get; set; }
        bool HighSpeedSwimming { get; set; }
    }
}
