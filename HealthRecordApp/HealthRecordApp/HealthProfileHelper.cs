using System;
using System.Text.RegularExpressions;

namespace HealthRecordApp
{
    public class HealthProfileHelper
    {
        public static bool ValidateFirstName(string firstName)
        {
            if (firstName == null)
            {
                return false;
            }
            else if (Regex.IsMatch(firstName, "^[a-z]+$", RegexOptions.IgnoreCase))
            {
                return true;
            }

            return false;
        }

        public static bool ValidateLastName(string lastName)
        {
            if (lastName == null)
            {
                return false;
            }
            else if (Regex.IsMatch(lastName, "^[a-z]+$", RegexOptions.IgnoreCase))
            {
                return true;
            }
            return false;
        }

        public static bool ValidateGender(string enteredGender, ref Gender patientGender)
        {
            switch (enteredGender.ToLower())
            {
                case ("m"):
                    {
                        patientGender = Gender.Male;
                        return true;
                    }
                case ("f"):
                    {
                        patientGender = Gender.Female;
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
                    
                    if (db < DateTime.Now)
                    {
                        patientDOB = db;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
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
                {
                    patientHeight = h;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;

        }

        public static bool ValidateWeight(string weightInString, ref int patientWeight)
        {
            int w = 0;
            if (int.TryParse(weightInString, out w))
            {
                if (w > 0)
                {
                    patientWeight = w;
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }
    }
}
