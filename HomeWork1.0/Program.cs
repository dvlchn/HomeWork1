using System;

namespace HomeWork1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-st task
            //Stars();


            //2-nd task
            //Numbers();

            //3-rd task
            //Console.WriteLine (Age(new DateTime(1992, 5, 5)));




        }

        public static void Stars()
        {
            for (int i = 0; i < 13; i += 2)
            {
                for (int j = 0; j < (13 - 1) / 2 - (i / 2); j++) Console.Write(' ');
                for (int j = 0; j < i + 1; j++) Console.Write('*');
                Console.WriteLine();
            }
        }

        public static void Numbers()
        {
            string num;

            do
            {
                Console.WriteLine("About which language do you want to know information? 1 - English, 2 - Spanish, 3 - Ukrainian ");
                num = Console.ReadLine();
            } while (num != "1" && num != "2" && num != "3");

            int languageValue = int.Parse(num);

            Console.WriteLine($"With 2,500 to 3,000 words, you can understand 90% of everyday {(Language)languageValue} conversations,");
            Console.WriteLine($"{(Language)languageValue} newspaper and magazine articles, and {(Language)languageValue} used in the workplace.");
            Console.WriteLine($"So it is essential to learn the right {(Language)languageValue} vocabulary words.");
        }

        public static int Age(DateTime birthDate)
        {
            DateTime n = DateTime.Now;
            int age = n.Year - birthDate.Year;

            if (n.Month < birthDate.Month || (n.Month == birthDate.Month && n.Day < birthDate.Day))
                age--;

            return age;
        }
    }



    public enum Language : byte
    {
        English = 1,
        Spanish = 2,
        Ukrainian = 3
    }
}

