using System;
namespace OvaryActing
{
    public class Laundry
    {
        public void laundry(string userinput)
        {
            Console.WriteLine("Oh no! Your clothes are in the laundry :(");
            Console.WriteLine("I guess it’s time for a trivia question about menstruation!!");
            Console.WriteLine("Dont worry! It’s a simple true or false question.");
            Console.WriteLine("Type “T” if you think the statement is correct, otherwise type “F”.");
            Console.WriteLine();
            Console.WriteLine("Are you ready? Press Enter to start");
            Console.ReadLine();
            Console.Clear();
            //random number
            int n = new Random().Next(1, 6);
            if (n == 1)
            {
                Console.WriteLine("T or F: An average of 6-8 teaspoons of blood is released during a period.");
                Console.WriteLine("〚T〛");
                Console.WriteLine("〚F〛");
                Console.WriteLine();
                string input = Console.ReadLine();
                if (input == "T")
                {
                    Console.WriteLine("That’s correct, nice one!");

                }
                else
                {
                    Console.WriteLine("That’s incorrect :(");
                    Console.WriteLine("The correct answer is True.");
                }
                Console.WriteLine("If ever you have or notice irregular periods or other symptoms that may be concerning, we suggest seeing a doctor.");
                Console.WriteLine();
                Console.WriteLine("Are you ready to proceed? Press Enter to continue");
                Console.ReadLine();
                Console.Clear();

            }
            else if (n == 2)
            {
                Console.WriteLine("T or F: You can get pregnant during your period.");
                Console.WriteLine("〚T〛");
                Console.WriteLine("〚F〛");
                Console.WriteLine();
                string input = Console.ReadLine();
                if (input == "T")
                {
                    Console.WriteLine("That’s correct, nice one!");

                }
                else
                {
                    Console.WriteLine("That’s incorrect :(");
                    Console.WriteLine("The correct answer is True.");
                }
                Console.WriteLine("Because you can get pregnant during your period, always practice safe sex by using contraceptives to prevent unwanted pregnancies.");
                Console.WriteLine();
                Console.WriteLine("Are you ready to proceed? Press Enter to continue");
                Console.ReadLine();
                Console.Clear();

            }
            else if (n == 3)
            {
                Console.WriteLine("T or F: The third phase of the menstrual cycle is called the menstrual phase.");
                Console.WriteLine("〚T〛");
                Console.WriteLine("〚F〛");
                Console.WriteLine();
                string input = Console.ReadLine();
                if (input == "F")
                {
                    Console.WriteLine("That’s correct, nice one!");

                }
                else
                {
                    Console.WriteLine("That’s incorrect :(");
                    Console.WriteLine("The correct answer is False.");
                }
                Console.WriteLine("The third phase of the menstrual cycle is called the Ovulation phase. The menstrual phase is the first phase of the cycle.");
                Console.WriteLine();
                Console.WriteLine("Are you ready to proceed? Press Enter to continue");
                Console.ReadLine();
                Console.Clear();
            }
            else if (n == 4)
            {
                Console.WriteLine("T or F: Breastfeeding women usually do not menstruate.");
                Console.WriteLine("〚T〛");
                Console.WriteLine("〚F〛");
                Console.WriteLine();
                string input = Console.ReadLine();
                if (input == "T")
                {
                    Console.WriteLine("That’s correct, nice one!");

                }
                else
                {
                    Console.WriteLine("That’s incorrect :(");
                    Console.WriteLine("The correct answer is True.");
                }
                Console.WriteLine("Breastfeeding is known to delay your period because the prolactin in the milk prevents menstruation.");
                Console.WriteLine();
                Console.WriteLine("Are you ready to proceed? Press Enter to continue");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("T or F: Lighter period flow in women can be caused by taking birth control pills.");
                Console.WriteLine("〚T〛");
                Console.WriteLine("〚F〛");
                Console.WriteLine();
                string input = Console.ReadLine();
                if (input == "T")
                {
                    Console.WriteLine("That’s correct, nice one!");

                }
                else
                {
                    Console.WriteLine("That’s incorrect :(");
                    Console.WriteLine("The correct answer is True.");
                }
                Console.WriteLine("The hormonal dosages in birth control pills are low, which causes a reduction in blood flow since it does the uterus does not build up a thick lining.");
                Console.WriteLine();
                Console.WriteLine("Are you ready to proceed? Press Enter to continue");
                Console.ReadLine();
                Console.Clear();
            }
            Compress minigame3 = new Compress();
            minigame3.compress("start");
        }
    }
}
