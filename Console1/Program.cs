using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user to enter a name.
            Console.Write("Enter your name, please:");
            // Now read the name entered
            string name = Console.ReadLine();
            // Greet the user with the entered name
            Console.WriteLine("Hello, " + name);
            // Wait for the user to acknowledge

            Console.WriteLine("Name is a data type of {0}", name.GetTypeCode());

            double pi = 3.14;
            int intPi = (int)pi;
            Console.WriteLine("The type of pi is {0}, the type of intPi is {1}", pi, intPi);

            int max = Math.Max((int)pi, 5);
            Console.WriteLine("int is: {0}", max);

            Random rand = new Random();
            Console.WriteLine("Random # between 1 and 10 is: {0}", (rand.Next(1, 11)));

            Console.Write("Enter Age: ");
            //string age = Console.ReadLine();

            // Can't cast a string to an int. Have to convert it...
            int age = Convert.ToInt32(Console.ReadLine());


            //If...Else if...Else
            if (((int)age >= 5) && (age <=7))
            {
                Console.WriteLine("Elementary");
            } else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Middle");
            } else if ((age >= 13) && (age<19))
            {
                Console.WriteLine("High");
            }
            else
            {
                Console.WriteLine("adult");
            }

            // TERNARY
            bool canDrive = age >= 16 ? true : false;

            if (canDrive)
            {
                Console.WriteLine("{0} can Drive", name);
            } else
            {
                Console.WriteLine("{0} can't drive", name);
            }

            // Do While Loop
            string guess;
            do
            {
                Console.WriteLine("Guess a Number ");
                guess = Console.ReadLine();
            } while (guess != "15");
            //} while (!guess.Equals("15"));

            // For Loop
            for (int i = 0; i < 10; i++)
            {
                // If Odd
                if ((i % 2) > 0)
                {
                    Console.WriteLine(i);
                }                               
            }

            // ForEach Loop
            string randStr = "asodidj";

            foreach(char c in randStr)
            {
                Console.WriteLine(c);
            }


            // String Methods

            //Can't use single quotes for string literals 
            //Single quotes are for character literals (char). 
            //You need double quotes for string literals. 

            string sampString = "A bunch oF Random words";

            Console.WriteLine("Is empty = " + String.IsNullOrEmpty(sampString));

            Console.WriteLine("is empty = " + String.IsNullOrWhiteSpace(sampString));

            Console.WriteLine("String Length = " + sampString.Length);

            Console.WriteLine("Index of bunch = " + sampString.IndexOf("bunch"));
            Console.WriteLine("Substring(2,6) of sampString = " + sampString.Substring(2, 6));

            string sampString2 = "More random words here.";

            Console.WriteLine("Are strings equal? = " + sampString.Equals(sampString2));

            Console.WriteLine("Starts with \"A bunch\" = " + sampString.StartsWith("A bunch"));

            string x = "words";
            Console.WriteLine("Ends with \"words\" = " + sampString.EndsWith(x));

            // Trim whitespace
            sampString = sampString.TrimEnd();
            sampString = sampString.TrimStart();
            sampString = sampString.Trim();

            sampString = sampString.Replace("words", "chars");
            Console.WriteLine("New sampString = " + sampString);

            // Remove from, UP TO the specified Index
            sampString = sampString.Remove(0, 2);
            Console.WriteLine("New sampString = " + sampString);

            // String Array
            string[] names = new string[3] { "Matt", "Joe", "Paul" };
            Console.WriteLine("Names in array = " + String.Join(", ", names));

            // Join strings
            string str1 = "This";
            string str2 = "is";
            string str3 = "New";
            string str4 = "string";
            string fullString = String.Concat(str1, str2, str3, str4);
            Console.WriteLine("This is a concatenated string... " + fullString);

            // String Formatting
            string fmtStr = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 15.567, .56, 1000); //$1.56 15.57 .56 1,000

            // StringBuilder
            StringBuilder sb = new StringBuilder();

            sb.Append("this is the first sentence. ");
            sb.AppendFormat("My name is {0} and I live in {1} ", "John Doe", "Oregon");
            // clear a StringBuilder object
            //sb.Clear()








            Console.WriteLine("Press any key to quit...");
            Console.Read();
        }
    }
}
