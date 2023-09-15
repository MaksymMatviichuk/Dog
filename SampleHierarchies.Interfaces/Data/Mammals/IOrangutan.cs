using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Interfaces.Data.Mammals
{
    public interface IOrangutan : IMammal
    {
        bool ArborealLifestyle { get; set; }
        bool OpposableThumbs { get; set; }
        int IntelligenceLevel { get; set; }
        bool SolitaryBehavior { get; set; }
        bool SlowReproductiveRate { get; set; }

        void BuildNest();
        void UseTools();
        void CommunicateWithGestures();
    }
}
