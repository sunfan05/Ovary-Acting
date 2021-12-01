using System;
namespace OvaryActing
{
    public class SelectPad
    {
        public void selectpad()
        {
            Console.WriteLine("❮Current Health: " + HP.result + "❯");
            int RandomNumber = new Random().Next(1, 3);
            string A = "〚A〛Day pad";
            string B = "〚B〛Night pad";
            string Answer;
            Console.WriteLine();

            if (RandomNumber == 1)
            {
                Console.WriteLine("It is daytime! Select the right pad");
                Console.WriteLine(A);
                Console.WriteLine(B);

                Console.Write("Answer: ");
                Answer = Console.ReadLine();
                Console.WriteLine();
                Console.Clear();

                if (Answer == "A")
                {
                    Console.WriteLine("❮Previous Health: " + HP.result + "❯");
                    HP.result += 50;
                    Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    Console.WriteLine();
                    Console.WriteLine("Congrats, you're right! Have +50HP");
                    Console.WriteLine();
                    Console.WriteLine("But..");
                    Console.WriteLine("(Press Enter to see the rest of the text ┐(︶▽︶)┌)");
                    Console.ReadLine();
                    Console.Clear();
                    Compress minigame3 = new Compress();
                    minigame3.compress("start");
                }
                else
                {
                    Console.WriteLine("❮Previous Health: " + HP.result + "❯");
                    HP.result -= 50;
                    Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    Console.WriteLine();
                    Console.WriteLine("Oh no! The answer is supposed to be" + A + ".");
                    Console.WriteLine("You lost -50HP :(");
                    Console.WriteLine();
                    Console.WriteLine("Pssst... Guess what?");
                    Console.WriteLine("(Press Enter if you're curious ᕕ( ᐛ )ᕗ)");
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
                Console.Clear();
                if (Answer == "B")
                {
                    Console.WriteLine("❮Previous Health: " + HP.result + "❯");
                    HP.result += 50;
                    Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    Console.WriteLine();
                    Console.WriteLine("Congrats, you're right! Have +50HP");
                    Console.WriteLine();
                    Console.WriteLine("But..");
                    Console.WriteLine("(Press Enter to see the rest of the text ┐(︶▽︶)┌)");
                    Console.ReadLine();
                    Console.Clear();
                    Compress minigame3 = new Compress();
                    minigame3.compress("start");
                }
                else
                {
                    Console.WriteLine("❮Previous Health: " + HP.result + "❯");
                    HP.result -= 50;
                    Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    Console.WriteLine();
                    Console.WriteLine("Oh no! The answer is supposed to be" + B + ".");
                    Console.WriteLine("You lost -50HP :(");
                    Console.WriteLine();
                    Console.WriteLine("Pssst... Guess what?");
                    Console.WriteLine("(Press Enter if you're curious ᕕ( ᐛ )ᕗ)");
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
