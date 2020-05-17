using System;

namespace Lab_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть рядок: ");
            string input = Console.ReadLine();
            string[] textMass;
            textMass = input.Split(' ');
            Console.WriteLine("Кiлькiсть слiв:");
            Console.WriteLine(textMass.Length);
            string[] str = input.Split('.','!', '?');
            int maxlen = 0, index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxlen)
                {
                    maxlen = str[i].Length;
                    index = i;
                }
            }
            Console.Write("Найдовше речення: {0}", str[index]);
            Console.ReadLine();
        }

        }
}