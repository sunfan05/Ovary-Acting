using System;
namespace OvaryActing
{
    public class Compress
    {
        public void compress(string userinput)
        {
            int RandomNumber = new Random().Next(1, 3);
            string Answer;

            Console.WriteLine("Oh no! You have cramps :(.");
            Console.WriteLine("Type the letter of the right compress!");

            if (RandomNumber == 1)
            {
                string A = "〚A〛Hot compress";
                string B = "〚B〛Cold compress";
                Console.WriteLine(A);
                Console.WriteLine(B);

                Answer = Console.ReadLine();
                if (Answer == "A")
                {
                    Console.WriteLine("Congrats! You're right");
                    Console.WriteLine("Now, your cramps are going away!");
                    Console.WriteLine();
                    Console.WriteLine("Are you ready to proceed? Press Enter to continue");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.WriteLine("oh no, the correct answer is actually " + A + " :(.");
                    Console.WriteLine("Better luck next time! [P.S. Good luck with the cramps :((]");
                    Console.WriteLine();
                    Console.WriteLine("Are you ready to proceed? Press Enter to continue");
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

                Answer = Console.ReadLine();
                if (Answer == "B")
                {
                    Console.WriteLine("Congrats! You're right");
                    Console.WriteLine("Now, your cramps are going away!");
                    Console.WriteLine();
                    Console.WriteLine("Are you ready to proceed? Press Enter to continue");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.WriteLine("oh no, the correct answer is actually " + B + " :(.");
                    Console.WriteLine("Better luck next time! [P.S. Good luck with the cramps :((]");
                    Console.WriteLine();
                    Console.WriteLine("Are you ready to proceed? Press Enter to continue");
                    Console.ReadLine();
                    return;

                }
            }
        }
    }
}
