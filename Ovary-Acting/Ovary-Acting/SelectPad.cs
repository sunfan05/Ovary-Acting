using System;
namespace OvaryActing
{
    public class SelectPad
    {
        public void selectpad()
        {
            int RandomNumber = new Random().Next(1, 3);
            string A = "〚A〛Day pad";
            string B = "〚B〛Night pad";
            string Answer;
            if (RandomNumber == 1)
            {
                Console.WriteLine("It is daytime! Select the right pad");
                Console.WriteLine(A);
                Console.WriteLine(B);

                Console.Write("Answer: ");
                Answer = Console.ReadLine();
                Console.WriteLine();

                if (Answer == "A") {
                    Console.WriteLine("Congrats, you're right!");
                    Console.WriteLine("You may now proceed to the next minigame");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Compress minigame3 = new Compress();
                    minigame3.compress("start");
                }
                else
                {
                    Console.WriteLine("Oh no! The answer is supposed to be" + A + ".");
                    Console.WriteLine("It’s now time for you to do the laundry.");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    Console.Clear();

                    Laundry minigame2 = new Laundry();
                    minigame2.laundry("start"); 
                }

            }
            else if (RandomNumber == 2)
            {
                Console.WriteLine("It is nighttime! Select the right pad");
                Console.WriteLine(A);
                Console.WriteLine(B);

                Console.Write("Answer: ");
                Answer = Console.ReadLine();
                Console.WriteLine();
                if (Answer == "B")
                {
                    Console.WriteLine("Congrats, you're right!");
                    Console.WriteLine("You may now proceed to the next minigame");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Compress minigame3 = new Compress();
                    minigame3.compress("start");
                }
                else
                {
                    Console.WriteLine("Oh no! The answer is supposed to be" + B + ".");
                    Console.WriteLine("It’s now time for you to do the laundry.");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    Console.Clear();

                    Laundry minigame2 = new Laundry();
                    minigame2.laundry("start");
                }
            }
            return;
        }
    }
}
