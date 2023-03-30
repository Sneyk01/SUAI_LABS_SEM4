using System;

namespace Lab1_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            while (name == "")
            {
                Console.WriteLine("Введите имя:");
                name = Console.ReadLine();

                if (name != "")
                {
                    foreach(char s in name)
                        if (!char.IsLetter(s))
                        {
                            Console.WriteLine("Некоректные данные");
                            name = "";
                            break;
                        }
                }
            }

            string lastname = "";
            while (lastname == "")
            {
                Console.WriteLine("Введите фамилию:");
                lastname = Console.ReadLine();
                if (lastname != "")
                {
                    foreach (char s in lastname)
                        if (!char.IsLetter(s))
                        {
                            Console.WriteLine("Некоректные данные");
                            lastname = "";
                            break;
                        }
                }
            }

            Console.WriteLine($"Имя: {name}, фамилия: {lastname}\n");

            string answer = "";
            string temp = lastname;
            int len = name.Length;
            if (lastname.Length < len)
            {
                len = lastname.Length;
                temp = name;
            }

            for (int i = 0; i < len; i++)
            {
                answer += (char)((short)name[i] + (short)lastname[i]);
                Console.WriteLine($"Сумма цифровых кодов {i+1}-х букв имени и фамилии: {(short)name[i]} + {(short)lastname[i]} = {(short)answer[i]} ({answer[i]})");
            }

            for (int i = len; i < temp.Length; i++)
                answer += temp[i];

            Console.WriteLine($"\nСумма строк: {answer}");

            Console.ReadKey();
        }
    }
}
