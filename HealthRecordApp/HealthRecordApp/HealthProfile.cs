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
        private DateTime DOB;
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

        public DateTime DoB
        {
            get { return DOB; }
            set { DOB = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Weight
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
            this.DOB = dOB;
        }
        public HealthProfile()
        { }



        private const int UnknownValue = -1;

		#region Methods

		public int CalculateAge()
		{
            int age = 0;
            DateTime TODAY = DateTime.Today;
            return age = TODAY.Year - DoB.Year;
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
            return bmi = (Weight *703) / (Height * Height);
			//return UnknownValue;
		}

		public void DisplayPatientProfile()
		{
            Console.WriteLine("\nDisplaying Patient Profile: \n---------------------------- \n----------------------------");
            Console.WriteLine("First Name: "+FirstName);
            Console.WriteLine("Last Name: "+LastName);
            Console.WriteLine("Gender: "+gender);
            Console.WriteLine("Date of Birth: "+ DOB);
            Console.WriteLine("Height: "+Height+ " inches");
            Console.WriteLine("Weight: "+Weight+ " pounds");
            Console.WriteLine("Age: "+CalculateAge());
            Console.WriteLine("Max Heart Rate: " +CalculateMaxHeartRate());
            Console.WriteLine("BMI: "+CalculateBMI());
        }

		#endregion
	}
}
