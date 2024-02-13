using System;

class Numbercheck
{
    static void Main()
    {
        // prompting user to enter a whole number
        Console.Write("Please enter a whole number: ");
        int number = Convert.ToInt32(Console.ReadLine());

         // checking if the number is positive
        if (number > 0)
        {
            if (number % 2 == 0)
            {
                // displaying the output after checking the number
                Console.WriteLine("The number is positive and even");
            }
            else
            {
                Console.WriteLine("The number is positive and odd");
            }
            // checking if the number is negative
        }
        else if (number < 0)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is negative and even");
            }
            else
            {
                Console.WriteLine("The number is negative and odd");
            }
        }
        // If the number is neither positive nor negative, it must be zero
        else
        {
            Console.WriteLine("The number is zero (and it is even)");
        }

        Console.ReadLine();
    }
}
