using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BondJames
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName, userAnswer;
            string[] phrase;

            while (true)
            {
                //Take in user's name
                Console.WriteLine("Please enter your name: ");
                userName = Console.ReadLine();

                //Split up user's name into an array of strings
                phrase = userName.Split(' ');

                //Reverse elements in array
                Array.Reverse(phrase, 0, phrase.Length);
                foreach (var word in phrase)
                {
                    //Print each element in array
                    Console.Write(word + " ");
                }

                //Prompt user to continue
                Console.WriteLine(" ");
                Console.WriteLine("Would you like to continue? Type N to quit.");
                userAnswer = Console.ReadLine().ToUpper();
                if (userAnswer == "N")
                {
                    break;
                }
            }
        }
    }
}
