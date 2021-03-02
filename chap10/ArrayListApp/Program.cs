using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ArrayList array = new ArrayList();
            array.Add(80);
            array.Add(74);
            array.Add(81);
            array.Add(90);
            array.Add(34);
            */

            ArrayList array = new ArrayList(new int[] { 80, 74, 81, 90, 34 });

            var LOC = array.IndexOf(81);
        }
    }
}
