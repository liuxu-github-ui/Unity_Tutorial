using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment4
{
    /// <summary>
    /// Converts words to digits
    /// </summary>
    public class Digitizer
    {
        #region Fields

        // declare your Dictionary field and create the Dictionary object for it here

        Dictionary<string, int> digitizer = new Dictionary<string, int>();

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public Digitizer()
        {
            // populate your dictionary field here

            digitizer.Add("zero".ToLower(), 0);

            digitizer.Add("ONe".ToLower(), 1);

            digitizer.Add("tWo".ToLower(), 2);

            digitizer.Add("three".ToLower(), 3);

            digitizer.Add("four".ToLower(), 4);

            digitizer.Add("six".ToLower(), 6);

            digitizer.Add("seven".ToLower(), 7);

            digitizer.Add("eight".ToLower(), 8);

            digitizer.Add("nine".ToLower(), 9);

            digitizer.Add("bob".ToLower(), -1);
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Converts the given word to the corresponding digit.
        /// If the word isn't a valid digit name, returns -1
        /// </summary>
        /// <param name="word">word to convert</param>
        /// <returns>corresponding digit or -1</returns>
        public int ConvertWordToDigit(string word)
        {
            // delete the code below and add your code

            if(word == "zero")
            {
                return 0;
            }else if (word == "one")
            {
                return 1;
            }else if (word == "two")
            {
                return 2;
            }else if (word == "three")
            {
                return 3;
            }else if (word == "four")
            {
                return 4;
            }else if (word == "five")
            {
                return 5;
            }else if (word == "six")
            {
                return 6;
            }else if (word == "seven")
            {
                return 7;
            }else if (word == "eight")
            {
                return 8;
            }else if (word == "nine")
            {
                return 9;
            }else
            {
                return -1;
            }
            
        }

        #endregion
    }
}
