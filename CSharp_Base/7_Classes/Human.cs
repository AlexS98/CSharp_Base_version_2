namespace _7_Classes
{
    partial class Human
    {
        string gender;
        string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName { get; set; }

        public Human()
        {
            gender = "Unknown";
            FirstName = "Default";
            LastName = "Name";
        }

        public Human(string gender, string firstName, string lastName)
        {
            this.gender = gender;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
