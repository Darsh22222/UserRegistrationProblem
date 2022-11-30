namespace UserRegistrationProblemStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Validation validation = new Validation();
            Console.WriteLine("Enter The First Name: ");
            string firstName = Console.ReadLine();
            validation.FirstName(firstName);
        }
    }
}