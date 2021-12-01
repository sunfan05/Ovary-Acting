using System;
namespace OvaryActing
{
    public class AdditionalMinigame
    {
        public void additionalminigame()
        {
            //introduction
            Console.WriteLine("Well.. you weren't able to get 100 points to get through the day (｡•́︿•̀｡)");
            Console.WriteLine("You now have to go through a series of questions to get your HP to 100 points.");
            Console.WriteLine("Each correct question is worth 25 points so answer as many as you can correctly!");
            Console.WriteLine("But take note, if you get one answer wrong, you will lose 5 points.");
            Console.WriteLine("Some questions may have more than one answer. You may just type in any one of these answers");
            Console.WriteLine("Also, some questions may be repeated.");
            Console.WriteLine("Are you ready to start? Press Enter to begin!!");
            Console.ReadLine();
            Console.Clear();

            while (HP.result < 100)
            {
                int n = new Random().Next(1, 11);
                string Answer;
                //questions 
                if (n == 1)
                {
                    Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    Console.WriteLine("What do u do when u see a girl with blood on her clothes?");
                    Console.WriteLine("〚A〛Laugh");
                    Console.WriteLine("〚B〛Call the cops");
                    Console.WriteLine("〚C〛Tell her and give her something to cover up");
                    Console.WriteLine("〚D〛Run away. It's gross");
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    Answer = Console.ReadLine();
                    Console.WriteLine();
                    if (Answer == "C" || Answer == "c")
                    {
                        Console.WriteLine("Nice one! You're correct o(>ω<)o");
                        Console.WriteLine("Have +25HP!");
                        HP.result += 25;
                        Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    }
                    else
                    {
                        Console.WriteLine("Your answer is wrong (;ω;). The correct answer is〚C〛");
                        Console.WriteLine("You lost -25HP!");
                        HP.result -= 25;
                        Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    }
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                else if (n == 2)
                {
                    Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    Console.WriteLine("Your friend asks to borrow money to buy pads. What do you do?");
                    Console.WriteLine("〚A〛Tell her to just hold it in until she gets home. ");
                    Console.WriteLine("〚B〛Give her a tissue. It’s the same thing, right?");
                    Console.WriteLine("〚C〛Lend her the money. She needs the pads urgently. ");
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    Answer = Console.ReadLine();
                    Console.WriteLine();
                    if (Answer == "C" || Answer == "c")
                    {
                        Console.WriteLine("Nice one! You're correct o(>ω<)o");
                        Console.WriteLine("Have +25HP!");
                        HP.result += 25;
                        Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    }
                    else
                    {
                        Console.WriteLine("Your answer is wrong (;ω;). The correct answer is〚C〛");
                        Console.WriteLine("You lost -25HP!");
                        HP.result -= 25;
                        Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    }
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                else if (n == 3)
                {
                    Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    Console.WriteLine("You’ve just gotten your first period while at school, and you don’t have a pad! Who do you tell? ");
                    Console.WriteLine("〚A〛Your best friend, maybe you can figure this out together.");
                    Console.WriteLine("〚B〛Your teacher, maybe they can help you find pads.");
                    Console.WriteLine("〚C〛Call your mom, maybe she can bring you home.");
                    Console.WriteLine("〚D〛Go to the school clinic and explain.");
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    Answer = Console.ReadLine();
                    Console.WriteLine();
                    if ((Answer == "B" || Answer == "b") || (Answer == "C" || Answer == "c") || (Answer == "D" || Answer == "d"))
                    {
                        Console.WriteLine("Nice one! You're correct o(>ω<)o. The correct answers are〚B〛,〚C〛,〚D〛");
                        Console.WriteLine("Have +25HP!");
                        HP.result += 25;
                        Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    }
                    else
                    {
                        Console.WriteLine("Your answer is wrong (;ω;). The correct answers are〚B〛,〚C〛,〚D〛");
                        Console.WriteLine("You lost -25HP!");
                        HP.result -= 25;
                        Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    }
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                else if (n == 4)
                {
                    Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    Console.WriteLine("Which of these establishments probably sells pads?");
                    Console.WriteLine("〚A〛Pan de Manila. More like pad de Manila");
                    Console.WriteLine("〚B〛Mercury Drugstore. They also sell diapers.");
                    Console.WriteLine("〚C〛GNC. They sell health stuff.");
                    Console.WriteLine("〚D〛Jollibee. The bee is red.");
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    Answer = Console.ReadLine();
                    Console.WriteLine();
                    if (Answer == "B" || Answer == "b")
                    {
                        Console.WriteLine("Nice one! You're correct ヽ(・∀・)ﾉ");
                        Console.WriteLine("Have +25HP!");
                        HP.result += 25;
                        Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    }
                    else
                    {
                        Console.WriteLine("Your answer is wrong (╯︵╰,). The correct answer is〚B〛");
                        Console.WriteLine("You lost -25HP!");
                        HP.result -= 25;
                        Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    }
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                else if (n == 5)
                {
                    Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    Console.WriteLine("You leaked blood on your bedsheets. What do you do?");
                    Console.WriteLine("〚A〛Launder the whole bedsheet");
                    Console.WriteLine("〚B〛Rub the stain with hydrogen peroxide");
                    Console.WriteLine("〚C〛Rub the stain with dishwashing liquid");
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    Answer = Console.ReadLine();
                    Console.WriteLine();
                    if ((Answer == "A" || Answer == "a") || (Answer == "B" || Answer == "b") || (Answer == "C" || Answer == "c"))
                    {
                        Console.WriteLine("Nice one! You're correct ヽ(・∀・)ﾉ. Actually, all the choices above are correct!");
                        Console.WriteLine("Have +25HP!");
                        HP.result += 25;
                        Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    }
                    else
                    {
                        Console.WriteLine("Your answer is wrong (╯︵╰,). The correct answers are〚A〛,〚B〛,〚C〛");
                        Console.WriteLine("You lost -25HP!");
                        HP.result -= 25;
                        Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    }
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                else if (n == 6)
                {
                    Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    Console.WriteLine("Who should learn about periods?");
                    Console.WriteLine("〚A〛Only people who are female, since only they have to deal with it.");
                    Console.WriteLine("〚B〛Everyone. We need to look out for each other.");
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    Answer = Console.ReadLine();
                    Console.WriteLine();
                    if (Answer == "B" || Answer == "b")
                    {
                        Console.WriteLine("Nice one! You're correct (✯◡✯)");
                        Console.WriteLine("Have +25HP!");
                        HP.result += 25;
                        Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    }
                    else
                    {
                        Console.WriteLine("Your answer is wrong (╯︵╰,). The correct answer is〚B〛");
                        Console.WriteLine("You lost -5HP!");
                        HP.result -= 5;
                        Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    }
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                else if (n == 7)
                {
                    Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    Console.WriteLine("Who can experience menstruation?");
                    Console.WriteLine("〚A〛Only women");
                    Console.WriteLine("〚B〛All women");
                    Console.WriteLine("〚C〛Anyone");
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    Answer = Console.ReadLine();
                    Console.WriteLine();
                    if (Answer == "C" || Answer == "c")
                    {
                        Console.WriteLine("Nice one! You're correct (✯◡✯)");
                        Console.WriteLine("Have +25HP!");
                        HP.result += 25;
                        Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    }
                    else
                    {
                        Console.WriteLine("Your answer is wrong (｡•́︿•̀｡). The correct answer is〚C〛");
                        Console.WriteLine("You lost -25HP!");
                        HP.result -= 25;
                        Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    }
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                else if (n == 8)
                {
                    Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    Console.WriteLine("How long should you use the same pad?");
                    Console.WriteLine("〚A〛One pad will last the whole cycle");
                    Console.WriteLine("〚B〛Change it every hour");
                    Console.WriteLine("〚C〛Change it every four hours");
                    Console.WriteLine("〚D〛Change it every day");
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    Answer = Console.ReadLine();
                    Console.WriteLine();
                    if ((Answer == "C" || Answer == "c") || (Answer == "B" || Answer == "b"))
                    {
                        Console.WriteLine("Nice one! You're correct (✯◡✯). The correct answers are〚B〛,〚C〛");
                        Console.WriteLine("Have +25HP!");
                        HP.result += 25;
                        Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    }
                    else
                    {
                        Console.WriteLine("Your answer is wrong (｡•́︿•̀｡). The correct answers are〚B〛,〚C〛");
                        Console.WriteLine("You lost -25HP!");
                        HP.result -= 25;
                        Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    }
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                else if (n == 9)
                {
                    Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    Console.WriteLine("Do all Philippine schools provide free pads to students?");
                    Console.WriteLine("〚A〛Yes, because some students may not have access to it otherwise");
                    Console.WriteLine("〚B〛Yes, because it is as necessary as toilet paper");
                    Console.WriteLine("〚C〛Yes, but only private schools");
                    Console.WriteLine("〚D〛No");
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    Answer = Console.ReadLine();
                    Console.WriteLine();
                    if (Answer == "D" || Answer == "d")
                    {
                        Console.WriteLine("Nice one! You're correct <(￣︶￣)>.");
                        Console.WriteLine("Have +25HP!");
                        HP.result += 25;
                        Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    }
                    else
                    {
                        Console.WriteLine("Your answer is wrong (｡•́︿•̀｡). The correct answer is〚D〛");
                        Console.WriteLine("You lost -25HP!");
                        HP.result -= 25;
                        Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    }
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                else if (n == 10)
                {
                    Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    Console.WriteLine(" What are the wings on pads for?");
                    Console.WriteLine("〚A〛So the period will fly away");
                    Console.WriteLine("〚B〛To make the pad lighter");
                    Console.WriteLine("〚C〛To secure the pad in place");
                    Console.WriteLine("〚D〛For aesthetic purposes");
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    Answer = Console.ReadLine();
                    Console.WriteLine();
                    if (Answer == "C" || Answer == "c")
                    {
                        Console.WriteLine("Nice one! You're correct <(￣︶￣)>.");
                        Console.WriteLine("Have +25HP!");
                        HP.result += 25;
                        Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    }
                    else
                    {
                        Console.WriteLine("Your answer is wrong (｡•́︿•̀｡). The correct answer is〚C〛");
                        Console.WriteLine("You lost -25HP!");
                        HP.result -= 25;
                        Console.WriteLine("❮Current Health: " + HP.result + "❯");
                    }
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
            }
        }
    }
}
