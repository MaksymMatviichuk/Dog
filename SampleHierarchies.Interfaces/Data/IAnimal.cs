using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Interfaces.Data
{
    public interface IAnimal : IBehaviour
    {
        int Id { get; set; } 
        int Age { get; set; }
        string Species { get; set; }
        string Description { get; set; }
        float Height { get; set; }
        float Weight { get; set; }
    }
}
