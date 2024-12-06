using System;
using SolveMathFirstExpression.Lib;
using SolveMathSecondExpression.Lib;
using SolveTabMathFunction.Lib;
using SolveCalculate.Lib;
using SolveArray.Lib;

namespace Tyuiu.ShutnikovaST.Lab3.Review.V12
{
    internal class Program
    {
        public static int indexItem;

        static void UpArrow()
        {
            indexItem--;
            if (indexItem < 1) indexItem = 5;
            drawMainMenu();
        }

        static void DownArrow()
        {
            indexItem++;
            if (indexItem > 5) indexItem = 1;
            drawMainMenu();
        }

        static void selectItem()
        {
            switch (indexItem)
            {
                case 1:
                    Option1();
                    break;
                case 2:
                    Option2();
                    break;
                case 3:
                    Option3();
                    break;
                case 4:
                    Option4();
                    break;
                case 5:
                    Option5();
                    break;
            }
        }

        static void Option1()
        {
            var exp1 = new MathFirstExpression();
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("РАССЧИТАТЬ ПЕРВОЕ МАТЕМАТИЧЕСКОЕ ВЫРАЖЕНИЕ");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.SetCursorPosition(0, 3);

            Console.WriteLine("значение x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("значение y:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("значение a:");
            double a = Convert.ToDouble(Console.ReadLine());
            double z1 = exp1.CalculateFirstExpression(x, y, a);
            Console.WriteLine($"выражение 1: z = {z1}");

            Console.SetCursorPosition(0, 22);
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.SetCursorPosition(0, 24);
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернуться в главное меню");
            Console.CursorVisible = false;
            while (true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    drawMainMenu();
                    break;
                }
                else Option1();
            }
        }

        static void Option2()
        {
            var exp2 = new MathSecondExpression();
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("РАССЧИТАТЬ ВТОРОЕ МАТЕМАТИЧЕСКОЕ ВЫРАЖЕНИЕ");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.SetCursorPosition(1, 3);

            Console.WriteLine("значение x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("значение y:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("значение a:");
            double a = Convert.ToDouble(Console.ReadLine());
            double z2 = exp2.CalculateSecondExpression(x, y, a);
            Console.WriteLine($"выражение 2: z = {z2}");

            Console.WriteLine("------------------------------------------------------------------------------");
            Console.SetCursorPosition(0, 22);

            Console.SetCursorPosition(0, 24);
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернуться в главное меню");
            Console.CursorVisible = false;
            while (true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    drawMainMenu();
                    break;
                }
                else Option2();
            }
        }

        static void Option3()
        {
            var tab = new TabMathFunction();
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("ПРОТАБУЛИРОВАТЬ ФУНКЦИЮ НА ЗАДАННОМ ДИАПАЗОНЕ");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.SetCursorPosition(1, 3);

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          * ");
            Console.WriteLine("******************************************************************************");
            Console.Write("Старт шага = ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Конец шага = ");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |    f(x)  |");
            Console.WriteLine("+----------+----------+");
            double[] results = tab.CalculateTabMathFunction(start, end);
            for (int x = 0; x < results.Length; x++)
            {
                int i = start + x;
                string fx = results[x].ToString();
                Console.WriteLine($"| {i,8} | {fx,8} |");
            }

            Console.WriteLine("------------------------------------------------------------------------------");
            Console.SetCursorPosition(0, 22);

            Console.SetCursorPosition(0, 24);
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернуться в главное меню");
            Console.CursorVisible = false;
            while (true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    drawMainMenu();
                    break;
                }
                else Option3();
            }
        }

