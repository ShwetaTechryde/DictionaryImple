using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DictionaryImple.Models;
using DictionaryImple.Services;
namespace DictionaryImple.Services
{
    public class Dictionaryservices
    {
        Dictionary<int, Emplpyee> empDictionary = new Dictionary<int, Emplpyee>();

        public void AddEmployee(Emplpyee employee)
        {

            if (empDictionary.ContainsKey(employee.ID))
            {
                System.Console.WriteLine($"{employee.ID} Exists"); //interpolation in c#
            }
            else
            {
                empDictionary.Add(employee.ID, employee);
                System.Console.WriteLine("Record added in dictionary");
            }
        }
       
    }
}