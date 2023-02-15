using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1A2B_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Random number = new Random();
                string[] answer = new string[4];
                for (int i = 0; i < 4; i++)
                {
                    answer[i] = number.Next(1, 10).ToString();
                    for (int j = 0; j < i; j++)
                    {
                        if (answer[i] == answer[j])
                        {
                            j = 0;
                            answer[i] = number.Next(1, 10).ToString();
                        }
                    }

                }
                string game = answer[0] + answer[1] + answer[2] + answer[3];
                string put = "";
                Console.WriteLine("歡迎來到1A2B猜數字遊戲~");
                do
                {
                    int a = 0, b = 0;
                    put = Console.ReadLine();
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (put[i] == game[j])
                            {
                                if (i == j)
                                {
                                    a++;
                                }
                                else b++;
                            }
                        }

                    }
                    Console.WriteLine($"結果是{a}A{b}B");
                } while (put != game);

                Console.WriteLine("你答對了");
                Console.WriteLine("繼續玩請按y");
            } while (Console.ReadLine() == "y");
        }
    }
}
