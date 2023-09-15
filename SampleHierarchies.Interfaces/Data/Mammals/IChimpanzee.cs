using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Interfaces.Data.Mammals
{
    public interface IChimpanzee : IMammal
    {
        bool OpposableThumbs { get; set; }
        string ComplexSocialBehavior { get; set; }
        bool ToolUse { get; set; }
        int HighIntelligence { get; set; }
        string FlexibleDiet { get; set; }
    }
}
