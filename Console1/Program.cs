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


// GetTypeCode / Data Type
            Console.WriteLine("Name is a data type of {0}", name.GetTypeCode());


// Math methods
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
            string nameStr = string.Join(", ", names);

//split an array
            string[] splitArray = nameStr.Split(',');
            Console.WriteLine("Split names array = el[0]:{0} el[1]:{1} el[2]:{2}" , splitArray[0], splitArray[1], splitArray[2]);

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
            sb.Replace("a", "e"); // Replace first char with 2nd char
            sb.Remove(5, 7); // Remove from index 5 up to but not including index 7
            // To output a StringBuilder object it must be converted...
            Console.WriteLine("Converted StringBuilder Object = " + sb.ToString());

// Looping through an array
            int[] randNumArray; //int will be valuetype of every item in the array. This is just DECLARING the array
            int[] randArray = new int[5]; //this DEFINES and DECLARES # of items that will be in the array
            int[] randArray2 = { 1, 2, 3, 4, 5 }; //DECLARE and INITIALIZE an array with a literal
            Console.WriteLine("Array Length = " + randArray.Length);

//for loop
            for (int i = 0; i < randArray.Length; i++)
            {
                Console.WriteLine("Loop {0}: Result = {1}", i, randArray[i]);
            }

            // for each loop
            foreach (int i in randArray2)
            {
                Console.WriteLine("For each loop... " + i);
            }

            // Search in an array
            Console.WriteLine("What element is 1 in randArray? " + Array.IndexOf(randArray2, 1));

// Multi-Dimentional Array

            // Declares with 5 top level elements, with each element being a three element array.
            int[,] multArray = new int[5, 3];

            // can initialize the array at the same time instead
            int[,] multArray2 = { { 0, 1 }, { 2, 3 }, { 4, 5 } };

// Loop through array

            foreach(int el in multArray2)
            {
                Console.WriteLine(el);
            }

            // Loop through nested array

            // multiArray2.Length returns the total number of items in the array
            Console.WriteLine("Length of multArray2 = " + multArray2.Length);

            // multiArray2.GetLength(#) specifies the length of the specified dimension of the multidimensional array 
            for ( int xx = 0; xx < multArray2.GetLength(0); xx++)
            {
                for ( int yy = 0; yy < multArray2.GetLength(1); yy++)
                {
                    Console.Write("Element {0}:{1} = {2}\n", xx, yy, multArray2[xx,yy]);
                }
            }

// Lists | Lists will automatically resize unlike an array.

            // create a new list
            List<int> numList = new List<int>();

            // add items to the list
            numList.Add(4);

            // Create an array to add to the list
            int[] myArray = { 1, 2, 3, 4, 5, 6, 5, 5, 5 };
            numList.AddRange(myArray);

            //create a new list with an array copied to it
            List<int> numList2 = new List<int>(myArray);

            // Insert an item at a specific index
            numList.Insert(1, 10);

            // Remove the first instance of the item from the list (removes the first item 5)
            numList.Remove(5);

            // Remove specific index 
            numList.RemoveAt(3);

            for( int i = 0; i < numList.Count; i++)
            {
                Console.WriteLine("List Item {0} : {1}", i, numList[i]);
            }
            int myInt = 5;
            Console.WriteLine("First instance of 5 is at index: " + numList.IndexOf(myInt));
            myInt = 2;
            Console.WriteLine("Does {0} exist in the list? "+ numList.Contains(myInt), myInt);

            // Create a string list and add a string array element
            List<string> strList = new List<string>(new string[] { "Tom", "Paul" });
            Console.WriteLine("Paul in list? " + strList.Contains("paul", StringComparer.OrdinalIgnoreCase));

            //sort alpha or numerically
            //strList = new List<string>(strList.Sort());
            numList.Sort();

            Console.WriteLine("Sorted");
            foreach (int i in numList)
            { 
                Console.WriteLine("List Item {0}", i);
            }



            // END
            Console.WriteLine("Press any key to quit...");
            Console.Read();
        }
    }
}
