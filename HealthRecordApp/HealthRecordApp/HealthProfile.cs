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



		private const int UnknownValue = -1;

		#region Methods

		public int CalculateAge()
		{
			return UnknownValue;
		}

		public int CalculateMaxHeartRate()
		{
			return UnknownValue;
		}

		public decimal CalculateBMI()
		{
			return UnknownValue;
		}

		public void DisplayPatientProfile()
		{
		}

		#endregion
	}
}
