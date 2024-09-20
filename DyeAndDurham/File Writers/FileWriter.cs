using DyeAndDurham.Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyeAndDurham.File_Writers
{
    public class FileWriter
    {
        private readonly string _path = "sorted-names-list.txt";

        public void WriteNames(List<Person> people)
        { 
            if(!File.Exists(_path))
                File.Create(_path);
            File.WriteAllText(_path, string.Empty);
            foreach (Person person in people)
            {
                TextWriter writer = new StreamWriter(_path, true);
                writer.WriteLine(person.GetInfo());
                writer.Close();
            }
        }
    }
}
