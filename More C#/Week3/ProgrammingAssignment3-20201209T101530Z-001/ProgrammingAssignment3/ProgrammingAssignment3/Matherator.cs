using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment3
{
    /// <summary>
    /// Provides a variety of numeric methods
    /// </summary>
    public class Matherator
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public Matherator()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// Prints the numbers from 1 to 10
        /// </summary>
        public void PrintOneToTen()
        {
            Console.WriteLine("1 2 3 4 5 6 7 8 9 10 ");
        }

        /// <summary>
        /// Prints the numbers from m to n
        /// </summary>
        /// <param name="m">m</param>
        /// <param name="n">n</param>
        public void PrintMToN(int m, int n)
        {
            String sequence = "";
            while (m <= n) {
                sequence = sequence + m + " ";
                m += 1;
            }
            Console.WriteLine(sequence);

        }

        /// <summary>
        /// Returns the tenth even number, with 2 as the first even number
        /// </summary>
        /// <returns>tenth even number</returns>
        public int GetTenthEvenNumber()
        {
            // delete code below; only included so we could compile
            int tenthEven = 0;
            int count = 0;
            while (count < 10) {
                count += 1;
                tenthEven += 2;
            }
            return tenthEven;
        }

        /// <summary>
        /// Returns the nth even number, with 2 as the first even number
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>nth even number</returns>
        public int GetNthEvenNumber(int n)
        {
            // delete code below; only included so we could compile
            int nthEven = 0;
            int count = 0;
            while (count < n) {
                count += 1;
                nthEven += 2;
            }
            return nthEven;
        }

        #endregion
    }
}