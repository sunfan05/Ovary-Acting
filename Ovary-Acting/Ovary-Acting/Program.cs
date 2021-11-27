using System;

namespace OvaryActing
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //starting page
            //add ascii art & "loading . . ."
            //"Press enter to continue"


            //start of game
            int DayNumber = 0;
            while (DayNumber < 5)
            {
                DayNumber += 1;
                Console.WriteLine("[Day " + DayNumber + " of Period]");
                Console.WriteLine();

                //START selecting the right pad minigame
                SelectPad minigame1 = new SelectPad();
                minigame1.selectpad();


                //laundry minigame --->> PROBLEM: repeats questions


                //START hot or cold compress minigame

                if (DayNumber != 5)
                {
                    endmsg1();
                }
                else if (DayNumber == 5)
                {
                    endmsg2();
                    break;
                }
            }
        }
        public static void endmsg1()
        {
            Console.WriteLine("Congrats, you got through the day! See u tomorrow :))");
            Console.WriteLine("Press Enter to continue to the next day");
            Console.ReadLine();
            Console.Clear();

        }
        public static void endmsg2()
        {
            Console.WriteLine("Thanks for playing, see you next month! (or in approximately 28 days)");
            Console.WriteLine("Press Enter to end the game");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
