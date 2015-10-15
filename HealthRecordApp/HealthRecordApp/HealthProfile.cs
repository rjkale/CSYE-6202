using System;

namespace HealthRecordApp
{
	public enum Gender
	{
		Unspecified,
		Male,
		Female
	}


	public class HealthProfile
	{
        private string firstName;
        private string lastName;
        private Gender gender;
        private DateTime dob;
        private int height;
        private int weight;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }

        public int HeightInInches
        {
            get { return height; }
            set { height = value; }
        }

        public int WeightInPounds
        {
            get { return weight; }
            set { weight = value; }
        }

        public HealthProfile(string firstName, string lastName, Gender gender, DateTime dOB, int patientWeight, int patientHeight)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.weight = patientWeight;
            this.height = patientHeight;
            this.gender = gender;
            this.dob = dOB;
        }
        public HealthProfile()
        { }



        private const int UnknownValue = -1;

		#region Methods

		public int CalculateAge()
		{
            int age = 0;
            DateTime TODAY = DateTime.Today;
            return age = TODAY.Year - DOB.Year;
            //return UnknownValue;
		}

		public int CalculateMaxHeartRate()
		{
            int rate = 0;
            return rate = 220 - CalculateAge();
			//return UnknownValue;
		}

		public decimal CalculateBMI()
		{
            decimal bmi = 0;
            return bmi = Math.Round((WeightInPounds * 703.00m) / (HeightInInches * HeightInInches),2);
			//return UnknownValue;
		}

		public void DisplayPatientProfile()
		{
            Console.WriteLine("\nDisplaying Patient Profile: \n---------------------------- \n----------------------------");
            Console.WriteLine("First Name: "+FirstName);
            Console.WriteLine("Last Name: "+LastName);
            Console.WriteLine("Gender: "+gender);
            Console.WriteLine("Date of Birth: "+ dob);
            Console.WriteLine("Height: "+HeightInInches+ " inches");
            Console.WriteLine("Weight: "+WeightInPounds+ " pounds");
            Console.WriteLine("Age: "+CalculateAge());
            Console.WriteLine("Max Heart Rate: " +CalculateMaxHeartRate());
            Console.WriteLine("BMI: "+CalculateBMI());
        }

		#endregion
	}
}
