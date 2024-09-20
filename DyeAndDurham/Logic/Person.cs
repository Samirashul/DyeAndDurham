using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyeAndDurham.Logic
{
    public class Person
    {
        public string surName {  get; set; }
        public List<string> firstNames { get; set; }

        public Person(List<string> firstNames, string surName) 
        {
            this.firstNames = firstNames;
            this.surName = surName;
        }

        public string GetInfo()
        {
            return $"{string.Join(" ", firstNames)} {surName}";
        }

    }
}
