using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int num01;
            //float decimalpoint = 102.3; 
            double decimalpoint02 = 10.444; //float with more precision
            bool  trueOrFalse = true;
            string sentence = "Hello World";

            int num02;

            Console.Write("type a number to be multipled:");
            num01 = Convert.ToInt32 (Console.ReadLine());
            Console.Write("Type another number: ");
            num02 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result is " + num01 * num02);
            Console.ReadKey();
        }
    }
}
