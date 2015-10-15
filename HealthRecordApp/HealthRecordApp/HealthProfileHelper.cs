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
                DateTime db = new DateTime();
                if (DateTime.TryParse(enteredDOB, out db))
                {
                    patientDOB = db;
                    return true;
                }
                else
                {
                    return false;
                }                
            }
		}

		public static bool ValidateHeight(string heightInString, ref int patientHeight)
		{
            int h = 0;
            if (int.TryParse(heightInString, out h))
                
            {
                if (h > 0)
                    patientHeight = h;
                return true;
            }
            else
            {
                return false;
            }
		}

		public static bool ValidateWeight(string weightInString, ref int patientWeight)
		{
            int w = 0;
            if (int.TryParse(weightInString,out w))
            {
                    patientWeight = w;
                    return true;  
            }
            else
            {
                return false;
            }
        }
	}
}
