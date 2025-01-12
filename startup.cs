using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DictionaryImple.Models;
using DictionaryImple.Services;

namespace DictionaryImple
{
    public class Startup
    {
        public static void Main()
        {
            Dictionaryservices Dictionaryservices = new Dictionaryservices();


            //Now we can feed the data on that object identifying by the key so that it improves the lookup
            //clustered index is the best example of Dictionary
            //Example: Session creates key internally then we can assign the data

            //object initialisaion property
            try
            {


                Emplpyee employee1 = new Emplpyee
                {
                    ID = 103,
                    Age = int.Parse(Console.ReadLine()),
                    Name = "Steve"
                };
                Emplpyee employee2 = new Emplpyee
                {
                    ID = 103,
                    Age = 30,
                    Name = "David"
                };


                Dictionaryservices.AddEmployee(employee1);
                // employeeDictionary.AddEmployee(employee2);

            }
            catch (FormatException)
            {
                System.Console.WriteLine("input is not correct");
            }

        }
    }

}