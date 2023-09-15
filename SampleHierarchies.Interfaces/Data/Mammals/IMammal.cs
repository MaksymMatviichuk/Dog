using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Interfaces.Data.Mammals
{
    public interface IMammal : IAnimal
    {
        int NumberOfLegs { get; set; }
        bool HasFur { get; set; }
    }
}