        static void OptionFS()
        {
            Console.Clear();
            Console.WriteLine("СПРАВКА");
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.SetCursorPosition(1, 3);
            Console.WriteLine(" Справочные сведения по работе с программой");
            Console.SetCursorPosition(1, 6);
            Console.WriteLine(" РАЗДЕЛ МЕНЮ ");
            Console.SetCursorPosition(30, 6);
            Console.WriteLine(" ОПИСАНИЕ ");
            Console.SetCursorPosition(64, 6);
            Console.WriteLine(" ПАРАМЕТР КОМ. СТРОКИ ");
            Console.SetCursorPosition(1, 8);
            Console.WriteLine(" 1. Рассчитать ПЕРВОЕ МАТ...  ");
            Console.SetCursorPosition(30, 8);
            Console.WriteLine(" Вычисляет матем. выражение... ");
            Console.SetCursorPosition(64, 8);
            Console.WriteLine(" /1 ");
            Console.SetCursorPosition(1, 10);
            Console.WriteLine(" 2. Рассчитать ВТОРОЕ МАТ... ");
            Console.SetCursorPosition(30, 10);
            Console.WriteLine(" Вычисляет матем. выражение... ");
            Console.SetCursorPosition(64, 10);
            Console.WriteLine(" /2 ");
            Console.SetCursorPosition(1, 12);
            Console.WriteLine(" 3. ПРОТАБУЛИРОВАТЬ ФУНК... ");
            Console.SetCursorPosition(30, 12);
            Console.WriteLine(" Табулирует функцию... ");
            Console.SetCursorPosition(64, 12);
            Console.WriteLine(" /3 ");
            Console.SetCursorPosition(1, 14);
            Console.WriteLine(" 4. КАЛЬКУЛЯТОР ");
            Console.SetCursorPosition(30, 14);
            Console.WriteLine(" Выполняет расчет +, -, *, / ");
            Console.SetCursorPosition(64, 14);
            Console.WriteLine(" /4 ");
            Console.SetCursorPosition(1, 16);
            Console.WriteLine(" 5. ОБРАБОТКА ОДНОМЕРНОГО... ");
            Console.SetCursorPosition(30, 16);
            Console.WriteLine(" Обрабатывает одномерный массив... ");
            Console.SetCursorPosition(64, 16);
            Console.WriteLine(" /5 ");
            Console.SetCursorPosition(1, 21);
            Console.WriteLine(" Программу разработала ШУТНИКОВА СТЕФАНИЯ ТАТЬЯНА | МКМб-22-1 | ТИУ 2024");
            Console.SetCursorPosition(0, 22);
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернуться в главное меню");
            Console.CursorVisible = false;
            while (true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    drawMainMenu();
                    break;
                }
                else OptionFS();
            }
        }
        static void Option4()
        {
            var calclator = new Calculate();

            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("КАЛЬКУЛЯТОР");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.SetCursorPosition(1, 3);
            Console.WriteLine("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double summa = calclator.CalculateSumma(a, b);
            double difference = calclator.CalculateDifference(a, b);
            double multiplication = calclator.CalculateMultiplication(a, b);
            double quotient = calclator.CalculateQuotient(a, b);
            Console.WriteLine($"Сложение: {summa}");
            Console.WriteLine($"Выычитание: {difference}");
            Console.WriteLine($"Умножение: {multiplication}");
            Console.WriteLine($"Деление: {quotient}");

            Console.WriteLine("------------------------------------------------------------------------------");
            Console.SetCursorPosition(0, 22);

            Console.SetCursorPosition(0, 24);
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернуться в главное меню");
            Console.CursorVisible = false;
            while (true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    drawMainMenu();
                    break;
                }
                else Option4();
            }
        }
        static void Option5()
        {
            var array = new SolveArray.Lib.Array();

            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("ОБРАБОТКА ОДНОМЕРНОГО МАССИВА");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.SetCursorPosition(1, 3);
            Console.WriteLine("Введите количество элементов массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите минимальное значение массива: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальное значение массива: ");
            int max = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++) numbers[i] = random.Next(min, max + 1);
            Console.WriteLine("Массив значений:");
            for (int i=0; i < n; i++) Console.WriteLine($"{i} = {numbers[i]}");

            int minimum = array.CalculateMinimum(numbers);
            int maximum = array.CalculateMaximum(numbers);
            double averenge = array.CalculateAverage(numbers);
            double median = array.CalculateMedian(numbers);
            int numberOfEven = array.CalculateNumberOfEven(numbers);
            int numberOfOdd = array.CalculateNumberOfOdd(numbers);
            int divisibleByTwo = array.SignsOfDivisibilityByTwo(numbers);
            int divisibleByThree = array.SignsOfDivisibilityByThree(numbers);
            int divisibleByFive = array.SignsOfDivisibilityByFive(numbers); 
            int divisibleByTen = array.SignsOfDivisibilityByTen(numbers);   

            Console.WriteLine($"Минимальный элемент: {minimum}");
            Console.WriteLine($"Максимальный элемент: {maximum}");
            Console.WriteLine($"Среднее значение: {averenge}");
            Console.WriteLine($"Медиана: {median}");
            Console.WriteLine($"Чётные элементы: {numberOfEven}");
            Console.WriteLine($"Нечётные элементы: {numberOfOdd}");
            Console.WriteLine($"Делятся на 2: {divisibleByTwo}");
            Console.WriteLine($"Делятся на 3: {divisibleByThree}");
            Console.WriteLine($"Делятся на 5: {divisibleByFive}");
            Console.WriteLine($"Делятся на 10: {divisibleByTen}");

            Console.WriteLine("------------------------------------------------------------------------------");
            Console.SetCursorPosition(0, 22);

            Console.SetCursorPosition(0, 24);
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернуться в главное меню");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.CursorVisible = false;
            while (true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    drawMainMenu();
                    break;
                }
                else Option5();
            }
        }

        static void OptionExit()
        {
            Environment.Exit(0);
        }

        static void drawMainMenu()
        {
            Console.CursorVisible = true;
            Console.Clear();
            Console.ResetColor();
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("║                            Лабораторная работа #3                         ║");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("║                       Создание консольного интерфейса                     ║");
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("║                     Выполнила Шутникова Стефания Татьяна                  ║");
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("║                          ТИУ-2024, группа МКМб-22-1                       ║");
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("   ");
            switch (indexItem)
            {
                case 0:
                    Console.WriteLine(" МЕНЮ");
                    Console.WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 1. ");
                    Console.WriteLine(" Рассчитать первое математическое выржение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 2. ");
                    Console.WriteLine(" Рассчитать второе математическое выржение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 3. ");
                    Console.WriteLine(" Протабулировать функцию на заданном диапазоне");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 4. ");
                    Console.WriteLine(" Калькулятор");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 5. ");
                    Console.WriteLine(" Обработка одномерного массива");
                    break;

                case 1:
                    Console.WriteLine(" МЕНЮ");
                    Console.WriteLine(" ");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" 1. ");
                    Console.WriteLine(" Рассчитать первое математическое выржение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 2. ");
                    Console.WriteLine(" Рассчитать второе математическое выржение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 3. ");
                    Console.WriteLine(" Протабулировать функцию на заданном диапазоне");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 4. ");
                    Console.WriteLine(" Калькулятор");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 5. ");
                    Console.WriteLine(" Обработка одномерного массива");
                    break;

                case 2:
                    Console.WriteLine(" МЕНЮ");
                    Console.WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 1. ");
                    Console.WriteLine(" Рассчитать первое математическое выржение");
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" 2. ");
                    Console.WriteLine(" Рассчитать второе математическое выржение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 3. ");
                    Console.WriteLine(" Протабулировать функцию на заданном диапазоне");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 4. ");
                    Console.WriteLine(" Калькулятор");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 5. ");
                    Console.WriteLine(" Обработка одномерного массива");
                    break;

                case 3:
                    Console.WriteLine(" МЕНЮ");
                    Console.WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 1. ");
                    Console.WriteLine(" Рассчитать первое математическое выржение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 2. ");
                    Console.WriteLine(" Рассчитать второе математическое выржение");
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" 3. ");
                    Console.WriteLine(" Протабулировать функцию на заданном диапазоне");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 4. ");
                    Console.WriteLine(" Калькулятор");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 5. ");
                    Console.WriteLine(" Обработка одномерного массива");
                    break;

                case 4:
                    Console.WriteLine(" МЕНЮ");
                    Console.WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 1. ");
                    Console.WriteLine(" Рассчитать первое математическое выржение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 2. ");
                    Console.WriteLine(" Рассчитать второе математическое выржение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 3. ");
                    Console.WriteLine(" Протабулировать функцию на заданном диапазоне");
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" 4. ");
                    Console.WriteLine(" Калькулятор");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 5. ");
                    Console.WriteLine(" Обработка одномерного массива");
                    break;

                case 5:
                    Console.WriteLine(" МЕНЮ");
                    Console.WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.White; 
                    Console.Write(" 1. ");
                    Console.WriteLine(" Рассчитать первое математическое выржение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 2. ");
                    Console.WriteLine(" Рассчитать второе математическое выржение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 3. ");
                    Console.WriteLine(" Протабулировать функцию на заданном диапазоне");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 4. ");
                    Console.WriteLine(" Калькулятор");
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue; Console.Write(" 5. ");
                    Console.WriteLine(" Обработка одномерного массива");
                    Console.ResetColor();
                    break;


            }

            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine(" Выберите пункт меню стрелками или нажмите номер пункта [ ]  ");

            Console.SetCursorPosition(0, 22);
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.SetCursorPosition(0, 24);
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("[F1]");
            Console.ResetColor();
            Console.Write(" - Справка | ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red; Console.Write("[F10]");
            Console.ResetColor();
            Console.Write(" - Выход   Перемещение:");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("[СТРЕЛКА ВНИЗ]");
            Console.ResetColor();
            Console.Write(" | ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("[СТРЕЛКА ВВЕРХ]");
            Console.ResetColor();

            Console.SetCursorPosition(57, 16);

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.NumPad1:
                    Option1();
                    break;

                case ConsoleKey.NumPad2:
                    Option2();
                    break;

                case ConsoleKey.NumPad3:
                    Option3();
                    break;

                case ConsoleKey.NumPad4:
                    Option4();
                    break;

                case ConsoleKey.NumPad5:
                    Option5();
                    break;

                case ConsoleKey.D1:
                    OptionFS();
                    break;

                case ConsoleKey.D0:
                    OptionExit();
                    break;

                default:
                    drawMainMenu();
                    break;

                case ConsoleKey.UpArrow:
                    UpArrow();
                    break;

                case ConsoleKey.DownArrow:
                    DownArrow();
                    break;

                case ConsoleKey.Enter:
                    selectItem();
                    break;
            }

        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(90, 25);
            Console.SetBufferSize(90, 25);

            foreach (string arg in args)
            {
                if (arg == "1")
                {
                    Option1();
                }
                if (arg == "2")
                {
                    Option2();
                }
                if (arg == "3")
                {
                    Option3();
                }
                if (arg == "4")
                {
                    Option4();
                }
                if (arg == "5")
                {
                    Option5();
                }
            }

            drawMainMenu();
            Console.ReadKey();
        }
    }
}
