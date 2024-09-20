using DyeAndDurham.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsProject
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void TestGetInfo()
        {
            NameFinder finder = new NameFinder();

            List<string> firstNames = new List<string>();
            firstNames.Add("Timmy");
            firstNames.Add("Tucson");
            string surName = "Testington";
            Person person = new Person(firstNames, surName);

            List<string> names = new List<string>();
            names.Add("Timmy Tucson Testington");

            Assert.IsTrue(person.GetInfo().Equals("Timmy Tucson Testington"));
        }

    }
}
