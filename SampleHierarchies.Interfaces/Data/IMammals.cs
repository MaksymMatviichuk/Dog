using SampleHierarchies.Interfaces.Data.Mammals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Interfaces.Data
{
    public interface IMammals
    {
        List<IMammal> Mammals { get; set; }
    }
}
