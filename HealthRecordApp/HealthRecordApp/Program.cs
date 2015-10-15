using System;
using HealthRecordApp;
namespace HealthRecordApp
{
    class Program
	{
        static HealthProfile hp = new HealthProfile();
		static void Main(string[] args)
		{
            Console.WriteLine("Please enter patient's first name: ");
            string fName = Convert.ToString(Console.ReadLine());
            if (HealthProfileHelper.ValidateFirstName(fName))
            {
                hp.FirstName = fName;

                Console.WriteLine("Please enter patient's last name: ");
                string lName = Convert.ToString(Console.ReadLine());
                if (HealthProfileHelper.ValidateLastName(lName))
                {
                    hp.LastName = lName;

                    Console.WriteLine("Please enter patient's gender: ");
                    string gender = Convert.ToString(Console.ReadLine());
                    Gender Gen = new Gender();

                    if (HealthProfileHelper.ValidateGender(gender, ref Gen))
                    {
                        hp.Gender = Gen;

                        Console.WriteLine("Please enter patient's date of birth");
                        DateTime DOB = Convert.ToDateTime(Console.ReadLine());
                        DateTime dateTimeInput = new DateTime();

                        if (HealthProfileHelper.ValidateDateOfBirth(Convert.ToString(DOB), ref dateTimeInput))
                        {
                            hp.DoB = dateTimeInput;

                            Console.WriteLine("Please enter patient's height: ");

                            int height = 0;
                            string inputheight = Convert.ToString(Console.ReadLine());

                            if (HealthProfileHelper.ValidateHeight(inputheight,ref height))
                            {
                                hp.Height = height;

                                Console.WriteLine("Please enter patient's weight: ");
                                string inputWeight = Convert.ToString(Console.ReadLine());
                                int weight = 0;

                                if (HealthProfileHelper.ValidateWeight(inputWeight, ref weight))
                                {
                                    hp.Weight = weight;
                                }

                            }
                            else
                            {
                                Console.WriteLine("Invalid height");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Invalid Date");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid gender");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid last name: ");
                }
            }
            else
            {
                Console.WriteLine("Invalid first name:");
            }
            Console.ReadLine();               
        }
	}
}
