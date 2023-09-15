using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Interfaces.Data.Mammals
{
    public interface IDog : IMammal
    {
        string Breed { get; set; }
        bool IsTrained { get; set; }
    }
}
