using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionObject
{
    class ToFindToday_Birthday_Model
    {

            public string Name { get; set; }
            public string LastName { get; set; }
            public DateTime DOB { get; set; }        
    }
    public class ModelCollectionObject
    {
        public void FindToday_DOB()
        {
            List<ToFindToday_Birthday_Model> MyCollection = new List<ToFindToday_Birthday_Model>()
        {
            new ToFindToday_Birthday_Model{Name="siva1", LastName="siva2", DOB= new DateTime(2023, 10, 4)},
            new ToFindToday_Birthday_Model{Name="stu1", LastName="stu11", DOB= DateTime.Today},
            new ToFindToday_Birthday_Model{Name="test1", LastName="test2", DOB= new DateTime(2024,06,18)},
            new ToFindToday_Birthday_Model{Name="stu2", LastName="stu22", DOB= new DateTime(2023, 10, 4)},
            new ToFindToday_Birthday_Model{Name="stu3", LastName="stu33", DOB= new DateTime(2023, 11, 9)},
            new ToFindToday_Birthday_Model{Name="stu4", LastName="stu44", DOB= new DateTime(2023, 10, 4)}
        };

            var today = DateTime.Today;

            List<ToFindToday_Birthday_Model> allRecords = MyCollection
                .Where(bioModel => bioModel.DOB.Month == today.Month && bioModel.DOB.Day == today.Day)
                .ToList();

            foreach (ToFindToday_Birthday_Model loopdata in allRecords)
            {
                Console.WriteLine($"{loopdata.Name} {loopdata.LastName} was born on {loopdata.DOB.ToShortDateString()}");
            }
            Console.ReadLine();
        }
    }
}
