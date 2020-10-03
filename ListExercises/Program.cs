using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> integers = new List<double>() { 1,2,3,4,5,6,7,8,9,10 };
            Console.WriteLine(Methods.findSum(integers));

            string sentence = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            Methods.printWord(sentence);
        }
    }
}
