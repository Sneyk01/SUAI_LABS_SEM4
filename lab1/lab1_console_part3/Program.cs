using System;

namespace lab1_console_part3
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "a^2 * b = c \r\n";

            for (int a = 1; a < 21; a++)
            {
                if (a * a > 20)
                    break;

                for (int b = 1; b < 21; b++)
                {
                    if (a * a * b > 20)
                        break;

                    if (a * a * b > 0 && a * a * b < 21)
                        answer += $"{a}^2 * {b} = {a * a * b} \r\n";
                }
            }

            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
