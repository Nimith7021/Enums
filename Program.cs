using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enumeration.Types;

namespace Enumeration
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            Console.WriteLine("Names of Rainbow colors");
            foreach (string s in Enum.GetNames(typeof(Rainbow))) {

                Console.WriteLine(s);
            }

            Console.WriteLine("Values of Rainbow Colors");
            foreach (int item in Enum.GetValues(typeof(Rainbow)))
            {

                Console.WriteLine(item); 
            
            
            }
        }
    }
}

    

