namespace Integration_Constructor_and_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p0 =
                new Person(age:500)
                {
                    ID="SXYW45",
                    FullName = "Ali Vahidi"
                };

            p0.ShowInfo();

            Person p1 =
                new Person(age:35)
                {
                    ID="CWQST68",
                    FullName = "Kamran Lavasani",
                };

            p1.ShowInfo();










            System.Console.WriteLine();
            System.Console.ReadLine();
        }
    }
}
