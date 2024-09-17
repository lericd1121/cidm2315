namespace Homework2;
class Program
{
    static void Main(string[] args)
    {
        // Code for Q1
        Console.Write("Enter a grade (A, B, C, D, F): ");
        string grade = Console.ReadLine().ToUpper();

        switch (grade)
        {
            case "A":
                Console.WriteLine("GPA: 4");
                break;
            case "B":
                Console.WriteLine("GPA: 3");
                break;
            case "C":
                Console.WriteLine("GPA: 2");
                break;
            case "D":
                Console.WriteLine("GPA: 1");
                break;
            case "F":
                Console.WriteLine("GPA: 0");
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                break;
        }

        // Code for Q2
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int num3 = Convert.ToInt16(Console.ReadLine());

        int smallest;

        if (num1 < num2 && num1 < num3)
        {
            smallest = num1;
        }
        else if (num2 < num1 && num2 < num3)
        {
            smallest = num2;
        }
        else
        {
            smallest = num3;
        }

        Console.WriteLine("The smallest number is: " + smallest);

        // Code for Bonus question
        Console.Write("Enter a year to check if it's a leap year: ");
        int year = Convert.ToInt16(Console.ReadLine());

        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine(year + " is a leap year.");
                }
                else
                {
                    Console.WriteLine(year + " is not a leap year.");
                }
            }
            else
            {
                Console.WriteLine(year + " is a leap year.");
            }
        }
        else
        {
            Console.WriteLine(year + " is not a leap year.");
        }
    }
}


