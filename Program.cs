using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //collection object arrange in accending and decending order with Orderby
            //ProgramModel obj5 = new ProgramModel();
            //obj5.AscDes_Collection();



            //Basics Inbuild functions in Collection Object
            Collection_InbuildFunctions obj4 = new Collection_InbuildFunctions();
            //obj4.ForEach_Function_INT(); //with int multiplication operation for each array element
            //obj4.ForEach_Function_STRING(); //with string concadition function
            //obj4.Sort_Function(); //sorting collection data with int
            //obj4.Contains_Funtion_INT(); //find value excit in collection data or not
            obj4.Contains_Funtion_String();


            //in collection object find today birthday student data with LINQ
            //ModelCollectionObject obj3 = new ModelCollectionObject();
            //obj3.FindToday_DOB();


            //Receipt No Calculation For Next next Receipt With Static collection Object
            //Print_Collection_Withoutloop obj2 = new Print_Collection_Withoutloop();
            //obj2.PrintWihoutLoop();


            ////Receipt No Calculation For Next next Receipt With Static collection Object
            //ReciptNo_Calculations obj1 = new ReciptNo_Calculations();
            //obj1.NextReceiptCalculations();

        }
    }
}
