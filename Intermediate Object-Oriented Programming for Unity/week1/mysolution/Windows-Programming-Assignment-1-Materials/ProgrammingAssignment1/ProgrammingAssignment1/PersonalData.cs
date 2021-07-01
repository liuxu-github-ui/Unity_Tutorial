using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    /// <summary>
    /// A class holding personal data for a person
    /// </summary>
    public class PersonalData
    {
        #region Fields

        // declare your fields here
        string firstName;
        string middleName;
        string lastName;
        string streetAddress;
        string city;
        string state;
        string postalCode;
        string country;
        string phoneNumber;

        string line;
        StreamReader input;
        
        #endregion

        #region Properties

        /// <summary>
        /// Gets the person's first name
        /// </summary>
        public string FirstName
        {
            get 
            {
                // delete code below and replace with correct code
                return firstName;
            }
        }

        /// <summary>
        /// Gets the person's middle name
        /// </summary>
        public string MiddleName
        {
            get
            {
                // delete code below and replace with correct code
                return middleName;
            }
        }

        /// <summary>
        /// Gets the person's last name
        /// </summary>
        public string LastName
        {
            get
            {
                // delete code below and replace with correct code
                return lastName;
            }
        }

        /// <summary>
        /// Gets the person's street address
        /// </summary>
        public string StreetAddress
        {
            get
            {
                // delete code below and replace with correct code
                return streetAddress;
            }
        }

        /// <summary>
        /// Gets the person's city or town
        /// </summary>
        public string City
        {
            get
            {
                // delete code below and replace with correct code
                return city;
            }
        }

        /// <summary>
        /// Gets the person's state or province
        /// </summary>
        public string State
        {
            get
            {
                // delete code below and replace with correct code
                return state;
            }
        }

        /// <summary>
        /// Gets the person's postal code
        /// </summary>
        public string PostalCode
        {
            get
            {
                // delete code below and replace with correct code
                return postalCode;
            }
        }

        /// <summary>
        /// Gets the person's country
        /// </summary>
        public string Country
        {
            get
            {
                // delete code below and replace with correct code
                return country;
            }
        }

        /// <summary>
        /// Gets the person's phone number (digits only, no 
        /// parentheses, spaces, or dashes)
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                // delete code below and replace with correct code
                return phoneNumber;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// Reads personal data from a file. If the file
        /// read fails, the object contains an empty string for all
        /// the personal data
        /// </summary>
        /// <param name="fileName">name of file holding personal data</param>
        public PersonalData(string fileName)
        {
            // your code can assume we know the order in which the
            // values appear in the string; it's the same order as
            // they're listed for the properties above. We could do 
            // something more complicated with the names and values, 
            // but that's not necessary here

            // IMPORTANT: The mono compiler the automated grader uses
            // does NOT support the string Split method. You have to 
            // use the IndexOf method to find comma locations and the
            // Substring method to chop off the front of the string
            // after you extract each value to extract and save the
            // personal data

            try
            {
                input = File.OpenText(fileName);
                line = input.ReadLine();

               
            }
            catch (Exception e)
            {

            }
            finally
            {
                if (input != null)
                {

                    int firstNamePosition= line.IndexOf(",", 1);
                    firstName = line.Substring(0, firstNamePosition);

                    int middleNamePosition = line.IndexOf(",", firstNamePosition+1);
                    middleName = line.Substring(firstNamePosition+1, middleNamePosition- firstNamePosition-1);

                    int lastNamePosition = line.IndexOf(",", middleNamePosition+1);
                    lastName = line.Substring(middleNamePosition + 1, lastNamePosition - middleNamePosition - 1);

                    int streetAddressPosition = line.IndexOf(",", lastNamePosition+1);
                    streetAddress = line.Substring(lastNamePosition + 1, streetAddressPosition - lastNamePosition-1);

                    int cityPosition = line.IndexOf(",", streetAddressPosition + 1);
                    city = line.Substring(streetAddressPosition + 1, cityPosition - streetAddressPosition - 1);

                    int statePosition = line.IndexOf(",", cityPosition + 1);
                    state = line.Substring(cityPosition + 1, statePosition - cityPosition - 1);

                    int postalCodePositon = line.IndexOf(",", statePosition + 1);
                    postalCode = line.Substring(statePosition + 1, postalCodePositon - statePosition - 1);

                    int countryPosition = line.IndexOf(",", postalCodePositon + 1);
                    country = line.Substring(postalCodePositon + 1, countryPosition - postalCodePositon - 1);

                    //int phonePosition = line.IndexOf(",", countryPosition + 1);
                    //phoneNumber = line.Substring(countryPosition + 1, phonePosition - countryPosition - 1);

                    input.Close();


                }
                

            }



            


        }

        #endregion
    }
}
