using DyeAndDurham.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyeAndDurham.Logic
{
    public class NameSorter : INameSorter
    {
        public List<Person> SortPeople(List<Person> unsortedPeople)
        {
            List<Person> sortedPeople = new List<Person>();
            sortedPeople.Add(unsortedPeople.First());
            unsortedPeople.RemoveAt(0);
            foreach (Person unsortedPerson in unsortedPeople)
            {
                bool sorted = false;
                for (int i = 0; i<sortedPeople.Count; i++)
                {
                    if (Compare(unsortedPerson, sortedPeople[i]))
                    {
                        sortedPeople.Insert(i, unsortedPerson);
                        sorted = true;
                        break;
                    }
                }
                if(!sorted)
                    sortedPeople.Add(unsortedPerson);
            }
            return sortedPeople;
        }

        //compares surnames first
        private bool Compare(Person personA, Person personB)
        {
            if (string.Compare(personA.surName, personB.surName) > 0)
                return false;
            if (string.Compare(personA.surName, personB.surName) < 0)
                return true;

            //if surnames are the same, goes into recursive loop through the firstnames
            return Compare(personA.firstNames, personB.firstNames);
        }

        //recursive loop through first names
        private bool Compare(List<string> namesA, List<string> namesB)
        {
            //compares the first firstnames
            if (string.Compare(namesA.First(), namesB.First()) > 0)
                return true;
            if (string.Compare(namesA.First(), namesB.First()) < 0)
                return false;

            //if they are the same remove the first element of each list
            namesA.Remove(namesA.First());
            namesB.Remove(namesB.First());

            //first one to run out of names is alphabetically first
            if (!namesA.Any())
                return true;
            if (!namesB.Any())
                return false;

            //if both still have names, run this method again
            return Compare(namesA, namesB);
        }

    }
}
