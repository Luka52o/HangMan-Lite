namespace HangMan_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {             
            string word = "COMPUTER", displayWord = "________", guess;
            int incorrectGuesses;
            bool done = false;

            Console.WriteLine("Welcome to Hangman!");
            DrawStageOne();

            Console.WriteLine();
            Console.WriteLine(displayWord);
            while (!done)
            {
                Console.WriteLine("Please enter a letter to guess:");
                guess = Console.ReadLine();
                if (word.Contains(guess.ToUpper()))
                {
                    Console.WriteLine("CORRECT! :)");
                    Console.WriteLine();
                    Console.WriteLine(displayWord.Replace(word.IndexOf(guess.ToUpper()), guess.ToUpper())); // this is not how .Replace() works, it works by (char in string, new char) not by index :(
                }
                else
                {
                    Console.WriteLine("INCORRECT! :(");
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
            Console.WriteLine(@" |  |");
            Console.WriteLine(@"     |");
            Console.WriteLine(@"     |");
            Console.WriteLine(@"======");
        }
        public static void DrawStageFour()
        {
            Console.WriteLine(@" +---+");
            Console.WriteLine(@" |   |");
            Console.WriteLine(@" O   |");
            Console.WriteLine(@"/|  |");
            Console.WriteLine(@"    |");
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