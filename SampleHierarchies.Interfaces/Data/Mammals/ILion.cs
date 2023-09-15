using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Interfaces.Data.Mammals
{
    public interface ILion : IMammal
    {
        bool ApexPredator { get; set; }
        bool PackHunter { get; set; }
        string Mane { get; set; }
        bool RoaringCommunication { get; set; }
        bool TerritoryDefense { get; set; }
    }
}
