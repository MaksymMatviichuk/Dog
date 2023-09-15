using SampleHierarchies.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Interfaces.Services
{
    public interface ISettingsService
    {
        ISettings LoadSettings(string filePath);
        void SaveSettings(ISettings settings, string filePath);
    }
}
