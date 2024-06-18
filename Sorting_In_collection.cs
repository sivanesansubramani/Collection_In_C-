using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionObject
{

    public class Person
    {
        public int SerialNumber { get; set; }
        public string Name { get; set; }

        public Person(int serialNumber, string name)
        {
            SerialNumber = serialNumber;
            Name = name;
        }
        public override string ToString()
        {
            return $"SerialNumber: {SerialNumber}, Name: {Name}";
        }
    }

    public class ProgramModel
    {
        public void AscDes_Collection()
        {
            List<Person> people = new List<Person>
        {
            new Person(5, "Alice"),
            new Person(3, "Bob"),
            new Person(1, "Charlie"),
            new Person(4, "David"),
            new Person(2, "Eve")
        };

            // Sort by SerialNumber in ascending order
            var sortedBySerialNumberAsc = people.OrderBy(p => p.SerialNumber).ToList();
            Console.WriteLine("Sorted by SerialNumber (Ascending):");
            sortedBySerialNumberAsc.ForEach(p => Console.WriteLine(p));

            // Sort by SerialNumber in descending order
            var sortedBySerialNumberDesc = people.OrderByDescending(p => p.SerialNumber).ToList();
            Console.WriteLine("\nSorted by SerialNumber (Descending):");
            sortedBySerialNumberDesc.ForEach(p => Console.WriteLine(p));

            // Sort by Name in ascending order
            var sortedByNameAsc = people.OrderBy(p => p.Name).ToList();
            Console.WriteLine("\nSorted by Name (Ascending):");
            sortedByNameAsc.ForEach(p => Console.WriteLine(p));

            // Sort by Name in descending order
            var sortedByNameDesc = people.OrderByDescending(p => p.Name).ToList();
            Console.WriteLine("\nSorted by Name (Descending):");
            sortedByNameDesc.ForEach(p => Console.WriteLine(p));

            Console.ReadLine();
        }
    }
}
