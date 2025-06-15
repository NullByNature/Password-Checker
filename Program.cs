
namespace Password_Checker
{
    class Program
    {
        static void Main()
        {
            Program program = new Program();
            Console.WriteLine("Enter your password to check it");
            string password = Console.ReadLine();
            // Make sure password is not blank 
            while (string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Password can not be left blank");
                password = Console.ReadLine();
            }
            program.PasswordCheck(password);
        }

        void PasswordCheck(string password)
        {
            string SC = "!@#$%^&*()-_=+[{]}|;:',<.>/?";
            // If password does not have a capital letter 
            if (!password.Any(char.IsUpper))
            {
                Console.WriteLine("Your password is missing a capitalized letter making it weaker!");
            }
            if (!password.Any(ch => SC.Contains(ch)))
            {
                Console.WriteLine("Password must include at least one special character.");
            }
            if (!password.Any(char.IsDigit))
            {
                Console.WriteLine("Your password does not contain any numbers which makes it weaker, try adding some numbers like 123");
            }
            if (password.Length <= 12)
            {
                Console.WriteLine("Your password is under or equal to 12 characters making it weaker, try making it longer to protect yourself from hackers");
            }
            if (password.Any(char.IsUpper) && password.Contains(SC) && password.Any(char.IsDigit) && password.Length >= 12)
            {
                Console.WriteLine("Your password is very strong and contains everything needed to make hacking it hard");
            } 

        }
    }
}