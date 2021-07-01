using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using LinkedLists;

namespace ProgrammingAssignment1

{

    // IMPORTANT: Only add code in the section

    // indicated below. The code I've provided

    // makes your solution work with the

    // automated grader on Coursera

    /// <summary>

    /// Programming Assignment 1

    /// </summary>

    class Program

    {

        // holds the list of input numbers

      // public static UnsortedLinkedList<int> values = new UnsortedLinkedList<int>();
       public static List<int> values = new List<int>();

        /// <summary>

        /// Counts and calculates mean of input values

        /// </summary>

        /// <param name="args">command-line args</param>

        static void Main(string[] args)

        {

            // loop while there's more input

            string input = Console.ReadLine();

            while (input[0] != 'q')

            {

                // extract input values from string

                BuildLinkedListFromString(input);

                // Add your code between this comment

                // and the comment below. You can of

                // course add more space between the

                // comments as needed

                float sum = 0, ans = 0;

                // int[] store = new int[10];
                List<int> store = new List<int>();

                int count = values.Count;

                for (int i = 0; i < count; i++)

                {

                    store.Add(GetValue());

                    if (store[i] != -1) { sum += store[i]; }

                    else { count -= 1; }

                }

                ans = sum / count;

                if (count == 0) { ans = 0; }

                Console.WriteLine(count + " " + ans);

                sum = 0;

                // Don't add or modify any code below

                // this comment

                input = Console.ReadLine();

            }

        }

        /// <summary>

        /// Builds a linked list of input values from provided string

        /// </summary>

        /// <param name="input">input string</param>

        /// <returns>linked list of values</returns>

        static void BuildLinkedListFromString(string input)

        {

            // find first space in string

            int spaceIndex = input.IndexOf(' ');

            // loop while there are more spaces in string

            while (spaceIndex != -1)

            {

                // add value to list

                int value = int.Parse(input.Substring(0, spaceIndex));

                values.Add(value);
                

                // move along string and find next space in string

                input = input.Substring(spaceIndex + 1);

                spaceIndex = input.IndexOf(' ');

            }

            // add final node to list

            int finalValue = int.Parse(input);

            values.Add(finalValue);

        }

        /// <summary>

        /// Get a value from the linked list. If the linked

        /// list is empty, returns -1

        /// </summary>

        /// <returns>value or -1 if list is empty</returns>

        static int GetValue()

        {

            // check for empty list

            int value;

            if (values.Count > 0)

            {

                // save value at front of list

                value = values[0];

                // move along list

                values.Remove(value);

            }

            else

            {

                // empty list

                value = -1;

            }

            return value;

        }

    }

}