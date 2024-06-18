using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionObject
{
    class Print_Collection_Withoutloop
    {
        public void PrintWihoutLoop()
        {
            string[] Location = { "Coimbatore", "Chennai", "Bangalore", "Mumbai", "Tamil Nadu", "Noida" };
            List<string> ListData = new List<string>(Location);
            Console.Write(string.Join(" ",ListData));
            Console.ReadLine();
        }
    }
}
