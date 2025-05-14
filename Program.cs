using System;
// Method to check if a number is prime
bool IsPrime(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;

    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
            return false;
    }
    return true;
}

// Main method
Console.Write("Enter a number N to find all prime numbers up to N: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int n) && n > 0)
{
    Console.WriteLine($"\nPrime numbers up to {n}:");
    for (int i = 2; i <= n; i++)
    {
        if (IsPrime(i))
            Console.Write(i + " ");
    }
    Console.WriteLine(); // for new line
}
else
{
    Console.WriteLine("Please enter a valid positive integer.");
}
