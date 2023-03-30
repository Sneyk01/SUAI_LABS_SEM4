using System;

namespace lab1_console_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string num = "";

            while (num == "")
            {
                Console.WriteLine("Введите натуральное число");
                num = Console.ReadLine();

                if (num != "")
                {
                    foreach (char s in num)
                    {
                        if (!char.IsNumber(s))
                        {
                            Console.WriteLine("Некорректное число");
                            num = "";
                            break;
                        }
                    }
                }
            }

            

            string k = "";

            while (k == "")
            {
                Console.WriteLine("Введите число К");
                k = Console.ReadLine();

                if (k != "")
                {
                    if (!(k[0] == '-' || char.IsNumber(k[0])))
                    {
                        k = "";
                        break;
                    }
                        

                    for (int i = 1; i < k.Length; i++)
                    {
                        if (!char.IsNumber(k[i]))
                        {
                            Console.WriteLine("Некорректное число");
                            k = "";
                            break;
                        }
                    }
                }
            }

            

            int count = 1;
            int num1 = Int32.Parse(num);
            int num2 = Int32.Parse(k);

            for (int i = (num2 + 1); i < num1; i++)
            {
                if (i != 0)
                    if ((num1 % i) == 0)
                        count++;
            }

            Console.WriteLine($"Число делителей числа {num}, больших чем {k}: {count.ToString()}");
            Console.ReadLine();
        }
    }
}
