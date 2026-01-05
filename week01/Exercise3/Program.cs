using System;

class Program
{
    static void Main(string[] args)
    {
        string userGuess = "";
        string keepPlaying = "yes";
        int guess = 0;
        int count = 0;
        int magicNumber = 0;

        Random randomGenerator = new Random();

        Console.WriteLine("Number Guessing Game!");
        Console.WriteLine();
        
        while(keepPlaying == "yes" || keepPlaying == "Yes")
        {
            magicNumber = randomGenerator.Next(1, 101);

            do
            {
                Console.Write("What is your guess? ");
                count += 1;         
                userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);

                if(guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }

                else if(guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

            } while (guess != magicNumber);

            Console.WriteLine();
            Console.WriteLine("You guessed it!");
           
            if(count == 1)
            {
                Console.WriteLine($"It took you {count} guess.");
            }

            else
            {
                Console.WriteLine($"It took you {count} guesses.");
            }
            count = 0;
            
            Console.WriteLine();
            Console.Write("Do you want to play again? ");
            keepPlaying = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        Console.WriteLine("Thank you for playing. Goodbye.");
    }
}