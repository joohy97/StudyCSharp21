using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["일"] = "Uno";
            ht["이"] = "Dos";
            ht["삼"] = "Tres";
            ht["사"] = "Quatro";

            Console.WriteLine(ht["일"]);
            Console.WriteLine(ht["이"]);
            Console.WriteLine(ht["삼"]);
        }
    }
}
