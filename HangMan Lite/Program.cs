using System.Globalization;

namespace HangMan_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {             
            string word, displayWord = "", guess;
            int incorrectGuesses = 0, correctGuesses = 0, guessIndex = 0, guessIndexInitial;
            bool done = false;
            List<string> guesses = new List<string>();

            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine("Please have a second player enter the secret word, or enter '0' to use a random word");
            word = Console.ReadLine();
            word = word.ToUpper();
            if (word == "0")
            {
                // randomly generate word
            }
            
            DrawStageOne();

            Console.WriteLine();
            Console.WriteLine("WORD:");
            for (int i = 0; i < word.Length; i++)
            {
                displayWord = displayWord + "_";
            }
            Console.WriteLine(displayWord);
            while (!done)
            {
                Console.WriteLine("Please enter a letter to guess:");
                guess = Console.ReadLine();
                guess = guess.ToUpper();
                if (word.Contains(guess) && !guesses.Contains(guess) && guess != "") 
                {
                    Console.WriteLine("CORRECT! :)");
                    guessIndex = word.IndexOf(guess);
                    guessIndexInitial = guessIndex;
                    Console.WriteLine();
                    for (int i = 0; i < word.Length - (guessIndexInitial - 1); i++)
                    {
                        // for loop goes through each character in the string, and if the character is there, the guessIndex is used to remove the char slot and replace it with the guessed character
                        if (guessIndex != -1 && guess != "")
                        {

                            displayWord = displayWord.Remove(guessIndex, 1);
                            displayWord = displayWord.Insert(guessIndex, guess);
                            guessIndex = word.IndexOf(guess, guessIndex + 1);
                        }
                    }
                    Console.WriteLine(displayWord);
                    if (guess != "")
                    {
                        guesses.Add(guess);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Guesses: ");
                    for (int i = 0; i < guesses.Count; i++)
                    {
                        Console.Write($"{guesses[i]}, ");
                    }
                    Console.WriteLine();
                    if (!displayWord.Contains("_"))
                    {
                        done = true;
                    }
                }
                else if (guesses.Contains(guess))
                {
                    Console.WriteLine("You've already guessed that letter");
                }
                else
                {
                    Console.WriteLine("INCORRECT! :(");
                    incorrectGuesses++;
                    guesses.Add(guess);
                    Console.WriteLine("Guesses: ");
                    for (int i = 0; i < guesses.Count; i++)
                    {
                        Console.Write($"{guesses[i]}, ");
                    }
                    Console.WriteLine();
                    Console.WriteLine($"{7 - incorrectGuesses} lives left!");
                    if (incorrectGuesses == 1)
                    {
                        DrawStageTwo();
                    }
                    else if (incorrectGuesses == 2)
                    {
                        DrawStageThree();
                    }
                    else if (incorrectGuesses == 3)
                    {
                        DrawStageFour();
                    }
                    else if (incorrectGuesses == 4)
                    {
                        DrawStageFive();
                    }
                    else if (incorrectGuesses == 5)
                    {
                        DrawStageSix();
                    }
                    else if (incorrectGuesses == 6)
                    {
                        DrawStageSeven();
                    }
                    else if (incorrectGuesses == 7)
                    {
                        Console.WriteLine("YOU DIED");
                        Console.WriteLine("PRESS ENTER TO CLOSE THE APPLICATION");
                        Console.ReadLine();
                        System.Environment.Exit(0);
                    }
                   
                }
            }
            Console.WriteLine("YOU WIN!");
            Console.WriteLine("PRESS ENTER TO CLOSE THE APPLICATION");
            Console.ReadLine();
            System.Environment.Exit(0);
        }


        public static void DrawStageOne()
        {
            Console.WriteLine(" +---+");
            Console.WriteLine(" |   |");
            Console.WriteLine("     |"); 
            Console.WriteLine("     |");
            Console.WriteLine("     |");
            Console.WriteLine("     |");
            Console.WriteLine("======");
        }
        public static void DrawStageTwo()
        {
            Console.WriteLine(" +---+");
            Console.WriteLine(" |   |");
            Console.WriteLine(" O   |");
            Console.WriteLine("     |");
            Console.WriteLine("     |");
            Console.WriteLine("     |");
            Console.WriteLine("======");
        }
        public static void DrawStageThree()
        {
            Console.WriteLine(@" +---+");
            Console.WriteLine(@" |   |");
            Console.WriteLine(@" O   |");
            Console.WriteLine(@" |   |");
            Console.WriteLine(@"     |");
            Console.WriteLine(@"     |");
            Console.WriteLine(@"======");
        }
        public static void DrawStageFour()
        {
            Console.WriteLine(@" +---+");
            Console.WriteLine(@" |   |");
            Console.WriteLine(@" O   |");
            Console.WriteLine(@"/|   |");
            Console.WriteLine(@"     |");
            Console.WriteLine(@"     |");
            Console.WriteLine(@"======");
        }
        public static void DrawStageFive()
        {
            Console.WriteLine(@" +---+");
            Console.WriteLine(@" |   |");
            Console.WriteLine(@" O   |");
            Console.WriteLine(@"/|\  |");
            Console.WriteLine(@"     |");
            Console.WriteLine(@"     |");
            Console.WriteLine(@"======");
        }
        public static void DrawStageSix()
        {
            Console.WriteLine(@" +---+");
            Console.WriteLine(@" |   |");
            Console.WriteLine(@" O   |");
            Console.WriteLine(@"/|\  |");
            Console.WriteLine(@"/    |");
            Console.WriteLine(@"     |");
            Console.WriteLine(@"======");
        }
        public static void DrawStageSeven()
        {
            Console.WriteLine(@" +---+");
            Console.WriteLine(@" |   |");
            Console.WriteLine(@" O   |");
            Console.WriteLine(@"/|\  |");
            Console.WriteLine(@"/ \  |");
            Console.WriteLine(@"     |");
            Console.WriteLine(@"======");
        }
        public static void DrawVictory()
        {
            Console.WriteLine(@" +---+");
            Console.WriteLine(@" |   |");
            Console.WriteLine(@"     |");
            Console.WriteLine(@"\O/  |");
            Console.WriteLine(@" |   |");
            Console.WriteLine(@"/ \  |");
            Console.WriteLine(@"======");
        }
    }
}