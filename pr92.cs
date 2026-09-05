1. 
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string N = Console.ReadLine();

            Console.Write("Введите возраст: ");
            Int32.TryParse(Console.ReadLine(), out int A);

            Console.WriteLine($"Привет, {N}! Тебе {A} лет");
        }
    }
}

2.
using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            Int32.TryParse(Console.ReadLine(), out int a);

            Console.Write("Введите второе число: ");
            Int32.TryParse(Console.ReadLine(), out int b);

            Console.Write("Введите третье число: ");
            Int32.TryParse(Console.ReadLine(), out int c);

            Console.WriteLine($"Сумма чисел = {a + b + c}");
        }
    }
}

3.
using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            Int32.TryParse(Console.ReadLine(), out int a);

            if (a % 2 == 0)
            {
                Console.WriteLine("Делит на 2");
            }
            else
            {
                Console.WriteLine("Не делит на 2");
            }
        }
    }
}

4.
using System;
using System.ComponentModel.Design;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            Int32.TryParse(Console.ReadLine(), out int a);
            Console.Write("Введите первое число: ");
            Int32.TryParse(Console.ReadLine(), out int b);

            if (a < b)
            {
                Console.WriteLine(b);
            }
            else if (a == b)
            {
                Console.WriteLine("Равные");
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}

5.
using System;
using System.ComponentModel.Design;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите возраст: ");
            Int32.TryParse(Console.ReadLine(), out int a);

            if (a < 18)
            {
                Console.WriteLine("Вы не можете получить прова");
            }
            else
            {
                Console.WriteLine("Вы можете получить права");
            }
        }
    }
}

6.
using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            bool s = int.TryParse(Console.ReadLine(), out int N);

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

7.
using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово: ");
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i]);
            }
        }
    }
}

8.
using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            bool parsed = int.TryParse(Console.ReadLine(), out int N);

            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}

9.
using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i > -1)
            {
                Console.Write("Введите число: ");
                if (Int32.TryParse(Console.ReadLine(), out i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Конец");
        }
    }
}

10.
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            if (Int32.TryParse(Console.ReadLine(), out int a))
            {
                int count = 1;
                while (count <= 10)
                {
                    Console.WriteLine($"{a} x {count} = {a * count}");
                    count++;
                }
            }
        }
    }
}
