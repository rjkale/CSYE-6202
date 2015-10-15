using System;
using HealthRecordApp;
namespace HealthRecordApp
{
    class Program
    {
        static HealthProfile hp = new HealthProfile();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter patient's first name: ");
                string fName = Convert.ToString(Console.ReadLine());
                if (HealthProfileHelper.ValidateFirstName(fName))
                {
                    hp.FirstName = fName;
                    LastName:
                    Console.WriteLine("Please enter patient's last name: ");
                    string lName = Convert.ToString(Console.ReadLine());

                    if (HealthProfileHelper.ValidateLastName(lName))
                    {
                        hp.LastName = lName;
                        Gender:

                        Console.WriteLine("Please enter patient's gender: ");
                        string gender = Convert.ToString(Console.ReadLine());
                        Gender Gen = new Gender();

                        if (HealthProfileHelper.ValidateGender(gender, ref Gen))
                        {
                            hp.Gender = Gen;
                            DOB:

                            Console.WriteLine("Please enter patient's date of birth");
                            string DOB = Convert.ToString(Console.ReadLine());
                            DateTime dateTimeInput = new DateTime();

                            if (HealthProfileHelper.ValidateDateOfBirth(DOB, ref dateTimeInput))
                            {
                                hp.DOB = dateTimeInput;
                                Height:

                                Console.WriteLine("Please enter patient's height: ");

                                int height = 0;
                                string inputheight = Convert.ToString(Console.ReadLine());

                                if (HealthProfileHelper.ValidateHeight(inputheight, ref height))
                                {
                                    hp.HeightInInches = height;
                                    Weight:

                                    Console.WriteLine("Please enter patient's weight: ");
                                    string inputWeight = Convert.ToString(Console.ReadLine());
                                    int weight = 0;

                                    if (HealthProfileHelper.ValidateWeight(inputWeight, ref weight))
                                    {
                                        hp.WeightInPounds = weight;

                                        hp.DisplayPatientProfile();
                                        //HealthProfile hp1 = new HealthProfile(fName, lName, Gen, dateTimeInput, weight, height);
                                        //hp1.DisplayPatientProfile();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Weight");
                                        goto Weight;
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Invalid Height");
                                    goto Height;
                                }

                            }
                            else
                            {
                                Console.WriteLine("Invalid Date");
                                goto DOB;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Gender");
                            goto Gender;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Last name: ");
                        goto LastName;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid First name:");
                }
                Console.ReadLine();
            }
        }
    }
}
