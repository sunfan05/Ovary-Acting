﻿using System;
namespace OvaryActing
{
    public class Compress
    {
        public void compress(string userinput)
        {
            Console.WriteLine("[Day " + DayNumber.day + " of Period]");
            Console.WriteLine();
            int RandomNumber = new Random().Next(1, 3);
            string Answer;
            Console.WriteLine("❮Current Health: " + HP.result + "❯");
            Console.WriteLine();
            Console.WriteLine("But.. oh no! You have cramps (×﹏×)");
            Console.WriteLine("Type the letter of the right compress!");

            if (RandomNumber == 1)
            {
                string A = "〚A〛Hot compress";
                string B = "〚B〛Cold compress";
                Console.WriteLine(A);
                Console.WriteLine(B);

                Console.WriteLine();
                Console.Write("Answer: ");
                Answer = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("[Day " + DayNumber.day + " of Period]");
                Console.WriteLine();
                if (Answer == "A" || Answer == "a")
                {
                    HP.result += 50;
                    Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    Console.WriteLine();
                    Console.WriteLine("Congrats! You're right");
                    Console.WriteLine("Now, your cramps are going away! ＼(≧▽≦)／");
                    Console.WriteLine("Have +50HP!");
                    Console.WriteLine();
                    Console.WriteLine("This was fun right?? Well...");
                    Console.WriteLine("(Press Enter to see the rest of the text ╮(︶▽︶)╭)");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    HP.result -= 50;
                    Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    Console.WriteLine();
                    Console.WriteLine("Oh no, the correct answer is actually " + A + " :(.");
                    Console.WriteLine("Better luck next time! [P.S. Good luck with the cramps (╥_╥)]");
                    Console.WriteLine("Also, you lost -50HP (╥﹏╥)");
                    Console.WriteLine();
                    Console.WriteLine("This was fun right?? Well...");
                    Console.WriteLine("(Press Enter to see the rest of the text ╮(︶▽︶)╭)");
                    Console.ReadLine();
                    return;

                }
            }
            else
            {
                string A = "〚A〛Cold compress";
                string B = "〚B〛Hot compress";
                Console.WriteLine(A);
                Console.WriteLine(B);

                Console.WriteLine();
                Console.Write("Answer: ");
                Answer = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("[Day " + DayNumber.day + " of Period]");
                Console.WriteLine();
                if (Answer == "B" || Answer == "b")
                {
                    HP.result += 50;
                    Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    Console.WriteLine();
                    Console.WriteLine("Congrats! You're right");
                    Console.WriteLine("Now, your cramps are going away! ＼(≧▽≦)／");
                    Console.WriteLine("Have +50HP!");
                    Console.WriteLine();
                    Console.WriteLine("This was fun right?? Well...");
                    Console.WriteLine("(Press Enter to see the rest of the text ╮(︶▽︶)╭)");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    HP.result -= 50;
                    Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    Console.WriteLine();
                    Console.WriteLine("Oh no, the correct answer is actually " + B + " :(.");
                    Console.WriteLine("Better luck next time! [P.S. Good luck with the cramps (╥_╥)]");
                    Console.WriteLine("Also, you lost -50HP (╥﹏╥)");
                    Console.WriteLine();
                    Console.WriteLine("This was fun right?? Well...");
                    Console.WriteLine("(Press Enter to see the rest of the text ╮(︶▽︶)╭)");
                    Console.ReadLine();
                    return;

                }
            }
        }
    }
}
