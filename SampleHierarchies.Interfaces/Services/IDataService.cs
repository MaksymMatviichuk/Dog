using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Interfaces.Services
{
    public interface IDataService<T>
    {
        void SaveData(List<T> data, string filePath);
        List<T> LoadData(string filePath);
    }
}
