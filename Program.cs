using System;

namespace UserInputJordanSimmons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, this is Jordan speaking.");
            Console.WriteLine("What is your favorite TV show?");
            Console.WriteLine("(Please type your answer below and then hit enter)");

            string TvShow;

            TvShow = Console.ReadLine();

            Console.WriteLine("Wow! " + TvShow + " is your favorite show? Interesting.");

            Console.WriteLine("And who's your favorite character on that show?");
            Console.WriteLine("(Again, please type your answer below and then hit enter)");

            string TvCharacter;

            TvCharacter = Console.ReadLine();

            Console.WriteLine(TvCharacter + ", huh. Maybe I'll check it out and see if I have a favorite character.");
        }
    }
}
