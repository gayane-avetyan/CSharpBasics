using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Hasmik", 11);

            XmlSerializer serializer = new XmlSerializer(typeof(Person));

            using (FileStream stream = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, person);
            }
        }
    }
}
