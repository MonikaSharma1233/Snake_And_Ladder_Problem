using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_Ladder_Problem
{
    public class Snake_Ladder
    {
        int die_counter = 0;
        bool turn;

        public void Snake_and_Ladder()
        {
            // int start = 0;
            int position = 0;
            int position1 = 0;
            int position2 = 0;
            int end = 100;


            Console.WriteLine("WELCOME TO SNAKE AND LADDER.");
            Console.WriteLine("Enter Player 1 Name: ");
            String player1 = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Enter Player 2 Name: ");
            String player2 = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Hello " + player1 + " and " + player2 + " Welcome to Snake and Ladder.");

            Console.WriteLine("Player 1 on: " + position1 + " Position.");
            Console.WriteLine("Player 2 on: " + position2 + " Position.");
            int i = 1;
            while (position1 != end || position2 != end)
            {

                if (position1 >= 100)
                {
                    Console.WriteLine("Player one " + player1 + " wins the game.");
                    break;
                }
                else if (position2 >= 100)
                {
                    Console.WriteLine("Player two " + player2 + " wins the game.");
                    break;
                }
                else
                {
                    if (turn == true)
                    {
                        Console.WriteLine("Player 1 turn.");
                        int position1_holder = Moving();
                        position1 = position1 + position1_holder;
                        Console.WriteLine("Player 1 is on: " + position1);
                        if (position1 == 0)
                        {
                            Console.WriteLine("Player 1 is starts from zero.");
                        }
                        turn = false;
                    }
                    else
                    {
                        Console.WriteLine("Player 2 turn.");
                        int position2_holder = Moving();
                        position2 = position2 + position2_holder;
                        Console.WriteLine("Player 2 is on: " + position2);
                        if (position2 == 0)
                        {
                            Console.WriteLine("Player 2 is starts from zero.");
                        }
                        turn = true;
                    }
                    i++;
                }
            }
            // Console.WriteLine(player1 + " Congratulation you win the Game.");
            // Console.WriteLine("You reach at 100.");
            //Console.WriteLine("Number of dice counts are: " + die_counter);
        }
        public int die_no()


        {

            Random random = new Random();
            int die = random.Next(1, 6);
            Console.WriteLine("Die generated: " + die);
            die_counter++;

            return die;
        }
        public int Moving()
        {
            int start = 0;
            int position = 0;

            int die = die_no();
            Random random1 = new Random();
            int check_option = random1.Next(3);
            if (check_option == 0)
            {
                Console.WriteLine("PLAYER GOT LADDER.");
                position = position + die;
                Console.WriteLine("The player is on: " + position);
                Console.WriteLine("PLAYER GOT SECOND CHANCE.");
                die = die_no();
                position = position + die;

                //Console.WriteLine(position);
            }
            else if (check_option == 1)
            {
                Console.WriteLine("PLAYER GOT SNAKE");
                position = position - die;
                if (position <= 0)
                {
                    position = 0;
                }
                //Console.WriteLine(position);
            }
            else
            {
                position = position + 0;
                Console.WriteLine("NO Play Stay in same position.");
            }
            return position;
        }

    }
}

