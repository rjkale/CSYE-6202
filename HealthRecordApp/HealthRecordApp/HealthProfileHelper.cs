using System;
using System.Text.RegularExpressions;

namespace HealthRecordApp
{
	public class HealthProfileHelper
	{
		public static bool ValidateFirstName(string firstName)
		{
            if (Regex.IsMatch(firstName, "^[a-z]+$", RegexOptions.IgnoreCase))
            {
                return true;
            }

			return false;
		}

		public static bool ValidateLastName(string lastName)
		{
            if (Regex.IsMatch(lastName, "^[a-z]+$", RegexOptions.IgnoreCase))
            {
                return true;
            }
            return false;
		}

		public static bool ValidateGender(string enteredGender, ref Gender patientGender)
		{
            switch (enteredGender)
            {
                case ("M"):
                case ("m"):
                    {
                        return true;
                    }

                case ("F"):
                case ("f"):
                    {
                        return true;
                    }
            }

            return false;
		}

        public static bool ValidateDateOfBirth(string enteredDOB, ref DateTime patientDOB)
        {
            {
                patientDOB = DateTime.Parse(enteredDOB);
                return true;
            }
		}

		public static bool ValidateHeight(string heightInString, ref int patientHeight)
		{
            
            int pheight = int.Parse(heightInString);
            if (pheight >0)
            {
                patientHeight = pheight;
                return true;
            }

            else
            {
                return false;
                    }
		}

		public static bool ValidateWeight(string weightInString, ref int patientWeight)
		{
            int weight = int.Parse(weightInString);
            if (weight > 0)
            {
                patientWeight = weight;
                return true;
            }
            else
            {
                return false;
            }
		}
	}
}
