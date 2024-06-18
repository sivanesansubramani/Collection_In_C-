using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionObject
{

    class Collection_InbuildFunctions
    {
        //For Each Loop In collection Object with Int
        public void ForEach_Function_INT()
        {
            List<int> numbers = new List<int> { 1, 2, 3 };
            int[] resultData = numbers.Select(x => x * 2).ToArray();

            //printing a array
            foreach (var i in resultData)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

        //For Each Loop In collection Object with string
        public void ForEach_Function_STRING()
        {
            List<string> numbers = new List<string> { "Chennai","Banglore","Coimbatore","Mumbai" };
            string[] resultData = numbers.Select(x => x + "  Verified").ToArray();

            //printing a array
            foreach (var i in resultData)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

        //contains functions used to find that a value is already exicts in collection list
        public void Contains_Funtion_INT()
        {
            List<int> numbers = new List<int> { 1, 2, 3 };
            bool containsTwo = numbers.Contains(2);
            Console.WriteLine(containsTwo);
            Console.ReadLine();
        }

        public void Contains_Funtion_String()
        {
            List<string> numbers = new List<string> { "Chennai","Coimbatore","TamilNadu","Mumbai","Goa" };
            // Change all characters to lowercase
            var lowerCasePlaces = numbers.Select(place => place.ToLower()).ToList();

            Console.WriteLine("C# is case sencitive Goa and goa are different");

            Console.WriteLine("This result before convertion into Small Case");
            bool containsTwo = numbers.Contains("goa");
            Console.WriteLine(containsTwo);

            Console.WriteLine("This result after convertion into Small Case");
            bool containsTwo1 = lowerCasePlaces.Contains("goa");
            Console.WriteLine(containsTwo1);
            Console.ReadLine();
        }
    }

}
