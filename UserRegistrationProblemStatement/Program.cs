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

            Console.WriteLine("Enter The Last Name: ");
            string lastName = Console.ReadLine();
            validation.LastName(lastName);

            Console.WriteLine("Enter The Email: ");
            string email = Console.ReadLine();
            validation.Email(email);

            Console.WriteLine("Enter Mobile Number Start With 91 : ");
            string phone = Console.ReadLine();
            validation.MobileNumber(phone);

            Console.WriteLine("Enter Minimum 8 Character Password: ");
            string password = Console.ReadLine();
            validation.Password(password);

            Console.WriteLine("Enter Password At Least One Upper Case: ");
            string passwordcapital = Console.ReadLine();
            validation.PasswordOneCapital(passwordcapital);

            Console.WriteLine("Enter Password At Least One Numeric: ");
            string passwordnumeric = Console.ReadLine();
            validation.PasswordNum(passwordnumeric);
        }
    }
}