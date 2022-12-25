using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_Ladder_Problem
{
    public class Snake_Ladder
    {

        public static void Snake_and_Ladder()
        {
            int start = 0;
            int position = 0;
            int end = 100;
            //UC1
            Console.WriteLine("WELCOME TO SNAKE AND LADDER.");
            Console.WriteLine("Enter Player 1 Name: ");
            String player1 = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Hello " + player1 + " Welcome to Snake and Ladder.");
            //UC2
            Console.WriteLine("Player 1 on: " + position + " Position.");
            int i = 1;
            while (position != end)
            {

                if (position >= 100)
                {
                    Console.WriteLine("Congratulation Game Win.");
                    break;
                }
                else
                {
                    Random random = new Random();
                    int die = random.Next(1, 6);
                    Console.WriteLine("Die generated: " + die);

                    Random random1 = new Random();
                    int check_option = random1.Next(3);
                    Console.WriteLine("Player choose the option: " + check_option);
                    if (check_option == 0)
                    {

                        Console.WriteLine("PLAYER GOT LADDER.");
                        position = position + die;
                        Console.WriteLine(position);
                    }
                    else if (check_option == 1)
                    {
                        Console.WriteLine("PLAYER GOT SNAKE");
                        position = position - die;

                        if (position <= 0)
                        {
                            position = 0;

                            Console.WriteLine("Game start from 0.");

                        }
                        Console.WriteLine(position);
                    }
                    else
                    {
                        position = position + 0;
                    }
                    i++;
                }
            }
        }
    }
}
