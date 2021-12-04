using System;

namespace OvaryActing
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //starting or loading screen
            LoadingScreen load = new LoadingScreen();
            load.loadingscreen();

            //instructions
            Instructions start = new Instructions();
            start.instructions();

            //start of game
            while (DayNumber.day < 5)
            {
                DayNumber.day += 1;
                Console.WriteLine("[Day " + DayNumber.day + " of Period]");
                Console.WriteLine();

                //start of minigames
                SelectPad minigame1 = new SelectPad();
                minigame1.selectpad();

                //different ending outcomes
                Console.Clear();
                if (DayNumber.day != 5)
                {
                    if (HP.result == 100)
                    {
                        //note: move to next day
                        endmsg1();
                        HP.result -= 100; //resets the HP
                    }
                    else if (HP.result < 100)
                    {
                        //note: continue to additional minigames to have hp.result == 100
                        AdditionalMinigame begin = new AdditionalMinigame();
                        begin.additionalminigame();
                        endmsg1();
                        HP.result -= 100; //resets the HP
                    }
                }
                else if (DayNumber.day == 5)
                {
                    if (HP.result == 100)
                    {
                        //note: end program
                        endmsg2();
                        break;
                    }
                    else if (HP.result < 100)
                    {
                        //note: continue to additional minigames to have hp.result == 100
                        AdditionalMinigame begin = new AdditionalMinigame();
                        begin.additionalminigame();
                        endmsg2();
                        break;
                    }
                }
            }
        }

        public static void endmsg1()
        {
            Console.WriteLine("[Day " + DayNumber.day + " of Period]");
            Console.WriteLine();
            Console.WriteLine("❮Total Health: " + HP.result + "❯");
            Console.WriteLine();
            Console.WriteLine("Congrats, you got through the day ヽ(°〇°)ﾉ! See u tomorrow!!");
            Console.WriteLine("Press Enter to continue to the next day");
            Console.ReadLine();
            Console.Clear();

        }

        public static void endmsg2()
        {
            Console.WriteLine("[Day " + DayNumber.day + " of Period]");
            Console.WriteLine();
            Console.WriteLine("❮Total Health: " + HP.result + "❯");
            Console.WriteLine();
            Console.WriteLine("Thanks for playing, see you next month! (or in approximately 28 days) ᕕ( ᐛ )ᕗ");
            Console.WriteLine("Press Enter to end the game");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
