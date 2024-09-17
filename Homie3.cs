namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code for Q1 - Check if N is prime
            Console.WriteLine("Enter a number (Q1 - Prime check):");
            int N1 = int.Parse(Console.ReadLine());
            if (IsPrime(N1))
            {
                Console.WriteLine($"{N1} is prime.");
            }
            else
            {
                Console.WriteLine($"{N1} is non-prime.");
            }

            // Code for Q2 - Print square pattern of N x N
            Console.WriteLine("Enter a number (Q2 - Square pattern):");
            int N2 = int.Parse(Console.ReadLine());
            PrintSquarePattern(N2);

            // Code for Q3 - Print a specific pattern based on row/column comparisons
            Console.WriteLine("Enter a number (Q3 - Pattern with comparisons):");
            int N3 = int.Parse(Console.ReadLine());
            PrintComparisonPattern(N3);

            // Code for Bonus question - Print a square pattern with diagonal
            Console.WriteLine("Enter a number (Bonus - Pattern with diagonal):");
            int NBonus = int.Parse(Console.ReadLine());
            PrintBonusPattern(NBonus);
        }

        // Method to check if a number is prime (Q1)
        static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        // Method to print N x N square pattern (Q2)
        static void PrintSquarePattern(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        // Method to print the pattern with row/column comparisons (Q3)
        static void PrintComparisonPattern(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j || i + j == n - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }

        // Method to print the Bonus pattern with a diagonal and border (Bonus)
        static void PrintBonusPattern(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == n - 1 || j == 0 || j == n - 1 || i == j || i + j == n - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}


