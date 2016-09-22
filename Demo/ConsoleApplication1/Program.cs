using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] intArray = new int[5] { 8, 10, 2, 6, 3 };
            //Array.Sort(intArray);
            //// write array
            //foreach (int i in intArray) Console.Write(i + " ");  // output: 2 3 6 8 10
           

            string[] stringArray = new string[5] { "X", "B", "Z", "Y", "A" };
            Array.Sort(stringArray);
            Array.Reverse(stringArray);
            // write array
            foreach (string str in stringArray) 
                Console.Write(str + " "); // output: A B X Y Z

            Console.Read();
        }
    }
}
