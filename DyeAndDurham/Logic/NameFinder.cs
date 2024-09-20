using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyeAndDurham.Logic
{
    public class NameFinder
    {
        public List<Person> GetNames(List<string> lines)
        {
            List<Person> names = new List<Person>();
            foreach (string line in lines)
            {
                List<string> firstNames = line.Split(" ").ToList();
                string surName = firstNames[firstNames.Count-1];
                firstNames.RemoveAt(firstNames.Count-1);
                names.Add(new Person(firstNames, surName));
            }
            return names;
        }
    }
}
