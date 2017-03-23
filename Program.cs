using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanielLibrary;

namespace Daniel_assignment6
{
    class Program
    { 
        public static int[] PersonData()
        {
            DanielLibrary.Name n1 = new Name("Amir", "Daniel");
            DanielLibrary.Address a1 = new Address("TN", "Nashville", "Joe", "30565");

            DanielLibrary.Name n2 = new Name("Amir", "Daniel");
            DanielLibrary.Address a2 = new Address("TN", "Nashville", "Joe", "30565");

            DanielLibrary.Person[] p = new Person[2];

            return p;

          
        }

        static void Main(string[] args)
        {

            PersonData();
        }

    }
}
