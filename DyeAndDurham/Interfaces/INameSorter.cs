using DyeAndDurham.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyeAndDurham.Interfaces
{
    internal interface INameSorter
    {
        public List<Person> SortPeople(List<Person> unsortedPeople);
    }
}
