using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int userNumber = -1;
        int largestNum = -99999999;
        int smallestNum = 99999999;
        int sum = 0;
        int count = 0;
        List<int>numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
          
            if(userNumber != 0)
            {
                numbers.Add(userNumber);
                sum += userNumber;
                count += 1;
            }

            if(userNumber > largestNum)
            {
                largestNum = userNumber;
            }

            if(userNumber > 0 && userNumber < smallestNum)
            {
                smallestNum = userNumber;
            }

        } while(userNumber != 0);

        float average = ((float)sum) / count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");
        Console.WriteLine($"The smallest positive number is: {smallestNum}");

        // Sort the numbers in the list
        numbers.Sort();

        Console.WriteLine("The sorted list is:");
        // Loop to display the sorted list
        foreach(int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}