using System;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q1: Find the largest of two integers");
            int largestOfTwo = Q1_method();
            Console.WriteLine($"Largest number is: {largestOfTwo}\n");

            Console.WriteLine("Q2: Find the largest of four integers");
            int largestOfFour = Q2_method();
            Console.WriteLine($"Largest number is: {largestOfFour}\n");

            Console.WriteLine("Q3: Account creation process");
            createAccount();
        }

        static int Q1_method()
        {
            int a, b;
            while (true)
            {
                Console.Write("Enter the first integer: ");
                if (int.TryParse(Console.ReadLine(), out a)) break;
                else Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            while (true)
            {
                Console.Write("Enter the second integer: ");
                if (int.TryParse(Console.ReadLine(), out b)) break;
                else Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            return (a > b) ? a : b;
        }

        static int Q2_method()
        {
            int a, b, c, d;

            a = GetValidInteger("Enter the first integer: ");
            b = GetValidInteger("Enter the second integer: ");
            c = GetValidInteger("Enter the third integer: ");
            d = GetValidInteger("Enter the fourth integer: ");

            int max1 = Q1_method_helper(a, b);
            int max2 = Q1_method_helper(c, d);

            return Q1_method_helper(max1, max2);
        }

        static int Q1_method_helper(int a, int b)
        {
            return (a > b) ? a : b;
        }

        static int GetValidInteger(string prompt)
        {
            int value;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out value)) break;
                else Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            return value;
        }

        static bool checkAge(int birth_year)
        {
            int current_year = DateTime.Now.Year;
            int age = current_year - birth_year;

            return (age >= 18);
        }

        static void createAccount()
        {
            Console.Write("Enter username: ");
            string? username = Console.ReadLine();
            if (string.IsNullOrEmpty(username))
            {
                Console.WriteLine("Username cannot be null or empty.");
                return;
            }

            string? password;
            while (true)
            {
                Console.Write("Enter password: ");
                password = Console.ReadLine();
                if (!string.IsNullOrEmpty(password)) break;
                else Console.WriteLine("Password cannot be empty. Please enter a valid password.");
            }

            string? confirmPassword;
            while (true)
            {
                Console.Write("Re-enter password: ");
                confirmPassword = Console.ReadLine();
                if (!string.IsNullOrEmpty(confirmPassword)) break;
                else Console.WriteLine("Confirmation password cannot be empty. Please enter it again.");
            }

            int birthYear = GetValidInteger("Enter your birth year: ");

            if (checkAge(birthYear))
            {
                if (password == confirmPassword)
                {
                    Console.WriteLine($"Account for {username} is created successfully");
                }
                else
                {
                    Console.WriteLine("Passwords do not match. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Could not create an account. Age is less than 18.");
            }
        }
    }
}
