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

            DanielLibrary.Name n2 = new Name("Joe", "Smoe");
            DanielLibrary.Address a2 = new Address("TN", "Nashville", "Joe", "30565");

            DanielLibrary.Person p1 = new Person("20", n1, a1);
            DanielLibrary.Person p2 = new Person("44", n2, a2);
            DanielLibrary.Person[] p = new Person[2];

            p[0] = p1;
            p[1] = p2;

            return p;

          
        }

        static void Main(string[] args)
        {

            PersonData();
        }

    }
}
