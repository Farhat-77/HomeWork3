using System;

namespace HomeWork3
{
    class Program
    {
        /*
         1.	Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. 
        Программа должна сосчитать количество введенных пользователем пробелов.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите несколько символов: ");
            char input;
            int spaceCount = 0;
            do
            {
                var symbol = Console.Read();
                if (input == ' ')
                    spaceCount++;
            }
            while (input != '.');

            Console.WriteLine("Количество мест: " + spaceCount);
        }
        /*2.	Ввести с клавиатуры номер трамвайного билета (6-значное число) и про-верить является ли данный билет счастливым 
         (если на билете напечатано шестизначное число, 
         и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым)*/
        static void Main(string[] args)
        {
            int chislo;
            Console.Write("Введите шестизначное число: ");
            chislo = Convert.ToInt32(Console.ReadLine());

            string Str = Convert.ToString(chislo);
            int dl = Str.Length / 6;
            int N1 = Convert.ToInt32(Str.Substring(0, dl));
            int N2 = Convert.ToInt32(Str.Substring(0, dl));
            int N3 = Convert.ToInt32(Str.Substring(0, dl));
            int N4 = Convert.ToInt32(Str.Substring(0, dl));
            int N5 = Convert.ToInt32(Str.Substring(0, dl));
            int N6 = Convert.ToInt32(Str.Substring(dl));

            int a, b, c;

            a = N1 + N2 + N3;
            b = N4 + N5 + N6;
            c = N6 + N5 + N4;

            if (a == b)
            {
                Console.WriteLine("Ваш билет счастливый:) ");
            }
            else if (a == c)
            {
                Console.WriteLine("Ваш билет зеркальный");
            }
            else
            {
                Console.WriteLine("Ваш билет простой");
            }
            Console.ReadKey();
        }
        /* Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра на величину 32. 
         Используя эту информацию, написать программу, 
         которая считывает с клавиатуры и конвертирует все символы нижнего регистра в символы верхнего регистра и наоборот */
        public static void Main()
        {
            int down = 0;
            int up = 0;
            char symbolChar = ' ';
            Console.WriteLine("Введите текст используя маленькие и большие буквы");
            Console.WriteLine("\n");
            while (symbolChar != '.')
            {
                var symbol = Console.Read();

                if (symbol >= 65 && symbol <= 90)
                {
                    symbol += 32;
                    ++down;
                }
                else if (symbol >= 97 && symbol <= 122)
                {
                    symbol -= 32;
                    ++up;
                }
                symbolChar = Convert.ToChar(symbol);
                Console.Write(symbolChar);
            }
        }
        /* Даны целые положительные числа A и B (A < B). 
            Вывести все целые числа от A до B включительно; 
            каждое число должно выводиться на новой строке; 
            при этом каждое число должно выводиться количество раз, равное его значению. 
            Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:
		    3 3 3
            4 4 4 4
            5 5 5 5 5
            6 6 6 6 6 6
            7 7 7 7 7 7 7 */
        static void Main(string[] args)
        {
            uint a = 3, b = 7;
            for (uint i = a; i <= b; ++i)
            {
                for (uint j = 0; j < i; ++j)
                {
                    Console.Write(i.ToString() + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        /* Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево. 
         * Например, если было введено число 345, то программа должна вывести число 543.*/
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            Int64 value = Int64.Parse(Console.ReadLine());
            Int64 reverse_val = Int64.Parse(new string(value.ToString().Reverse().ToArray()));
            Console.Write("Обратная запись числа: " + reverse_val);
            Console.ReadKey();
        }
    }
}
