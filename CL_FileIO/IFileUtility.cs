using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_FileIO
{
    public interface IFileUtility
    {
        // Add a interface method called WriteToFile here:
        void WriteToFile(string value);

        // It should return void and take a string parameter called value

        // Add another interface method called ReadFromFile
        string ReadFromFile();

        // It should return a string and take no parameters
    }
}
