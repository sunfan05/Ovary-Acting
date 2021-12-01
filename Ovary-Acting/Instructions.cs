using System;
namespace OvaryActing
{
    public class Instructions
    {
        public void instructions()
        {
            //introduction
            Console.WriteLine("Welcome (´• ω •`)ﾉ");
            Console.WriteLine("As we all know, periods or menstruation are natural body processes but how much do you know about them? O-o");
            Console.WriteLine("This short game consists of several minigames to test your knowledge on periods regardless of your gender.");
            Console.WriteLine("So if you're ready, press Enter to proceed to the game instructions and guidelines");
            Console.ReadLine();
            Console.Clear();

            //instructions
            Console.WriteLine("This game will take you through 5 days of experiencing what it's like to have periods.");
            Console.WriteLine("You start off with 0 health points (HP = 0) and the maximum number of points you can get in a day is 100 points.");
            Console.WriteLine("  * If you pass a minigame, you are given 50 points.");
            Console.WriteLine("  * If you fail a minigame, 50 points will be deducted from your total HP.");
            Console.WriteLine("You will be needing 100 points to get through the day or else you will have to play additional minigames to reach 100 points.");
            Console.WriteLine("If ever you want to stop the game, feel free to exit the program anytime!");
            Console.WriteLine();
            Console.WriteLine("Well, what are you waiting for?? HAVE FUN!!:)");
            Console.WriteLine("Press Enter to start the game!");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
