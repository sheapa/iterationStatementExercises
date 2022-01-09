using System;

namespace IterationExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Exercise 1 of 5

            var number = 100;
            var divByThree = 0;

            for (var a = 0; a <= number; a++)
            {
                if (a % 3 == 0)
                {
                    divByThree++;
                }
            }
            Console.WriteLine(divByThree);

            // Exercise 2 of 5

            var newGame = true;
            var total = 0;
            while (true)
            {
                Console.Write("Please enter a number: ");
                var newNumber = Console.ReadLine();
                if (newNumber == "ok")
                {
                    Console.Write("The total of Numbers entered: " + total);
                    break;
                }
                else
                {
                    var numeric = Int32.Parse(newNumber);
                    if (newGame == true)
                    {
                        total = numeric;
                        newGame = false;
                    }
                    else
                    {
                        total = numeric + total;
                    }
                }
            }

            //Exercise 3 of 5

            int b, num, fact;
            Console.Write("Please enter a number: ");
            num = Int32.Parse(Console.ReadLine());
            fact = num;
            for (b = num - 1; b >= 1; b--)
            {
                fact = fact * b;
            }
            Console.WriteLine("Factorial of " + num + " is " + fact);

            // Exercise 4 of 5

            var random = new Random();
            var secretNum = random.Next(1, 10);
            Console.WriteLine(secretNum);
            var c = 1;
            while (c <= 3)
            {
                Console.WriteLine("Try to guess the secret number: ");
                var answer = Int32.Parse(Console.ReadLine());

                if (secretNum == answer)
                {
                    Console.WriteLine("Congrats! You guessed the secret number!");
                    break;
                }
                if (c == 3)
                {
                    Console.WriteLine("You're out of guesses. Game over.");
                }
                c++;
                continue;

            }

            // Exercise 5 of 5

            Console.WriteLine("Please enter 10 numbers. When finished enter 'ok'. ");
            var d = 0;
            var numOfEntries = 10;
            var list = new int[numOfEntries];
            var highNum = 0;
            while (d <= numOfEntries)
            {
                Console.Write("Enter a number: ");
                list[d] = Int32.Parse(Console.ReadLine());
                d++;
                if (d == 10)
                    break;

            }
            foreach (var entry in list)
            {
                if (highNum < entry)
                {
                    highNum = entry;
                }
            }
            Console.WriteLine("The highest number in your array is: " + highNum);
               
            
        }
    }
}