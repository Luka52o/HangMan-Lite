namespace HangMan_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {             
            string word, displayWord = "", guess;
            int incorrectGuesses = 0, correctGuesses = 0, guessIndex = 0;
            bool done = false;

            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine("Please have a second player enter the secret word, or enter '0' to use a random word");
            word = Console.ReadLine();
            if (word == "0")
            {
                // randomly generate word
            }
            
            DrawStageOne();

            Console.WriteLine();
            for (int i = 0; i < word.Length; i++)
            {
                displayWord = displayWord + "_";
            }
            Console.WriteLine(displayWord);
            while (!done)
            {
                Console.WriteLine("Please enter a letter to guess:");
                guess = Console.ReadLine();
                if (word.Contains(guess.ToUpper()) && guess.ToUpper() != "")
                {
                    Console.WriteLine("CORRECT! :)");
                    correctGuesses++;
                    Console.WriteLine();
                    for (int i = 0; i < word.Length; i++)
                    {
                        guessIndex = word.IndexOf(guess.ToUpper(), guessIndex + 1);
                        displayWord = displayWord.Remove(guessIndex, 1);
                        displayWord = displayWord.Insert(guessIndex, guess.ToUpper());
                    }
                    
                    Console.WriteLine(displayWord);
                }
                else
                {
                    Console.WriteLine("INCORRECT! :(");
                    incorrectGuesses++;
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
                        done = true;
                    }
                   
                }
            }
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