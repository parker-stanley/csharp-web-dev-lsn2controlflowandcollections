using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercises
{
    public class Methods
    {
        public static double findSum(List<double> integers)
        {
            double sum = 0;
            foreach (double number in integers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            return sum;
        }

        public static void printWord(string sentence)
        {
            //List<string> wordsToPrint = new List<string>();
            List<string> splitSentence = sentence.Split(' ').ToList();
            Console.WriteLine("Enter word length to search for:");
            double input = double.Parse(Console.ReadLine());
            foreach (string word in splitSentence)
            {
                if (word.Length == input)
                {
                    Console.WriteLine(word);
                }
            }
            //return wordsToPrint;
        }
    }
}
