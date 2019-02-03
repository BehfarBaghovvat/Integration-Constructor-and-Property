
namespace Integration_Constructor_and_Property
{
    class Person
    {    
        
        public Person(int age)
        {
            Age = age;
        }

        /// <summary>
        /// Field and Property Age.
        /// </summary>

        private int age;

        private int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value>0 && value<151)
                {
                    age = value;
                }                
            }
        }

        /// <summary>
        /// Field and Property Full Name.
        /// </summary>

        private string fullname;

        public string FullName
        {
            get
            {
                return fullname;
            }
            set
            {
                if (value==string.Empty)
                {
                    fullname = value;
                }

                if (value==" ")
                {
                    fullname=value.Trim();

                }
                fullname = value;
            }
        }

        /// <summary>
        /// Field and Property ID.
        /// </summary>

        private string id;

        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        /// <summary>
        /// Method Show Information.
        /// </summary>

        public void ShowInfo()
        {
            string message =
                $"My name is { FullName } and { Age } years old. Id code is {ID} ";

            System.Console.WriteLine(message);

            System.Console.WriteLine();
        }
    }    
}
