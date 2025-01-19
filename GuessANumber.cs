namespace GuessANumber
{
    internal class GuessANumber
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            while (playAgain)    
            {
               
                Random randomNumber = new Random();
                int computerNumber = randomNumber.Next(1, 21);
                string input;
                int guesses = 3;

                int guessedNumber = 0;
                Console.WriteLine($"Guess a number! (1-20)");

                while (guesses > 0)
                {
                    input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input))
                    {

                        Console.WriteLine("Please enter a number!");
                    }
                    bool isNumber = int.TryParse(input, out guessedNumber);

                    if (isNumber)
                    {
                      bool isGuessed =  IsTheNumberGuessed(guessedNumber, computerNumber);

                        if (isGuessed)
                        {
                            Console.WriteLine("Do you want to play again? Enter [Y] for Yes or [N] for No!");
                            input = Console.ReadLine();

                         playAgain = PlayAgainMethod(input);
                            if (playAgain)
                            {
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                return;
                            }

                        }


                    }
                    else
                    {
                        Console.WriteLine("Try to enter a number!");
                    }
                    guesses--;
                    if (guesses == 0)
                    {
                        Console.WriteLine("Do you want to play again? Enter [Y] for Yes or [N] for No!");
                        input = Console.ReadLine();

                        playAgain = PlayAgainMethod(input);
                        if (playAgain)
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            return;
                        }
                    }
                    
                }



            }

























        }

         static bool PlayAgainMethod(string input)
        {
            if (string.IsNullOrEmpty(input))
            {

                Console.WriteLine("Invalid input. Please enter [Y] for Yes or [N] for No!");
                return false;
            }
            else
            {
                if (input.ToLower() == "y")
                {
                   return true;
                 
                }
                else
                {
                    Console.WriteLine("Have a nice day!");
                    return false;
                }
            }
        }

        static bool IsTheNumberGuessed(int guessedNumber, int computerNumber)
        {
            if (guessedNumber > computerNumber) 
            {
                Console.WriteLine("Too high!, Try again.");
                return false;
            }
            else if (guessedNumber < computerNumber)
            {
                Console.WriteLine("Too low!, Try again.");
                return false;
            }
            else { Console.WriteLine("You guessed right!"); return true; }








           
        }
    }
}










