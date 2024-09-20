using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyeAndDurham.File_Readers
{
    public class FileReader
    {
        public List<string> ReadFile(string fileName)
        {
            return File.ReadAllLines(fileName).ToList<string>();
        }

    }
}
