﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using System;
            //using System.Collections.Generic;

            //Console.WriteLine("Введите перовое число: ");
            //int firstVallue, SecondVallue;
            //firstVallue = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите второе число: ");
            //SecondVallue = int.Parse(Console.ReadLine());

            //Console.WriteLine("Чо делать? \n1. + \n2. - \n3. / \n4. * \n");

            //char z = Convert.ToChar(Console.ReadLine());

            //switch (z)
            //{
            //    case '1':
            //        Console.WriteLine(firstVallue + SecondVallue);
            //        break;

            //    case '2':
            //        Console.WriteLine(firstVallue - SecondVallue);
            //        break;

            //    case '3':
            //        if (SecondVallue == 0)
            //        {
            //            Console.WriteLine("На ноль делить нельзя!");
            //            break;
            //        }
            //        Console.WriteLine(firstVallue / SecondVallue);
            //        break;

            //    case '4':
            //        Console.WriteLine(firstVallue * SecondVallue);
            //        break;

            //    default:
            //        Console.WriteLine("бан");
            //        break;
            //}


            //Console.Write("Введите строку: ");
            //string stroka = Console.ReadLine();
            //Console.WriteLine("Количество символов в строке: " + stroka.Length);
            //stroka = stroka.Trim();
            //int a = 0;
            //string[] array = stroka.Split(".");
            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    array[i] = array[i].Trim();
            //    a += array[i].Split(" ").Length;
            //}
            //Console.WriteLine($"Количество слов в строке: {a}");


            //for (int i = 0; i < stroka.Length; i++)
            //{
            //    if (stroka[i] == '.')
            //    {
            //        for (int j = i; j < stroka.Length; j++)
            //        {
            //            if (stroka[j] != '.')
            //            {
            //                a++;
            //                i = j;
            //                break;
            //            }

            //        }
            //    }
            //}

            //Console.WriteLine($"Количество предложений в строке: {a}");


            ///*Console.Write("Введите строку: ");
            //string stroka = Console.ReadLine();
            //Console.WriteLine("Количество символов в строке: " + stroka.Length);
            //stroka = stroka.Trim();
            //int a = 0;
            //string[] array = stroka.Split(".");
            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    if (array[i].Length == 0)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        array[i] = array[i].Trim();

            //        string[] arr = array[i].Split(" ");
            //        for (int j = 0; j < arr.Length; j++)
            //        {
            //            if (arr[j].Length == 0)
            //            {
            //                continue;
            //            }
            //            else
            //            {
            //                a++;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine($"Количество слов в строке: {a}");
            //a = 0;
            //for (int i = 0; i < stroka.Length; i++)
            //{
            //    if (stroka[i] == '.')
            //    {
            //        for (int j = i; j < stroka.Length; j++)
            //        {
            //            if (stroka[j] != '.')
            //            {
            //                a++;
            //                i = j;
            //                break;
            //            }
            //        }
            //    }
            //}

            //задание 3//
            //Console.WriteLine($"Количество предложений в строке: {a + 1}");*/
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write($"{j}*{i} = {i * j}  \t");
            //    }
            //    Console.WriteLine();
            //}

            //задание 4//

            //int number = int.Parse(Console.ReadLine());
            //int a = 1;
            //for (int i = 1; i < number; i++)
            //{
            //    a += a * i;
            //}
            //Console.WriteLine(a);

            //задание 5//


            //int number = int.Parse(Console.ReadLine());
            //int a, b, c;
            //c = 0;
            //b = 1;
            //a = 0;
            //for (int i = 0; i < number - 1; i++)
            //{
            //    a = (c + b);
            //    c = b;
            //    b = a;
            //    Console.WriteLine(a);
            //}

            //задание 6//
            //int number = int.Parse(Console.ReadLine());

            //int a = 0;
            //for (int i = 1; i < number; i++)
            //{
            //    a = 0;
            //    for (int j = 1; j < number; j++)
            //    {
            //        if (i % j == 0)
            //            a++;
            //    }
            //    if (a == 2)
            //        Console.WriteLine(i);
            //}

            //задание 7//
            //int firstVallue, secondvalue;
            //firstVallue = int.Parse(Console.ReadLine());
            //Random random = new Random();
            //secondvalue = random.Next(1, 100);

            //while (true)
            //{
            //    if (firstVallue == secondvalue)
            //    {
            //        Console.WriteLine("Угадал!");
            //        break;
            //    }
            //    else if (firstVallue < secondvalue)
            //    {
            //        Console.Write("Холодно мы в сибири,напиши число заново:");
            //        firstVallue = int.Parse(Console.ReadLine());
            //    }
            //    else if (firstVallue > secondvalue)
            //    {
            //        Console.WriteLine("Слишком большое число, напиши число заново:");
            //        firstVallue = int.Parse(Console.ReadLine());
            //    }
            //}
            //задание 8//
            //площадь круга
            //Console.WriteLine("Площадь какой фигуры вы хотите посчитать. 1. круг 2. треугольник 3. прямоугольник");
            //char z = Convert.ToChar(Console.ReadLine());
            //switch (z)
            //{
            //    case '1':
            //        double pi = 3.62;
            //        Console.WriteLine("Введиет радиус: ");
            //        double firstVallue = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("Площадь круга: " + pi * (firstVallue * firstVallue));
            //        break;
            //    case '2':
            //        Console.WriteLine("Введите высоту треугольника: ");
            //        double h = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("Введите основание треугольника: ");
            //        double a = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("Площадь треугольника: " + 0, 5 * a * h);
            //        break;
            //    case '3':
            //        Console.WriteLine("Введите длину прямоугольника: ");
            //        double dlina = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("Введите ширину прямоугольника: ");
            //        double schirina = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("Площадь прямоугольника: " + dlina * schirina);
            //        break;
            //}
            //задание 9

            //Console.WriteLine("1.Метры в километры \n2.Килограммы в граммы\n3.Км/ч в М/ч");
            //double number = double.Parse(Console.ReadLine());
            //switch (number)
            //{
            //    case 1:
            //        {
            //            Console.WriteLine("Введите метры: ");
            //            double km = double.Parse(Console.ReadLine());
            //            Console.WriteLine(km / 1000 + " километров");
            //            break;
            //        }
            //    case 2:
            //        {
            //            Console.WriteLine("Введите килограммы");
            //            double kg = double.Parse(Console.ReadLine());
            //            Console.WriteLine(kg * 1000 + " граммов");
            //            break;
            //        }
            //    case 3:
            //        {
            //            Console.WriteLine("Введите Км/ч");
            //            double speed = double.Parse(Console.ReadLine());
            //            Console.WriteLine(speed * 0.6214 + " миль");
            //            break;
            //        }
            //}

            //задание 10//

            //double number = double.Parse(Console.ReadLine());
            //double interest = double.Parse(Console.ReadLine());
            //double a = (number / 100) * interest;
            //Console.WriteLine(a);


            //Задание 11: Конвертер валют
            //Разработать приложение, которое переводит суммы из одной валюты в другую,
            //используя заданный курс.

            //Console.WriteLine("Введите номер операции\n1.Рубли в доллары США\n2.Рубли в гвинейские франки\n3.Рубли в тенге");
            //int choice = int.Parse(Console.ReadLine());
            //double rub = 0;

            //switch (choice)
            //{
            //    case 1:
            //        Console.Write("Введите количество рублей: ");
            //        rub = double.Parse(Console.ReadLine());
            //        Console.WriteLine($"Рубли в доллары США => {rub / 90.55}");
            //        break;
            //    case 2:
            //        Console.Write("Введите количество рублей: ");
            //        rub = double.Parse(Console.ReadLine());
            //        Console.WriteLine($"Рубли в в гвинейские франки => {rub * 95.51}");
            //        break;
            //    case 3:
            //        Console.Write("Введите количество рублей: ");
            //        rub = double.Parse(Console.ReadLine());
            //        Console.WriteLine($"Рубли в тенге => " + rub * 5.29);
            //        break;
            //    default:
            //        Console.WriteLine("Неверно выбрана оперция");
            //        break;
            //}

            //Задание 12: Работа с массивами
            //Написать программу, которая находит минимальный, максимальный элемент
            //массива и их индексы.

            //int[] arr = { 1, 12, 25, 0, 16, 100 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == arr.Max())
            //        Console.WriteLine("Индекс максимального числа:" + i);
            //    if (arr[i] == arr.Min())
            //        Console.WriteLine("Индекс минимального числа:" + i);
            //}


            //Задание 13: Сортировка массива
            //Создать программу, которая сортирует массив чисел по возрастанию и
            //убыванию, используя разные методы сортировки.

            //int[] arr = { 1, 12, 25, 0, 16, 100 };

            //Array.Sort(arr);
            //Console.WriteLine("Массив по возрастанию");
            //foreach (int i in arr)
            //{
            //    Console.Write($"|{i}|");
            //}
            //Console.WriteLine();
            //Array.Reverse(arr);
            //Console.WriteLine("Массив по убыванию");
            //foreach (int i in arr)
            //{
            //    Console.Write($"|{i}|");
            //}


            //Задание 14: Поиск в массиве
            //Разработать программу, которая ищет элемент в массиве и выводит его индекс
            //или сообщение, что элемент не найден.

            //List<int> list = new List<int>();
            //Random random = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    list.Add(random.Next(1, 100));
            //}
            //list[4] = list[0];
            //foreach (int i in list)
            //{
            //    Console.Write($"|{i}|");
            //}
            //Console.Write("\nВведите число: ");
            //int num = int.Parse(Console.ReadLine());
            //if (list.BinarySearch(num) == (list.Count + 1) * (-1))
            //    Console.WriteLine("Число не найдено!");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i] == num)
            //        Console.WriteLine("Индекс в массиве: " + i);
            //}

            //Задание 15: Обратный порядок массива
            //Написать программу, которая выводит элементы массива в обратном порядке.

            //int[] arr = { 1, 12, 25, 0, 16, 100 };

            //Array.Reverse(arr);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"|{arr[i]}|");
            //}


            //Задание 16
            //int[,] arrA = new int[10, 10];
            //int[,] arrB = new int[10, 10];
            //int[,] arrC = new int[10, 10];

            //Set(arrB);
            //Set(arrA);
            //Get(arrA);
            //Get(arrB);


            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        arrC[i, j] = arrA[i, j] + arrB[i, j];
            //    }
            //}
            //Get(arrC);


            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        arrC[i, j] = arrA[i, j] - arrB[i, j];
            //    }
            //}
            //Get(arrC);



            //int sum = 0;
            //int schet = 0;
            //while (schet != 10)
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        for (int j = 0; j < 10; j++)
            //        {
            //            sum += arrA[schet, j] * arrB[j, i];
            //        }
            //        Console.Write($"|{sum}|");
            //        sum = 0;
            //    }
            //    Console.WriteLine();
            //    schet++;
            //}

            //Console.WriteLine();
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.Write($"|{arrB[j, i]}|");
            //    }
            //    Console.WriteLine();
            //}



            //int[,] Get(int[,] arr)
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        for (int j = 0; j < 10; j++)
            //        {
            //            Console.Write($"|{arr[i, j]}|");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //    return arr;
            //}

            //int[,] Set(int[,] arr)
            //{
            //    Random rand = new Random();
            //    for (int i = 0; i < 10; i++)
            //    {
            //        for (int j = 0; j < 10; j++)
            //        {
            //            arr[i, j] = rand.Next(1, 10);
            //        }
            //    }
            //    return arr;
            //}
            //Задание 17: Преобразование чисел
            //Написать программу, которая переводит число из десятичной системы
            //счисления в двоичную, восьмеричную и шестнадцатеричную.

            //Console.Write("Введите число:");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("Двоичная: " + Convert.ToString(Convert.ToInt32(number), 2));
            //Console.WriteLine("Восьмиричная: " + Convert.ToString(Convert.ToInt32(number), 8));
            //Console.WriteLine("Шестнадцатеричная" + Convert.ToString(Convert.ToInt32(number), 16));

            //Задание 18: Числовая пирамида
            //Разработать программу, которая выводит числовую пирамиду на экран.
            //int number = 1;
            //int number2 = 80;
            //for (int k = 0; k < number2; k++)
            //{
            //    for (int i = number2; i > 0; i--)
            //    {
            //        Console.Write(" ");
            //    }
            //    number2--;
            //    for (int i = 0; i < number; i++)
            //    {
            //        Console.Write("1");
            //    }
            //    number += 2;
            //    Console.WriteLine();
            //}


            //Задание 19: Поиск в строках
            //Написать программу, которая ищет подстроку в строке и выводит ее индекс или
            //сообщение, что подстрока не найдена.

            //List<string> stroka = new List<string>();

            //stroka.Add("Эта строка написана для теста");
            //Console.WriteLine(stroka[0]);

            //string postroka = Console.ReadLine();
            //postroka = postroka.ToLower();

            //if (stroka[0].IndexOf(postroka) == -1)
            //{
            //    Console.WriteLine($"Начальный индекс: 0 \nКонечный индекс: {stroka[0].IndexOf(postroka) + postroka.Length}");
            //}
            //else
            //{
            //    Console.WriteLine($"Начальный индекс: {stroka[0].IndexOf(postroka)} \nКонечный индекс: {stroka[0].IndexOf(postroka) + postroka.Length - 1}");
            //}

            //Задание 20: Удаление пробелов
            //Создать программу, которая удаляет все лишние пробелы из строки, оставляя
            //по одному между словами.

            //string stroka = "   Эта строка   написана   для   теста";
            //string strokaSum = "";
            //string[] arr = stroka.Split(' ');

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = arr[i].Trim();
            //    if (arr[i].Length != 0)
            //    {
            //        strokaSum += arr[i];
            //        strokaSum += " ";
            //    }
            //}
            //Console.WriteLine(strokaSum);


            //Задание 21: Калькулятор даты
            //Написать программу, которая вычисляет количество дней между двумя датами,
            //введенными пользователем

            //int day = int.Parse(Console.ReadLine());
            //int month = int.Parse(Console.ReadLine());
            //int year = int.Parse(Console.ReadLine());

            //DateTime time1 = new DateTime(year, month, day);
            //int day2 = int.Parse(Console.ReadLine());
            //int month2 = int.Parse(Console.ReadLine());
            //int year2 = int.Parse(Console.ReadLine());

            //DateTime time2 = new DateTime(year2, month2, day2);

            //Console.WriteLine(time1 - time2);


            //Задание 22: Валидация данных
            //Разработать программу, которая проверяет корректность ввода данных
            //(например, номер телефона, e-mail и т.д.).
            //Console.Write("Введите номер телефона: ");
            //string number = Console.ReadLine();
            //Console.Write("Введите почту: ");
            //string email = Console.ReadLine();
            //if (number[0] == '+' && number.Length == 12)
            //{
            //    if (number[1] == '7' || number[1] == '8')
            //    {
            //        Console.WriteLine("Номер ведён верно");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Номер ведён не верно");
            //}

            //if (email.Split('@').Length > 2)
            //{
            //    Console.WriteLine("соси");
            //    Environment.Exit(0);
            //}

            //if (email.Contains("@") && email.Contains("gmail.com") || email.Contains("@") && email.Contains("mail.ru"))
            //{
            //    Console.WriteLine("Почта ведена верно");
            //}
            //else
            //{
            //    Console.WriteLine("Почта ведена не верно");
            //}

            //23: Генерация паролей
            //Создать приложение, которое генерирует случайный пароль заданной длины, с учетом использования 
            //букв, цифр и специальных символов.
            //char[] array = { '!', '@', '#', '$', '%', '^', '&', '*' };
            //char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            //Random rand = new Random();
            //Console.Write("Введите длинну пароля: ");
            //int lenght = int.Parse(Console.ReadLine());
            //string password = "";
            //for (int i = 0; i < lenght; i++)
            //{
            //    int number = rand.Next(1, 4);
            //    if (number == 1)
            //    {
            //        password += rand.Next(1, 10);
            //    }
            //    if (number == 2)
            //    {
            //        password += alpha[rand.Next(0, alpha.Length)];
            //    }
            //    if (number == 3)
            //    {
            //        password += array[rand.Next(0, array.Length)];
            //    }
            //}
            //Console.WriteLine(password);

            //Задание 24: Чек на покупки
            //Написать программу, которая принимает список покупок и их стоимость, а затем
            //выводит чек с общей суммой и НДС
            //double sum = 0;
            //string[] arr = new string[0];
            //while (true)
            //{
            //    Console.WriteLine("В вашей корзине: ");
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.Write($"|{arr[i]}|");
            //    }
            //    Console.WriteLine();
            //    Console.Write("Введите товар: ");
            //    string tovar = Console.ReadLine();
            //    Array.Resize(ref arr, arr.Length + 1);
            //    arr[arr.Length - 1] = tovar;
            //    Console.Write("Введите цену товара: ");
            //    double sell = int.Parse(Console.ReadLine());
            //    arr[arr.Length - 1] += " " + $"{sell.ToString()}руб.";
            //    sum += sell;
            //    Console.Clear();
            //    while (true)
            //    {
            //        Console.WriteLine("Продукты закончились?\n1.Да\n2.Нет");
            //        int choice = int.Parse(Console.ReadLine());
            //        if (choice == 1)
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Сумма для оплаты: " + (sum + ((sum / 100) * 20)));
            //            Environment.Exit(0);
            //        }
            //        else
            //        {
            //            Console.Clear();
            //            break;
            //        }
            //    }
            //}

            //Задание 25: Анализ текста
            //Разработать приложение, которое анализирует текст, введенный
            //пользователем, и выводит статистику по частоте использования каждого слова
            //int count = 0;
            //char a = ' ';
            //Console.Write("Введите текст: ");
            //string patch = Console.ReadLine();
            //string str1 = "";
            //patch.Replace('.', a);
            //string[] arr = patch.Split(' ');
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == str1)
            //    {
            //        count++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Таких слов нету");
            //    }

            //}
            //Console.ReadLine();

            //class Program
            //{
            //    static void Main(string[] args)
            //    {
            //        Console.WriteLine("Введите текст:");
            //        string inputText = Console.ReadLine();

            //        // Разделение текста на слова
            //        string[] words = inputText.Split(new char[] { ' ', ',', '.', '!', '?', ':', ';', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

            //        // Приведение слов к нижнему регистру
            //        words = words.Select(w => w.ToLower()).ToArray();

            //        // Подсчет количества упоминаний каждого слова
            //        Dictionary<string, int> wordCount = new Dictionary<string, int>();
            //        foreach (string word in words)
            //        {
            //            if (wordCount.ContainsKey(word))
            //            {
            //                wordCount[word]++;
            //            }
            //            else
            //            {
            //                wordCount[word] = 1;
            //            }
            //        }

            //        // Сортировка слов по количеству упоминаний
            //        var sortedWords = wordCount.OrderByDescending(w => w.Value);

            //        // Вывод статистики по словам
            //        Console.WriteLine("Статистика по словам:");
            //        foreach (var word in sortedWords)
            //        {
            //            Console.WriteLine("{0}: {1}", word.Key, word.Value);
            //        }

            //        Console.ReadKey();
            //    }
            //}

            //26 Примечание: Эта программа не учитывает случаи, когда результат операции превышает 24 часа. Если вы хотите учитывать такие случаи, вам нужно добавить дополнительную логику для обработки этих случаев.
            //using System;
            //using System.Data;

            //class TimeCalculator
            //{
            //    static void Main(string[] args)
            //    {
            //        Console.Write("Введите первое время (часы и минуты через пробел): ");
            //        string[] time1 = Console.ReadLine().Split(' ');
            //        int hours1 = Convert.ToInt32(time1[0]);
            //        int minutes1 = Convert.ToInt32(time1[1]);

            //        Console.Write("Введите второе время (часы и минуты через пробел): ");
            //        string[] time2 = Console.ReadLine().Split(' ');
            //        int hours2 = Convert.ToInt32(time2[0]);
            //        int minutes2 = Convert.ToInt32(time2[1]);

            //        Console.Write("Выберите операцию (+ или -): ");
            //        string operation = Console.ReadLine();

            //        if (operation == "+")
            //        {
            //            AddTime(hours1, minutes1, hours2, minutes2);
            //        }
            //        else if (operation == "-")
            //        {
            //            SubtractTime(hours1, minutes1, hours2, minutes2);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Неправильная операция");
            //        }
            //    }

            //    static void AddTime(int hours1, int minutes1, int hours2, int minutes2)
            //    {
            //        int totalMinutes = minutes1 + minutes2;
            //        int totalHours = hours1 + hours2 + totalMinutes / 60;
            //        totalMinutes %= 60;

            //        Console.WriteLine($"Результат: {totalHours} часов {totalMinutes} минут");
            //    }

            //    static void SubtractTime(int hours1, int minutes1, int hours2, int minutes2)
            //    {
            //        int totalMinutes = minutes1 - minutes2;
            //        int totalHours = hours1 - hours2;

            //        if (totalMinutes < 0)
            //        {
            //            totalMinutes += 60;
            //            totalHours--;
            //        }

            //        Console.WriteLine($"Результат: {totalHours} часов {totalMinutes} минут");
            //    }
            //}
            ////Задание 27: Нахождение корней уравнения
            //Написать программу, которая находит корни квадратного уравнения.
            //using System;

            //class QuadraticEquationSolver
            //{
            //    static void Main(string[] args)
            //    {
            //        Console.Write("Введите коэффициент a: ");
            //        double a = Convert.ToDouble(Console.ReadLine());

            //        Console.Write("Введите коэффициент b: ");
            //        double b = Convert.ToDouble(Console.ReadLine());

            //        Console.Write("Введите коэффициент c: ");
            //        double c = Convert.ToDouble(Console.ReadLine());

            //        SolveQuadraticEquation(a, b, c);
            //    }

            //    static void SolveQuadraticEquation(double a, double b, double c)
            //    {
            //        if (a == 0)
            //        {
            //            if (b == 0)
            //            {
            //                if (c == 0)
            //                {
            //                    Console.WriteLine("Уравнение имеет бесконечно много решений");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Уравнение не имеет решений");
            //                }
            //            }
            //            else
            //            {
            //                double root = -c / b;

            //                Console.WriteLine($"Корень уравнения: x = {root}");
            //            }
            //        }
            //        else
            //        {
            //            double discriminant = b * b - 4 * a * c;

            //            if (discriminant > 0)
            //            {
            //                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            //                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            //                Console.WriteLine($"Корни уравнения: x1 = {root1}, x2 = {root2}");
            //            }
            //            else if (discriminant == 0)
            //            {
            //                double root = -b / (2 * a);

            //                Console.WriteLine($"Корень уравнения: x = {root}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Уравнение не имеет вещественных корней");
            //            }
            //        }
            //    }
            //}
            ////Задание 28: Система уравнений
            //Разработать программу, которая решает систему линейных уравнений с двумя
            //переменными.

            //using System;

            //class LinearEquationSystemSolver
            //{
            //    static void Main(string[] args)
            //    {
            //        Console.Write("Введите коэффициент a1: ");
            //        double a1 = Convert.ToDouble(Console.ReadLine());

            //        Console.Write("Введите коэффициент b1: ");
            //        double b1 = Convert.ToDouble(Console.ReadLine());

            //        Console.Write("Введите коэффициент c1: ");
            //        double c1 = Convert.ToDouble(Console.ReadLine());

            //        Console.Write("Введите коэффициент a2: ");
            //        double a2 = Convert.ToDouble(Console.ReadLine());

            //        Console.Write("Введите коэффициент b2: ");
            //        double b2 = Convert.ToDouble(Console.ReadLine());

            //        Console.Write("Введите коэффициент c2: ");
            //        double c2 = Convert.ToDouble(Console.ReadLine());

            //        SolveLinearEquationSystem(a1, b1, c1, a2, b2, c2);
            //    }

            //    static void SolveLinearEquationSystem(double a1, double b1, double c1, double a2, double b2, double c2)
            //    {
            //        double determinant = a1 * b2 - a2 * b1;

            //        if (determinant == 0)
            //        {
            //            if (a1 * c2 - a2 * c1 == 0 && b1 * c2 - b2 * c1 == 0)
            //            {
            //                Console.WriteLine("Система имеет бесконечно много решений");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Система не имеет решений");
            //            }
            //        }
            //        else
            //        {
            //            double x = (b2 * c1 - b1 * c2) / determinant;
            //            double y = (a1 * c2 - a2 * c1) / determinant;

            //            Console.WriteLine($"Решение системы: x = {x}, y = {y}");
            //        }
            //    }
            //}
            ////Задание 29: Дисковый мониторинг
            //Создать приложение, которое выводит информацию о доступных на компьютере
            //дисках (размер, свободное место и т.д.).
            //using System;
            //using System.IO;

            //class DiskMonitoring
            //{
            //    static void Main(string[] args)
            //    {
            //        DriveInfo[] drives = DriveInfo.GetDrives();

            //        foreach (DriveInfo drive in drives)
            //        {
            //            if (drive.IsReady)
            //            {
            //                Console.WriteLine($"Диск: {drive.Name}");
            //                Console.WriteLine($"Тип диска: {drive.DriveType}");
            //                Console.WriteLine($"Общий размер: {GetFileSize(drive.TotalSize)}");
            //                Console.WriteLine($"Свободное место: {GetFileSize(drive.AvailableFreeSpace)}");
            //                Console.WriteLine($"Занятое место: {GetFileSize(drive.TotalSize - drive.AvailableFreeSpace)}");
            //                Console.WriteLine();
            //            }
            //        }
            //    }

            //    static string GetFileSize(long size)
            //    {
            //        if (size < 1024)
            //        {
            //            return $"{size} байт";
            //        }
            //        else if (size < 1024 * 1024)
            //        {
            //            return $"{size / 1024} КБ";
            //        }
            //        else if (size < 1024 * 1024 * 1024)
            //        {
            //            return $"{size / (1024 * 1024)} МБ";
            //        }
            //        else
            //        {
            //            return $"{size / (1024 * 1024 * 1024)} ГБ";
            //        }
            //    }
            //}
            ////Задание 30: Файловый менеджер
            //Написать консольное приложение, которое позволяет выполнять операции с
            //файлами (создание, удаление, копирование, перемещение).
            //using System;
            //using System.IO;

            //class FileManager
            //{
            //    static void Main(string[] args)
            //    {
            //        Console.WriteLine("Файловый менеджер");
            //        Console.WriteLine("------------------");

            //        while (true)
            //        {
            //            Console.WriteLine("1. Создать файл");
            //            Console.WriteLine("2. Удалить файл");
            //            Console.WriteLine("3. Копировать файл");
            //            Console.WriteLine("4. Переместить файл");
            //            Console.WriteLine("5. Выход");

            //            Console.Write("Выберите операцию: ");
            //            int operation = Convert.ToInt32(Console.ReadLine());

            //            switch (operation)
            //            {
            //                case 1:
            //                    CreateFile();
            //                    break;
            //                case 2:
            //                    DeleteFile();
            //                    break;
            //                case 3:
            //                    CopyFile();
            //                    break;
            //                case 4:
            //                    MoveFile();
            //                    break;
            //                case 5:
            //                    return;
            //                default:
            //                    Console.WriteLine("Неправильный выбор. Попробуйте еще раз.");
            //                    break;
            //            }
            //        }
            //    }

            //    static void CreateFile()
            //    {
            //        Console.Write("Введите имя файла: ");
            //        string fileName = Console.ReadLine();

            //        try
            //        {
            //            using (FileStream file = File.Create(fileName))
            //            {
            //                Console.WriteLine("Файл создан успешно.");
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine("Ошибка создания файла: " + ex.Message);
            //        }
            //    }

            //    static void DeleteFile()
            //    {
            //        Console.Write("Введите имя файла: ");
            //        string fileName = Console.ReadLine();

            //        try
            //        {
            //            File.Delete(fileName);
            //            Console.WriteLine("Файл удален успешно.");
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine("Ошибка удаления файла: " + ex.Message);
            //        }
            //    }

            //    static void CopyFile()
            //    {
            //        Console.Write("Введите имя исходного файла: ");
            //        string sourceFileName = Console.ReadLine();

            //        Console.Write("Введите имя целевого файла: ");
            //        string targetFileName = Console.ReadLine();

            //        try
            //        {
            //            File.Copy(sourceFileName, targetFileName);
            //            Console.WriteLine("Файл скопирован успешно.");
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine("Ошибка копирования файла: " + ex.Message);
            //        }
            //    }

            //    static void MoveFile()
            //    {
            //        Console.Write("Введите имя исходного файла: ");
            //        string sourceFileName = Console.ReadLine();

            //        Console.Write("Введите имя целевого файла: ");
            //        string targetFileName = Console.ReadLine();

            //        try
            //        {
            //            File.Move(sourceFileName, targetFileName);
            //            Console.WriteLine("Файл перемещен успешно.");
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine("Ошибка перемещения файла: " + ex.Message);
            //        }
            //    }
            //}
            ////Задание 31: Работа с JSON
            //Создать программу, которая читает данные из JSON-файла, обрабатывает их и
            //выводит на экран в формате таблицы
            //using System;
            //using System.Collections.Generic;
            //using System.IO;
            //using Newtonsoft.Json;

            //class JsonProcessor
            //{
            //    static void Main(string[] args)
            //    {
            //        string jsonFilePath = "data.json";

            //        try
            //        {
            //            string json = File.ReadAllText(jsonFilePath);
            //            List<Data> data = JsonConvert.DeserializeObject<List<Data>>(json);

            //            Console.WriteLine("Данные из JSON-файла:");
            //            Console.WriteLine("------------------------");

            //            Console.WriteLine("| Имя | Возраст | Город |");
            //            Console.WriteLine("| --- | --- | --- |");

            //            foreach (Data item in data)
            //            {
            //                Console.WriteLine($"| {item.Name} | {item.Age} | {item.City} |");
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine("Ошибка чтения JSON-файла: " + ex.Message);
            //        }
            //    }
            //}

            //public class Data
            //{
            //    public string Name { get; set; }
            //    public int Age { get; set; }
            //    public string City { get; set; }
            //}
            //Эта программа читает данные из JSON-файла data.json, который должен иметь следующий формат:

            //json

            //Verify

            //Open In Editor
            //Edit
            //Copy code
            //[
            //  {
            //    "Name": "Иван",
            //    "Age": 25,
            //    "City": "Москва"
            //  },
            //  {
            //    "Name": "Петр",
            //    "Age": 30,
            //    "City": "Санкт-Петербург"
            //  },
            //  {
            //    "Name": "Сергей",
            //    "Age": 28,
            //    "City": "Казань"
            //  }
            //]
            //Программа десериализует JSON-данные в список объектов Data и выводит их на экран в формате таблицы.

            //Примечание: Для работы с JSON-файлами используется библиотека Newtonsoft.Json. Если вы не установили эту библиотеку, вы можете сделать это с помощью NuGet-пакета.


            ////Задание 32: Работа с XML
            //Написать программу, которая читает данные из XML-файла, обрабатывает их и
            //выводит на экран в формате таблицы.
            //using System;
            //using System.Data;

            //class XmlProcessor
            //{
            //    static void Main(string[] args)
            //    {
            //        string xmlFilePath = "data.xml";

            //        try
            //        {
            //            DataSet dataSet = new DataSet();
            //            dataSet.ReadXml(xmlFilePath);

            //            Console.WriteLine("Данные из XML-файла:");
            //            Console.WriteLine("------------------------");

            //            foreach (DataTable table in dataSet.Tables)
            //            {
            //                Console.WriteLine($"Таблица: {table.TableName}");

            //                foreach (DataColumn column in table.Columns)
            //                {
            //                    Console.Write($"| {column.ColumnName} |");
            //                }

            //                Console.WriteLine();

            //                foreach (DataRow row in table.Rows)
            //                {
            //                    foreach (object value in row.ItemArray)
            //                    {
            //                        Console.Write($"| {value} |");
            //                    }

            //                    Console.WriteLine();
            //                }

            //                Console.WriteLine();
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine("Ошибка чтения XML-файла: " + ex.Message);
            //        }
            //    }
            //}
            //Эта программа читает данные из XML-файла data.xml, который должен иметь следующий формат:

            //xml

            //Verify

            //Open In Editor
            //Edit
            //Copy code
            //<?xml version="1.0" encoding="utf-8"?>
            //<root>
            //  <table name="people">
            //    <row>
            //      <name>Иван</name>
            //      <age>25</age>
            //      <city>Москва</city>
            //    </row>
            //    <row>
            //      <name>Петр</name>
            //      <age>30</age>
            //      <city>Санкт-Петербург</city>
            //    </row>
            //    <row>
            //      <name>Сергей</name>
            //      <age>28</age>
            //      <city>Казань</city>
            //    </row>
            //  </table>
            //</root>
            //Программа читает XML-данные в набор данных DataSet и выводит их на экран в формате таблицы.

            //Примечание: Для работы с XML-файлами используется класс DataSet и метод ReadXml. [LINK_ID]

            ////Задание 33: Ведение списка дел
            //Разработать приложение для ведения списка дел. Пользователь может
            //добавлять, удалять и отмечать задачи как выполненные
            //using System;
            //using System.Collections.Generic;

            //class TodoList
            //{
            //    private List<TodoItem> _todoItems = new List<TodoItem>();

            //    public void Run()
            //    {
            //        while (true)
            //        {
            //            Console.WriteLine("Ведение списка дел:");
            //            Console.WriteLine("------------------------");
            //            Console.WriteLine("1. Добавить задачу");
            //            Console.WriteLine("2. Удалить задачу");
            //            Console.WriteLine("3. Отметить задачу как выполненную");
            //            Console.WriteLine("4. Показать список задач");
            //            Console.WriteLine("5. Выход");

            //            Console.Write("Выберите действие: ");
            //            int choice = Convert.ToInt32(Console.ReadLine());

            //            switch (choice)
            //            {
            //                case 1:
            //                    AddTodoItem();
            //                    break;
            //                case 2:
            //                    RemoveTodoItem();
            //                    break;
            //                case 3:
            //                    MarkTodoItemAsDone();
            //                    break;
            //                case 4:
            //                    ShowTodoList();
            //                    break;
            //                case 5:
            //                    return;
            //                default:
            //                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
            //                    break;
            //            }
            //        }
            //    }

            //    private void AddTodoItem()
            //    {
            //        Console.Write("Введите описание задачи: ");
            //        string description = Console.ReadLine();

            //        TodoItem todoItem = new TodoItem { Description = description, IsDone = false };
            //        _todoItems.Add(todoItem);

            //        Console.WriteLine("Задача добавлена.");
            //    }

            //    private void RemoveTodoItem()
            //    {
            //        Console.Write("Введите номер задачи для удаления: ");
            //        int index = Convert.ToInt32(Console.ReadLine()) - 1;

            //        if (index >= 0 && index < _todoItems.Count)
            //        {
            //            _todoItems.RemoveAt(index);
            //            Console.WriteLine("Задача удалена.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Неверный номер задачи.");
            //        }
            //    }

            //    private void MarkTodoItemAsDone()
            //    {
            //        Console.Write("Введите номер задачи для отметки как выполненной: ");
            //        int index = Convert.ToInt32(Console.ReadLine()) - 1;

            //        if (index >= 0 && index < _todoItems.Count)
            //        {
            //            _todoItems[index].IsDone = true;
            //            Console.WriteLine("Задача отмечена как выполненная.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Неверный номер задачи.");
            //        }
            //    }

            //    private void ShowTodoList()
            //    {
            //        Console.WriteLine("Список задач:");
            //        Console.WriteLine("------------------------");

            //        for (int i = 0; i < _todoItems.Count; i++)
            //        {
            //            TodoItem todoItem = _todoItems[i];
            //            string status = todoItem.IsDone ? "Выполнена" : "Не выполнена";

            //            Console.WriteLine($"{i + 1}. {todoItem.Description} - {status}");
            //        }
            //    }
            //}

            //public class TodoItem
            //{
            //    public string Description { get; set; }
            //    public bool IsDone { get; set; }
            //}

            //class Program
            //{
            //    static void Main(string[] args)
            //    {
            //        TodoList todoList = new TodoList();
            //        todoList.Run();
            //    }
            //}
            ////Задание 34: Работа с файлами
            //Создать программу, которая читает текст из файла и записывает его в другой
            //файл с изменением регистра букв (все строчные заменить на прописные и
            //наоборот)
            //using System;
            //using System.IO;

            //class FileProcessor
            //{
            //    public void Run()
            //    {
            //        Console.Write("Введите имя файла для чтения: ");
            //        string inputFileName = Console.ReadLine();

            //        Console.Write("Введите имя файла для записи: ");
            //        string outputFileName = Console.ReadLine();

            //        try
            //        {
            //            string text = File.ReadAllText(inputFileName);
            //            string modifiedText = ModifyText(text);

            //            File.WriteAllText(outputFileName, modifiedText);

            //            Console.WriteLine("Текст записан в файл.");
            //        }
            //        catch (FileNotFoundException)
            //        {
            //            Console.WriteLine("Файл для чтения не найден.");
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine("Ошибка: " + ex.Message);
            //        }
            //    }

            //    private string ModifyText(string text)
            //    {
            //        char[] chars = text.ToCharArray();

            //        for (int i = 0; i < chars.Length; i++)
            //        {
            //            if (char.IsLower(chars[i]))
            //            {
            //                chars[i] = char.ToUpper(chars[i]);
            //            }
            //            else if (char.IsUpper(chars[i]))
            //            {
            //                chars[i] = char.ToLower(chars[i]);
            //            }
            //        }

            //        return new string(chars);
            //    }
            //}

            //class Program
            //{
            //    static void Main(string[] args)
            //    {
            //        FileProcessor fileProcessor = new FileProcessor();
            //        fileProcessor.Run();
            //    }
            //}

            ////Задание 35: Календарь
            //Написать программу, которая выводит календарь на текущий месяц и позволяет
            //пользователю вводить заметки на каждый день

            //using System;
            //using System.Collections.Generic;

            //class Calendar
            //{
            //    private Dictionary<int, string> _notes = new Dictionary<int, string>();
            //    private int _year;
            //    private int _month;

            //    public Calendar(int year, int month)
            //    {
            //        _year = year;
            //        _month = month;
            //    }

            //    public void Run()
            //    {
            //        Console.WriteLine($"Календарь на {_month} {_year} год");

            //        int daysInMonth = DateTime.DaysInMonth(_year, _month);
            //        int firstDayOfWeek = (int)new DateTime(_year, _month, 1).DayOfWeek;

            //        Console.WriteLine("Пн Вт Ср Чт Пт Сб Вс");

            //        for (int i = 0; i < firstDayOfWeek; i++)
            //        {
            //            Console.Write("   ");
            //        }

            //        for (int i = 1; i <= daysInMonth; i++)
            //        {
            //            Console.Write($"{i,3} ");

            //            if ((i + firstDayOfWeek - 1) % 7 == 0)
            //            {
            //                Console.WriteLine();
            //            }
            //        }

            //        Console.WriteLine();

            //        for (int i = 1; i <= daysInMonth; i++)
            //        {
            //            Console.Write($"Введите заметку для {i} числа ({_notes.ContainsKey(i) ? "y/n" : ""}): ");
            //            string input = Console.ReadLine();

            //            if (input.ToLower() == "y")
            //            {
            //                Console.Write("Введите заметку: ");
            //                string note = Console.ReadLine();
            //                _notes[i] = note;
            //            }
            //            else if (input.ToLower() == "n" && _notes.ContainsKey(i))
            //            {
            //                _notes.Remove(i);
            //            }
            //        }

            //        Console.WriteLine("Заметки:");
            //        foreach (var note in _notes)
            //        {
            //            Console.WriteLine($"{note.Key} число: {note.Value}");
            //        }
            //    }
            //}

            //class Program
            //{
            //    static void Main(string[] args)
            //    {
            //        int year = DateTime.Now.Year;
            //        int month = DateTime.Now.Month;

            //        Calendar calendar = new Calendar(year, month);
            //        calendar.Run();
            //    }
            //}

            /////////////////////////////Задание 36: Учёт успеваемости студентовРазработать систему учета успеваемости студентов, которая хранит информацию о студентах и их оценках по предметам
            ////Создание студентов
            //Student Ira = new("Ирина");
            //Student Inna = new("Инна");
            //Student Ima = new("Имма");
            ////А почему они все на "И"? А где Ольга? :)

            ////Выставление начальных оценок по предметам
            //Ira.PutMark("C#", new int[] { 23, 15, 42 });
            //Ira.PutMark("Manual", 45);
            //Ira.PutMark("English", new int[] { 62, 65, 59, 52 });
            //Ira.PutMark("History", 54);

            //Inna.PutMark("C#", 36);
            //Inna.PutMark("Manual", new int[] { 28, 34 });
            //Inna.PutMark("English", 14);
            //Inna.PutMark("History", new int[] { 78, 61, 77 });

            //Ima.PutMark("C#", new int[] { 55, 52, 49 });
            //Ima.PutMark("Manual", 64);
            //Ima.PutMark("English", new int[] { 99, 100, 98 });
            //Ima.PutMark("History", 31);


            ////Запакуем всех студентов в массив
            //Student[] StArray = new Student[3] { Ira, Inna, Ima };

            ////Выведем на консоль
            //foreach (Student s in StArray)
            //{
            //    Console.WriteLine($"Имя студента: {s.Name}");
            //    Console.WriteLine("Оценки по предметам:");
            //    Console.WriteLine($"Максимальная оценка Ирины по Английскому: {Ira.GetMaxMark("English")}");

            //    for (int i = 0; i < s.Subj.Count; i++)
            //    {
            //        Console.Write($"{s.Subj[i].Theme}: ");
            //        foreach (int m in s.Subj[i].Mark)
            //            Console.Write(m + " ");
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}

            //Console.Read();
            //class Student
            //{
            //    public int GetMaxMark(string theme)
            //    {
            //        int res = 0;
            //        foreach (Subject s in Subj)
            //            if (theme == s.Theme)
            //                res = s.Mark.OrderByDescending(x => x).First();
            //        return res;
            //    }
            //    public string Name { get; private set; }
            //    public List<Subject> Subj { get; private set; }

            //    public Student(string name)
            //    {
            //        Name = name;
            //        Subj = new(4)
            //                {
            //                    new Subject( "C#" ),
            //                    new Subject( "Manual" ),
            //                    new Subject( "English" ),
            //                    new Subject( "History" )
            //                };
            //    }


            //    //Можно ставить одну оценку
            //    public void PutMark(string theme, int mark)
            //    {
            //        if (mark < 0 && mark > 100)
            //            throw new Exception("Оценка вне диапазона!");

            //        foreach (Subject s in Subj)
            //            if (theme == s.Theme)
            //                s.Mark.Add(mark);
            //    }


            //    //А можно ставить сразу несколько оценок
            //    public void PutMark(string theme, int[] mark)
            //    {
            //        foreach (int m in mark)
            //        {
            //            if (m < 0 && m > 100)
            //                throw new Exception("Оценка вне диапазона!");
            //            else
            //            {
            //                foreach (Subject s in Subj)
            //                    if (theme == s.Theme)
            //                        s.Mark.Add(m);
            //            }
            //        }
            //    }
            //}
            //class Subject
            //{
            //    public string Theme { get; set; }
            //    public List<int> Mark { get; set; }

            //    public Subject(string theme)
            //    {
            //        Theme = theme;
            //        Mark = new();
            //    }
            //}
            /////////////////////////////////////Задание 37: Книга контактовСоздать консольное приложение для хранения контактов (имя, телефон, email).Реализовать функции добавления, удаления, редактирования и поиска контактов
            //using System;
            //using System.Collections.Generic;

            //namespace ContactBook
            //{
            //    class Program
            //    {
            //        static List<Contact> contacts = new List<Contact>();

            //        static void Main(string[] args)
            //        {
            //            while (true)
            //            {
            //                Console.WriteLine("Contact Book");
            //                Console.WriteLine("1. Add contact");
            //                Console.WriteLine("2. Delete contact");
            //                Console.WriteLine("3. Edit contact");
            //                Console.WriteLine("4. Search contact");
            //                Console.WriteLine("5. Display all contacts");
            //                Console.WriteLine("6. Exit");
            //                Console.Write("Enter your choice: ");
            //                int choice = Convert.ToInt32(Console.ReadLine());

            //                switch (choice)
            //                {
            //                    case 1:
            //                        AddContact();
            //                        break;
            //                    case 2:
            //                        DeleteContact();
            //                        break;
            //                    case 3:
            //                        EditContact();
            //                        break;
            //                    case 4:
            //                        SearchContact();
            //                        break;
            //                    case 5:
            //                        DisplayAllContacts();
            //                        break;
            //                    case 6:
            //                        Environment.Exit(0);
            //                        break;
            //                    default:
            //                        Console.WriteLine("Invalid choice. Please try again.");
            //                        break;
            //                }
            //            }
            //        }

            //        static void AddContact()
            //        {
            //            Console.Write("Enter contact name: ");
            //            string name = Console.ReadLine();
            //            Console.Write("Enter contact phone: ");
            //            string phone = Console.ReadLine();
            //            Console.Write("Enter contact email: ");
            //            string email = Console.ReadLine();

            //            Contact contact = new Contact(name, phone, email);
            //            contacts.Add(contact);

            //            Console.WriteLine("Contact added successfully!");
            //        }

            //        static void DeleteContact()
            //        {
            //            Console.Write("Enter contact name: ");
            //            string name = Console.ReadLine();

            //            Contact contact = contacts.Find(c => c.Name == name);

            //            if (contact != null)
            //            {
            //                contacts.Remove(contact);
            //                Console.WriteLine("Contact deleted successfully!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Contact not found.");
            //            }
            //        }

            //        static void EditContact()
            //        {
            //            Console.Write("Enter contact name: ");
            //            string name = Console.ReadLine();

            //            Contact contact = contacts.Find(c => c.Name == name);

            //            if (contact != null)
            //            {
            //                Console.Write("Enter new contact name: ");
            //                string newName = Console.ReadLine();
            //                Console.Write("Enter new contact phone: ");
            //                string newPhone = Console.ReadLine();
            //                Console.Write("Enter new contact email: ");
            //                string newEmail = Console.ReadLine();

            //                contact.Name = newName;
            //                contact.Phone = newPhone;
            //                contact.Email = newEmail;

            //                Console.WriteLine("Contact edited successfully!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Contact not found.");
            //            }
            //        }

            //        static void SearchContact()
            //        {
            //            Console.Write("Enter contact name: ");
            //            string name = Console.ReadLine();

            //            Contact contact = contacts.Find(c => c.Name == name);

            //            if (contact != null)
            //            {
            //                Console.WriteLine("Contact found:");
            //                Console.WriteLine("Name: " + contact.Name);
            //                Console.WriteLine("Phone: " + contact.Phone);
            //                Console.WriteLine("Email: " + contact.Email);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Contact not found.");
            //            }
            //        }

            //        static void DisplayAllContacts()
            //        {
            //            if (contacts.Count > 0)
            //            {
            //                Console.WriteLine("All contacts:");
            //                foreach (Contact contact in contacts)
            //                {
            //                    Console.WriteLine("Name: " + contact.Name);
            //                    Console.WriteLine("Phone: " + contact.Phone);
            //                    Console.WriteLine("Email: " + contact.Email);
            //                    Console.WriteLine();
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("No contacts found.");
            //            }
            //        }
            //    }

            //    public class Contact
            //    {
            //        public string Name { get; set; }
            //        public string Phone { get; set; }
            //        public string Email { get; set; }

            //        public Contact(string name, string phone, string email)
            //        {
            //            Name = name;
            //            Phone = phone;
            //            Email = email;
            //        }
            //    }
            //}
            ///////////////////////////////////////////////////////////Задание 38: Игра "Крестики-нолики"Разработать консольное приложение для игры в "Крестики-нолики" для двух игроков.
            //using System;

            //namespace TicTacToe
            //{
            //    class Program
            //    {
            //        static char[,] board = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
            //        static char player1 = 'X';
            //        static char player2 = 'O';
            //        static bool isPlayer1Turn = true;

            //        static void Main(string[] args)
            //        {
            //            while (true)
            //            {
            //                DrawBoard();
            //                MakeMove();
            //                if (CheckForWin())
            //                {
            //                    DrawBoard();
            //                    Console.WriteLine("Игра окончена!");
            //                    break;
            //                }
            //                SwitchPlayer();
            //            }
            //        }

            //        static void DrawBoard()
            //        {
            //            Console.Clear();
            //            Console.WriteLine(" " + board[0, 0] + " | " + board[0, 1] + " | " + board[0, 2]);
            //            Console.WriteLine("---+---+---");
            //            Console.WriteLine(" " + board[1, 0] + " | " + board[1, 1] + " | " + board[1, 2]);
            //            Console.WriteLine("---+---+---");
            //            Console.WriteLine(" " + board[2, 0] + " | " + board[2, 1] + " | " + board[2, 2]);
            //        }

            //        static void MakeMove()
            //        {
            //            Console.Write("Игрок " + (isPlayer1Turn ? "1 (X)" : "2 (O)") + ", введите номер клетки: ");
            //            int move = Convert.ToInt32(Console.ReadLine());
            //            int row = (move - 1) / 3;
            //            int col = (move - 1) % 3;
            //            if (board[row, col] != 'X' && board[row, col] != 'O')
            //            {
            //                board[row, col] = isPlayer1Turn ? player1 : player2;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Клетка уже занята!");
            //                MakeMove();
            //            }
            //        }

            //        static bool CheckForWin()
            //        {
            //            // Проверка строк
            //            for (int i = 0; i < 3; i++)
            //            {
            //                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && (board[i, 0] == player1 || board[i, 0] == player2))
            //                {
            //                    return true;
            //                }
            //            }
            //            // Проверка столбцов
            //            for (int i = 0; i < 3; i++)
            //            {
            //                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && (board[0, i] == player1 || board[0, i] == player2))
            //                {
            //                    return true;
            //                }
            //            }
            //            // Проверка диагоналей
            //            if ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && (board[0, 0] == player1 || board[0, 0] == player2)) ||
            //                (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && (board[0, 2] == player1 || board[0, 2] == player2)))
            //            {
            //                return true;
            //            }
            //            return false;
            //        }

            //        static void SwitchPlayer()
            //        {
            //            isPlayer1Turn = !isPlayer1Turn;
            //        }
            //    }
            //}
            ////////////////////////////Задание 39: Игра "Быки и коровы"Создать игру "Быки и коровы", где игрок должен угадать загаданное программой четырехзначное число
            //using System;

            //namespace BullsAndCows
            //{
            //    class Program
            //    {
            //        static Random random = new Random();
            //        static int secretNumber;
            //        static int attempts = 0;

            //        static void Main(string[] args)
            //        {
            //            GenerateSecretNumber();
            //            while (true)
            //            {
            //                Console.Write("Enter your four-digit number: ");
            //                int guess = Convert.ToInt32(Console.ReadLine());
            //                if (guess < 1000 || guess > 9999)
            //                {
            //                    Console.WriteLine("Invalid input. Please enter a four-digit number.");
            //                    continue;
            //                }
            //                attempts++;
            //                int bulls = GetBulls(guess);
            //                int cows = GetCows(guess);
            //                Console.WriteLine($"Bulls: {bulls}, Cows: {cows}");
            //                if (bulls == 4)
            //                {
            //                    Console.WriteLine("Congratulations! You won!");
            //                    Console.WriteLine($"Attempts: {attempts}");
            //                    break;
            //                }
            //            }
            //        }

            //        static void GenerateSecretNumber()
            //        {
            //            secretNumber = random.Next(1000, 10000);
            //        }

            //        static int GetBulls(int guess)
            //        {
            //            int bulls = 0;
            //            for (int i = 0; i < 4; i++)
            //            {
            //                if (GetDigit(secretNumber, i) == GetDigit(guess, i))
            //                {
            //                    bulls++;
            //                }
            //            }
            //            return bulls;
            //        }

            //        static int GetCows(int guess)
            //        {
            //            int cows = 0;
            //            for (int i = 0; i < 4; i++)
            //            {
            //                for (int j = 0; j < 4; j++)
            //                {
            //                    if (i != j && GetDigit(secretNumber, i) == GetDigit(guess, j))
            //                    {
            //                        cows++;
            //                    }
            //                }
            //            }
            //            return cows;
            //        }

            //        static int GetDigit(int number, int digit)
            //        {
            //            return (number / (int)Math.Pow(10, 3 - digit)) % 10;
            //        }
            //    }
            //}
            //////////////////////////Задание 40: Симуляция банкомата Написать программу, которая симулирует работу банкомата: внесение средств, снятие средств, просмотр баланса.
            //using System;

            //namespace ATM
            //{
            //    class Program
            //    {
            //        static decimal balance = 1000; // initial balance

            //        static void Main(string[] args)
            //        {
            //            while (true)
            //            {
            //                Console.WriteLine("Банкомат");
            //                Console.WriteLine("---------");
            //                Console.WriteLine("1. Внести средства");
            //                Console.WriteLine("2. Снять средства");
            //                Console.WriteLine("3. Просмотреть баланс");
            //                Console.WriteLine("4. Выход");
            //                Console.Write("Выберите операцию: ");
            //                int choice = Convert.ToInt32(Console.ReadLine());
            //                switch (choice)
            //                {
            //                    case 1:
            //                        Deposit();
            //                        break;
            //                    case 2:
            //                        Withdraw();
            //                        break;
            //                    case 3:
            //                        CheckBalance();
            //                        break;
            //                    case 4:
            //                        Environment.Exit(0);
            //                        break;
            //                    default:
            //                        Console.WriteLine("Неправильный выбор. Попробуйте еще раз.");
            //                        break;
            //                }
            //            }
            //        }

            //        static void Deposit()
            //        {
            //            Console.Write("Введите сумму для внесения: ");
            //            decimal amount = Convert.ToDecimal(Console.ReadLine());
            //            if (amount > 0)
            //            {
            //                balance += amount;
            //                Console.WriteLine($"Средства внесены успешно. Новый баланс: {balance}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Неправильная сумма. Попробуйте еще раз.");
            //            }
            //        }

            //        static void Withdraw()
            //        {
            //            Console.Write("Введите сумму для снятия: ");
            //            decimal amount = Convert.ToDecimal(Console.ReadLine());
            //            if (amount > 0 && amount <= balance)
            //            {
            //                balance -= amount;
            //                Console.WriteLine($"Средства сняты успешно. Новый баланс: {balance}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Неправильная сумма или недостаточно средств. Попробуйте еще раз.");
            //            }
            //        }

            //        static void CheckBalance()
            //        {
            //            Console.WriteLine($"Текущий баланс: {balance}");
            //        }
            //    }
            //}
            /////////////////////////////////////Задание 41: Парсинг CSV-файловСоздать программу, которая читает данные из CSV-файла и выводит их в формате таблицы.
            //using System;
            //using System.IO;
            //using System.Linq;

            //namespace CSVParser
            //{
            //    class Program
            //    {
            //        static void Main(string[] args)
            //        {
            //            Console.Write("Enter the path to the CSV file: ");
            //            string filePath = Console.ReadLine();
            //            if (File.Exists(filePath))
            //            {
            //                string[] lines = File.ReadAllLines(filePath);
            //                string[] headers = lines[0].Split(',');
            //                Console.WriteLine(new string('-', headers.Length * 10));
            //                Console.WriteLine(string.Join(" | ", headers));
            //                Console.WriteLine(new string('-', headers.Length * 10));
            //                for (int i = 1; i < lines.Length; i++)
            //                {
            //                    string[] values = lines[i].Split(',');
            //                    Console.WriteLine(string.Join(" | ", values));
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("File not found.");
            //            }
            //        }
            //    }
            //}
            //////////////////////////////Задание 42: Калькулятор средней температуры Разработать приложение, которое вычисляет среднюю температуру за неделю по введенным пользователем данным.
            //using System;

            //namespace TemperatureCalculator
            //{
            //    class Program
            //    {
            //        static void Main(string[] args)
            //        {
            //            decimal[] temperatures = new decimal[7];

            //            Console.WriteLine("Введите температуры за неделю:");
            //            for (int i = 0; i < 7; i++)
            //            {
            //                Console.Write($"День {i + 1}: ");
            //                temperatures[i] = Convert.ToDecimal(Console.ReadLine());
            //            }

            //            decimal averageTemperature = CalculateAverageTemperature(temperatures);

            //            Console.WriteLine($"Средняя температура за неделю: {averageTemperature:F2}°C");
            //        }

            //        static decimal CalculateAverageTemperature(decimal[] temperatures)
            //        {
            //            decimal sum = 0;
            //            foreach (decimal temperature in temperatures)
            //            {
            //                sum += temperature;
            //            }
            //            return sum / temperatures.Length;
            //        }
            //    }
            //}
            /////////////////////////////Задание 43:Игра "Змейка"Написать консольное приложение, которое симулирует игру "Змейка". Змейка должна двигаться по экрану и увеличиваться при "съедании" пищи
            //using System;
            //using System.Collections.Generic;

            //namespace SnakeGame
            //{
            //    class Program
            //    {
            //        static void Main(string[] args)
            //        {
            //            const int width = 20;
            //            const int height = 20;
            //            const char snakeSymbol = '*';
            //            const char foodSymbol = '#';

            //            Random random = new Random();
            //            List<(int, int)> snake = new List<(int, int)>() { (0, 0) };
            //            (int, int) food = (random.Next(width), random.Next(height));
            //            (int, int) direction = (1, 0);

            //            while (true)
            //            {
            //                Console.Clear();
            //                DrawGameBoard(width, height, snake, food, snakeSymbol, foodSymbol);

            //                if (Console.KeyAvailable)
            //                {
            //                    ConsoleKeyInfo key = Console.ReadKey(true);
            //                    switch (key.Key)
            //                    {
            //                        case ConsoleKey.UpArrow:
            //                            direction = (0, -1);
            //                            break;
            //                        case ConsoleKey.DownArrow:
            //                            direction = (0, 1);
            //                            break;
            //                        case ConsoleKey.LeftArrow:
            //                            direction = (-1, 0);
            //                            break;
            //                        case ConsoleKey.RightArrow:
            //                            direction = (1, 0);
            //                            break;
            //                    }
            //                }

            //                (int, int) newHead = (snake[0].Item1 + direction.Item1, snake[0].Item2 + direction.Item2);
            //                snake.Insert(0, newHead);

            //                if (newHead == food)
            //                {
            //                    food = (random.Next(width), random.Next(height));
            //                }
            //                else
            //                {
            //                    snake.RemoveAt(snake.Count - 1);
            //                }

            //                if (IsCollision(snake, width, height))
            //                {
            //                    Console.WriteLine("Game over!");
            //                    break;
            //                }

            //                System.Threading.Thread.Sleep(100);
            //            }
            //        }

            //        static void DrawGameBoard(int width, int height, List<(int, int)> snake, (int, int) food, char snakeSymbol, char foodSymbol)
            //        {
            //            for (int y = 0; y < height; y++)
            //            {
            //                for (int x = 0; x < width; x++)
            //                {
            //                    if (snake.Contains((x, y)))
            //                    {
            //                        Console.Write(snakeSymbol);
            //                    }
            //                    else if ((x, y) == food)
            //                    {
            //                        Console.Write(foodSymbol);
            //                    }
            //                    else
            //                    {
            //                        Console.Write(' ');
            //                    }
            //                }
            //                Console.WriteLine();
            //            }
            //        }

            //        static bool IsCollision(List<(int, int)> snake, int width, int height)
            //        {
            //            (int, int) head = snake[0];
            //            if (head.Item1 < 0 || head.Item1 >= width || head.Item2 < 0 || head.Item2 >= height)
            //            {
            //                return true;
            //            }
            //            for (int i = 1; i < snake.Count; i++)
            //            {
            //                if (snake[i] == head)
            //                {
            //                    return true;
            //                }
            //            }
            //            return false;
            //        }
            //    }
            //}
            /////////////////////////////Задание 44: Автоматический контроль версий Создать программу, которая отслеживает изменения в текстовых файлах в указанной директории и автоматически сохраняет копии изменений с отметкой времени
            //using System;
            //using System.IO;
            //using System.Linq;

            //namespace VersionControl
            //{
            //    class Program
            //    {
            //        static void Main(string[] args)
            //        {
            //            Console.Write("Enter the directory path: ");
            //            string directoryPath = Console.ReadLine();

            //            if (!Directory.Exists(directoryPath))
            //            {
            //                Console.WriteLine("Directory not found.");
            //                return;
            //            }

            //            Console.WriteLine("Version control started. Press any key to stop.");
            //            Console.WriteLine("------------------------------------------------");

            //            FileSystemWatcher watcher = new FileSystemWatcher(directoryPath);
            //            watcher.NotifyFilter = NotifyFilters.LastWrite;
            //            watcher.Filter = "*.txt";
            //            watcher.Changed += OnChanged;
            //            watcher.EnableRaisingEvents = true;

            //            Console.ReadKey();

            //            watcher.EnableRaisingEvents = false;
            //            watcher.Dispose();
            //        }

            //        static void OnChanged(object source, FileSystemEventArgs e)
            //        {
            //            string filePath = e.FullPath;
            //            string fileContent = File.ReadAllText(filePath);
            //            string backupPath = GetBackupPath(filePath);

            //            File.WriteAllText(backupPath, fileContent);

            //            Console.WriteLine($"Backup created: {backupPath}");
            //        }

            //        static string GetBackupPath(string filePath)
            //        {
            //            string fileName = Path.GetFileName(filePath);
            //            string directoryPath = Path.GetDirectoryName(filePath);
            //            string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            //            string backupFileName = $"{fileName}_{timestamp}";
            //            string backupPath = Path.Combine(directoryPath, backupFileName);

            //            return backupPath;
            //        }
            //    }
            //}
            /////////////////////////////Задание 45:Генерация отчетов Написать программу, которая генерирует отчет в текстовом формате на основе введенных пользователем данных (например, отчет по продажам, отчет по выполнению задач и т.д.).
            //using System;
            //using System.Collections.Generic;

            //namespace ReportGenerator
            //{
            //    class Program
            //    {
            //        static void Main(string[] args)
            //        {
            //            Console.WriteLine("Report Generator");
            //            Console.WriteLine("---------------");

            //            Console.Write("Enter report type (Sales, Tasks, etc.): ");
            //            string reportType = Console.ReadLine();

            //            Console.Write("Enter report title: ");
            //            string reportTitle = Console.ReadLine();

            //            List<ReportItem> reportItems = new List<ReportItem>();

            //            while (true)
            //            {
            //                Console.Write("Enter item name (or 'done' to finish): ");
            //                string itemName = Console.ReadLine();

            //                if (itemName.ToLower() == "done")
            //                {
            //                    break;
            //                }

            //                Console.Write("Enter item value: ");
            //                string itemValue = Console.ReadLine();

            //                reportItems.Add(new ReportItem(itemName, itemValue));
            //            }

            //            GenerateReport(reportType, reportTitle, reportItems);
            //        }

            //        static void GenerateReport(string reportType, string reportTitle, List<ReportItem> reportItems)
            //        {
            //            string report = $"** {reportType} Report **\n";
            //            report += $"** {reportTitle} **\n";
            //            report += "---------------------\n";

            //            foreach (ReportItem item in reportItems)
            //            {
            //                report += $"{item.Name}: {item.Value}\n";
            //            }

            //            Console.WriteLine(report);
            //        }
            //    }

            //    class ReportItem
            //    {
            //        public string Name { get; set; }
            //        public string Value { get; set; }

            //        public ReportItem(string name, string value)
            //        {
            //            Name = name;
            //            Value = value;
            //        }
            //    }
            //}
            ////////////////////////////Задание 46: Учет посетителей мероприятия Создать приложение для учета посетителей мероприятия. Программа должна позволять добавлять посетителей, отмечать их присутствие и выводить список всех посетителей
            //using System;
            //using System.Collections.Generic;

            //namespace EventAttendanceTracker
            //{
            //    class Program
            //    {
            //        static List<Attendee> attendees = new List<Attendee>();

            //        static void Main(string[] args)
            //        {
            //            Console.WriteLine("Event Attendance Tracker");
            //            Console.WriteLine("---------------------");

            //            while (true)
            //            {
            //                Console.WriteLine("Menu:");
            //                Console.WriteLine("1. Add attendee");
            //                Console.WriteLine("2. Mark attendance");
            //                Console.WriteLine("3. View attendees");
            //                Console.WriteLine("4. Exit");

            //                Console.Write("Enter your choice: ");
            //                int choice = Convert.ToInt32(Console.ReadLine());

            //                switch (choice)
            //                {
            //                    case 1:
            //                        AddAttendee();
            //                        break;
            //                    case 2:
            //                        MarkAttendance();
            //                        break;
            //                    case 3:
            //                        ViewAttendees();
            //                        break;
            //                    case 4:
            //                        return;
            //                    default:
            //                        Console.WriteLine("Invalid choice. Please try again.");
            //                        break;
            //                }
            //            }
            //        }

            //        static void AddAttendee()
            //        {
            //            Console.Write("Enter attendee name: ");
            //            string name = Console.ReadLine();

            //            Console.Write("Enter attendee email: ");
            //            string email = Console.ReadLine();

            //            Attendee attendee = new Attendee(name, email);
            //            attendees.Add(attendee);

            //            Console.WriteLine("Attendee added successfully.");
            //        }

            //        static void MarkAttendance()
            //        {
            //            Console.Write("Enter attendee email: ");
            //            string email = Console.ReadLine();

            //            Attendee attendee = attendees.Find(a => a.Email == email);

            //            if (attendee != null)
            //            {
            //                attendee.IsPresent = true;
            //                Console.WriteLine("Attendance marked successfully.");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Attendee not found.");
            //            }
            //        }

            //        static void ViewAttendees()
            //        {
            //            Console.WriteLine("Attendees:");
            //            Console.WriteLine("---------");

            //            foreach (Attendee attendee in attendees)
            //            {
            //                Console.WriteLine($"{attendee.Name} ({attendee.Email}) - {(attendee.IsPresent ? "Present" : "Absent")}");
            //            }
            //        }
            //    }

            //    class Attendee
            //    {
            //        public string Name { get; set; }
            //        public string Email { get; set; }
            //        public bool IsPresent { get; set; }

            //        public Attendee(string name, string email)
            //        {
            //            Name = name;
            //            Email = email;
            //            IsPresent = false;
            //        }
            //    }
            //}
            //////////////////////Задание 47: Планировщик задач Разработать программу, которая позволяет пользователю создавать задачи,задавать для них время выполнения и уведомляет о наступлении времени выполнения задачи
            //using System;
            //using System.Collections.Generic;
            //using System.Threading;

            //namespace TaskScheduler
            //{
            //    class Program
            //    {
            //        // Список задач
            //        static List<Task> tasks = new List<Task>();

            //        static void Main(string[] args)
            //        {
            //            Console.WriteLine("Планировщик задач");
            //            Console.WriteLine("-------------");

            //            while (true)
            //            {
            //                Console.WriteLine("Меню:");
            //                Console.WriteLine("1. Создать задачу");
            //                Console.WriteLine("2. Просмотреть задачи");
            //                Console.WriteLine("3. Выход");

            //                Console.Write("Введите ваш выбор: ");
            //                int choice = Convert.ToInt32(Console.ReadLine());

            //                switch (choice)
            //                {
            //                    case 1:
            //                        CreateTask();
            //                        break;
            //                    case 2:
            //                        ViewTasks();
            //                        break;
            //                    case 3:
            //                        return;
            //                    default:
            //                        Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте снова.");
            //                        break;
            //                }

            //                // Проверяем задачи на предмет наступления времени выполнения
            //                CheckTasks();
            //            }
            //        }

            //        // Создаем новую задачу
            //        static void CreateTask()
            //        {
            //            Console.Write("Введите имя задачи: ");
            //            string name = Console.ReadLine();

            //            Console.Write("Введите время выполнения задачи (HH:mm): ");
            //            string time = Console.ReadLine();

            //            Task task = new Task(name, time);
            //            tasks.Add(task);

            //            Console.WriteLine("Задача создана успешно.");
            //        }

            //        // Просматриваем список задач
            //        static void ViewTasks()
            //        {
            //            Console.WriteLine("Задачи:");
            //            Console.WriteLine("------");

            //            foreach (Task task in tasks)
            //            {
            //                Console.WriteLine($"{task.Name} - {task.Time}");
            //            }
            //        }

            //        // Проверяем задачи на предмет наступления времени выполнения
            //        static void CheckTasks()
            //        {
            //            foreach (Task task in tasks)
            //            {
            //                if (task.Time == DateTime.Now.ToString("HH:mm"))
            //                {
            //                    Console.WriteLine($"Задача '{task.Name}' должна быть выполнена сейчас!");
            //                    Thread.Sleep(1000); // Пауза на 1 секунду, чтобы избежать множественных уведомлений
            //                }
            //            }
            //        }
            //    }

            //    // Класс задачи
            //    class Task
            //    {
            //        public string Name { get; set; }
            //        public string Time { get; set; }

            //        public Task(string name, string time)
            //        {
            //            Name = name;
            //            Time = time;
            //        }
            //    }
            //}
            ///////////////////////////////////Задание 48: Анализ продаж Написать приложение, которое анализирует данные о продажах и выводит статистику по проданным товарам (общая сумма продаж, количество проданных единиц каждого товара и т.д.)
            //using System;
            //using System.Collections.Generic;
            //using System.Linq;

            //namespace SalesAnalyzer
            //{
            //    class Program
            //    {
            //        static void Main(string[] args)
            //        {
            //            Console.WriteLine("Анализатор продаж");
            //            Console.WriteLine("-------------");

            //            // Пример данных о продажах
            //            List<Sale> sales = new List<Sale>
            //            {
            //                new Sale { ProductName = "Продукт А", Quantity = 2, Price = 10.99m },
            //                new Sale { ProductName = "Продукт Б", Quantity = 3, Price = 5.99m },
            //                new Sale { ProductName = "Продукт А", Quantity = 1, Price = 10.99m },
            //                new Sale { ProductName = "Продукт В", Quantity = 2, Price = 7.99m },
            //                new Sale { ProductName = "Продукт Б", Quantity = 2, Price = 5.99m },
            //            };

            //            // Анализ данных о продажах
            //            AnalyzeSales(sales);

            //            Console.ReadLine();
            //        }

            //        static void AnalyzeSales(List<Sale> sales)
            //        {
            //            // Расчет общей суммы продаж
            //            decimal totalSalesAmount = sales.Sum(s => s.Quantity * s.Price);

            //            // Расчет общего количества каждого товара
            //            var productQuantities = sales
            //                .GroupBy(s => s.ProductName)
            //                .Select(g => new { ProductName = g.Key, Quantity = g.Sum(s => s.Quantity) });

            //            // Вывод статистики
            //            Console.WriteLine("Статистика:");
            //            Console.WriteLine("-----------");
            //            Console.WriteLine($"Общая сумма продаж: {totalSalesAmount:C}");
            //            Console.WriteLine("Количество товаров:");
            //            foreach (var productQuantity in productQuantities)
            //            {
            //                Console.WriteLine($"{productQuantity.ProductName}: {productQuantity.Quantity} единиц");
            //            }
            //        }
            //    }

            //    class Sale
            //    {
            //        public string ProductName { get; set; }
            //        public int Quantity { get; set; }
            //        public decimal Price { get; set; }
            //    }
            //}
            /////////////////////////////////Задание 49: Игра "Виселица" Создать консольное приложение, которое симулирует игру "Виселица". Пользователь должен угадывать загаданное слово по буквам
            //using System;
            //using System.Collections.Generic;

            //namespace HangmanGame
            //{
            //    class Program
            //    {
            //        static void Main(string[] args)
            //        {
            //            Console.WriteLine("Игра Виселица");
            //            Console.WriteLine("------------");

            //            // Ask the user to input the secret word
            //            Console.WriteLine("Введите загаданное слово:");
            //            string secretWord = Console.ReadLine();

            //            // Количество ошибок
            //            int mistakes = 0;

            //            // Список угаданных букв
            //            List<char> guessedLetters = new List<char>();

            //            // Игра продолжается, пока не будет угадано слово или не будет превышено количество ошибок
            //            while (true)
            //            {
            //                Console.WriteLine("Угадайте букву:");
            //                char letter = Console.ReadLine()[0];

            //                // Проверка, была ли буква уже угадана
            //                if (guessedLetters.Contains(letter))
            //                {
            //                    Console.WriteLine("Вы уже угадали эту букву!");
            //                    continue;
            //                }

            //                // Добавление буквы к списку угаданных букв
            //                guessedLetters.Add(letter);

            //                // Проверка, есть ли буква в загаданном слове
            //                if (secretWord.Contains(letter))
            //                {
            //                    Console.WriteLine("Буква есть в слове!");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Буквы нет в слове!");
            //                    mistakes++;
            //                }

            //                // Вывод текущего состояния игры
            //                Console.WriteLine("Текущее состояние:");
            //                bool won = true;
            //                foreach (char c in secretWord)
            //                {
            //                    if (guessedLetters.Contains(c))
            //                    {
            //                        Console.Write(c + " ");
            //                    }
            //                    else
            //                    {
            //                        Console.Write("_ ");
            //                        won = false;
            //                    }
            //                }
            //                Console.WriteLine();

            //                // Вывод виселицы
            //                Console.WriteLine("Виселица:");
            //                switch (mistakes)
            //                {
            //                    case 0:
            //                        Console.WriteLine("   _____");
            //                        break;
            //                    case 1:
            //                        Console.WriteLine("   _____");
            //                        Console.WriteLine("  /     |");
            //                        break;
            //                    case 2:
            //                        Console.WriteLine("   _____");
            //                        Console.WriteLine("  /     |");
            //                        Console.WriteLine(" /      |");
            //                        break;
            //                    case 3:
            //                        Console.WriteLine("   _____");
            //                        Console.WriteLine("  /     |");
            //                        Console.WriteLine(" /      |");
            //                        Console.WriteLine("|       |");
            //                        break;
            //                    case 4:
            //                        Console.WriteLine("   _____");
            //                        Console.WriteLine("  /     |");
            //                        Console.WriteLine(" /      |");
            //                        Console.WriteLine("|       |");
            //                        Console.WriteLine("|       O");
            //                        break;
            //                    case 5:
            //                        Console.WriteLine("   _____");
            //                        Console.WriteLine("  /     |");
            //                        Console.WriteLine(" /      |");
            //                        Console.WriteLine("|       |");
            //                        Console.WriteLine("|       O");
            //                        Console.WriteLine("|      /");
            //                        break;
            //                    case 6:
            //                        Console.WriteLine("   _____");
            //                        Console.WriteLine("  /     |");
            //                        Console.WriteLine(" /      |");
            //                        Console.WriteLine("|       |");
            //                        Console.WriteLine("|       O");
            //                        Console.WriteLine("|      /|");
            //                        break;
            //                }

            //                // Проверка, было ли угадано слово
            //                if (won)
            //                {
            //                    Console.WriteLine("Вы угадали слово!");
            //                    break;
            //                }

            //                // Проверка, не было ли превышено количество ошибок
            //                if (mistakes == 6)
            //                {
            //                    Console.WriteLine("Вы проиграли! Загаданное слово было: " + secretWord);
            //                    break;
            //                }
            //            }

            //            Console.ReadLine();
            //        }
            //    }
            //}
            //////////////////////////////////////Задание 50: Система опросов Разработать систему опросов, которая позволяет создавать опросы, добавлять в них вопросы и варианты ответов, а затем собирать и анализировать ответы пользователей
            //Survey survey = new Survey("Мой Опрос");

            //Question question1 = new Question("Какой ваш любимый цвет?", survey);
            //question1.AddOption(new Option("Красный"));
            //question1.AddOption(new Option("Синий"));
            //question1.AddOption(new Option("Зеленый"));
            //survey.AddQuestion(question1);

            //Question question2 = new Question("Сколько вам лет?", survey);
            //question2.AddOption(new Option("18-24"));
            //question2.AddOption(new Option("25-34"));
            //question2.AddOption(new Option("35-44"));
            //survey.AddQuestion(question2);

            //survey.DisplaySurvey();
            //survey.CollectAnswers();
            //survey.AnalyzeAnswers();
            //public class Survey
            //{
            //    // Заголовок опроса
            //    public string Title { get; set; }
            //    // Список вопросов в опросе
            //    public List<Question> Questions { get; set; }

            //    public Survey(string title)
            //    {
            //        Title = title;
            //        Questions = new List<Question>();
            //    }

            //    // Добавление вопроса в опрос
            //    public void AddQuestion(Question question)
            //    {
            //        Questions.Add(question);
            //    }

            //    // Отображение опроса
            //    public void DisplaySurvey()
            //    {
            //        Console.WriteLine($"Опрос: {Title}");
            //        foreach (var question in Questions)
            //        {
            //            question.DisplayQuestion();
            //        }
            //    }

            //    // Сбор ответов пользователей
            //    public void CollectAnswers()
            //    {
            //        foreach (var question in Questions)
            //        {
            //            question.CollectAnswer();
            //        }
            //    }

            //    // Анализ ответов пользователей
            //    public void AnalyzeAnswers()
            //    {
            //        foreach (var question in Questions)
            //        {
            //            question.AnalyzeAnswer();
            //        }
            //    }
            //}

            //public class Question
            //{
            //    // Текст вопроса
            //    public string Text { get; set; }
            //    // Список вариантов ответов
            //    public List<Option> Options { get; set; }
            //    // Выбранный вариант ответа
            //    public Option SelectedOption { get; set; }
            //    public Survey Survey { get; set; }

            //    public Question(string text, Survey survey)
            //    {
            //        Text = text;
            //        Options = new List<Option>();
            //        Survey = survey;
            //    }

            //    // Добавление варианта ответа
            //    public void AddOption(Option option)
            //    {
            //        Options.Add(option);
            //    }

            //    // Отображение вопроса
            //    public void DisplayQuestion()
            //    {
            //        Console.WriteLine($"Вопрос: {Text}");
            //        foreach (var option in Options)
            //        {
            //            Console.WriteLine($"  {option.Text}");
            //        }
            //    }

            //    // Сбор ответа пользователя
            //    public void CollectAnswer()
            //    {
            //        Console.Write("Введите ваш ответ: ");
            //        string answer = Console.ReadLine();
            //        foreach (var option in Options)
            //        {
            //            if (option.Text == answer)
            //            {
            //                SelectedOption = option;
            //                break;
            //            }
            //        }
            //        if (SelectedOption == null)
            //        {
            //            Console.WriteLine("Неверный ответ. Пожалуйста, выберите один из вариантов.");
            //        }
            //    }

            //    // Анализ ответа
            //    public void AnalyzeAnswer()
            //    {
            //        if (SelectedOption != null)
            //        {
            //            Console.WriteLine($"Ответ: {SelectedOption.Text}");
            //            // Дополнительная логика анализа может быть добавлена здесь
            //            foreach (var option in Options)
            //            {
            //                int count = 0;
            //                foreach (var question in Survey.Questions)
            //                {
            //                    if (question.SelectedOption == option)
            //                    {
            //                        count++;
            //                    }
            //                }
            //                Console.WriteLine($"Вариант '{option.Text}' был выбран {count} раз(а).");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Нет ответа.");
            //        }
            //    }
            //}

            //public class Option
            //{
            //    // Текст варианта ответа
            //    public string Text { get; set; }

            //    public Option(string text)
            //    {
            //        Text = text;
            //    }
            //}
            /////////////////////////////////////////Задание 51: Анализ погодных данных Создать программу, которая анализирует исторические данные о погоде (например, из CSV-файла) и выводит статистику по месяцам (средняя температура, количество осадков и т.д.)
            //using System;
            //using System.Collections.Generic;
            //using System.IO;
            //using System.Linq;

            //namespace WeatherDataAnalyzer
            //{
            //    class Program
            //    {
            //        static void Main(string[] args)
            //        {
            //            // Загрузка данных о погоде из CSV-файла
            //            string[] lines = File.ReadAllLines("weather_data.csv");
            //            List<WeatherData> weatherDataList = new List<WeatherData>();
            //            foreach (string line in lines.Skip(1)) // пропустить строку заголовка
            //            {
            //                string[] columns = line.Split(',');
            //                WeatherData weatherData = new WeatherData
            //                {
            //                    Date = DateTime.Parse(columns[0]),
            //                    Temperature = double.Parse(columns[1]),
            //                    Precipitation = double.Parse(columns[2]),
            //                    // добавить больше столбцов, если необходимо
            //                };
            //                weatherDataList.Add(weatherData);
            //            }

            //            // Группировка данных по месяцам
            //            var monthlyData = weatherDataList.GroupBy(x => x.Date.Month);

            //            // Расчёт статистики для каждого месяца
            //            foreach (var monthGroup in monthlyData)
            //            {
            //                int month = monthGroup.Key;
            //                double avgTemperature = monthGroup.Average(x => x.Temperature);
            //                double totalPrecipitation = monthGroup.Sum(x => x.Precipitation);
            //                // добавить больше статистики, если необходимо

            //                Console.WriteLine($"Месяц {month}:");
            //                Console.WriteLine($"  Средняя температура: {avgTemperature:F2}°C");
            //                Console.WriteLine($"  Общий объём осадков: {totalPrecipitation:F2} мм");
            //                // добавить больше статистики, если необходимо
            //                Console.WriteLine();
            //            }
            //        }
            //    }

            //    class WeatherData
            //    {
            //        public DateTime Date { get; set; }
            //        public double Temperature { get; set; }
            //        public double Precipitation { get; set; }
            //        // добавить больше свойств, если необходимо
            //    }
            //}
            ////////////////////Задание 52: Система учета книг в библиотеке Разработать консольное приложение для учета книг в библиотеке. Реализовать функции добавления, удаления, редактирования и поиска книг, а также возможность вывода списка всех книг
            //using System;
            //using System.Collections.Generic;

            //namespace LibraryBookManagement
            //{
            //    class Program
            //    {
            //        // Список книг в библиотеке
            //        static List<Book> bookList = new List<Book>();

            //        static void Main(string[] args)
            //        {
            //            while (true)
            //            {
            //                Console.WriteLine("Система учета книг в библиотеке");
            //                Console.WriteLine("1. Добавить книгу");
            //                Console.WriteLine("2. Удалить книгу");
            //                Console.WriteLine("3. Редактировать книгу");
            //                Console.WriteLine("4. Найти книгу");
            //                Console.WriteLine("5. Список всех книг");
            //                Console.WriteLine("6. Выход");
            //                Console.Write("Выберите опцию: ");
            //                int option = int.Parse(Console.ReadLine());

            //                switch (option)
            //                {
            //                    case 1:
            //                        AddBook();
            //                        break;
            //                    case 2:
            //                        RemoveBook();
            //                        break;
            //                    case 3:
            //                        EditBook();
            //                        break;
            //                    case 4:
            //                        SearchBook();
            //                        break;
            //                    case 5:
            //                        ListAllBooks();
            //                        break;
            //                    case 6:
            //                        return;
            //                    default:
            //                        Console.WriteLine("Неверная опция. Пожалуйста, попробуйте снова.");
            //                        break;
            //                }
            //            }
            //        }

            //        // Добавление книги
            //        static void AddBook()
            //        {
            //            Console.Write("Введите название книги: ");
            //            string title = Console.ReadLine();
            //            Console.Write("Введите автора книги: ");
            //            string author = Console.ReadLine();
            //            Console.Write("Введите год издания книги: ");
            //            int year = int.Parse(Console.ReadLine());

            //            Book book = new Book { Title = title, Author = author, Year = year };
            //            bookList.Add(book);
            //            Console.WriteLine("Книга добавлена успешно!");
            //        }

            //        // Удаление книги
            //        static void RemoveBook()
            //        {
            //            Console.Write("Введите название книги: ");
            //            string title = Console.ReadLine();
            //            Book bookToRemove = bookList.Find(b => b.Title == title);
            //            if (bookToRemove != null)
            //            {
            //                bookList.Remove(bookToRemove);
            //                Console.WriteLine("Книга удалена успешно!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Книга не найдена.");
            //            }
            //        }

            //        // Редактирование книги
            //        static void EditBook()
            //        {
            //            Console.Write("Введите название книги: ");
            //            string title = Console.ReadLine();
            //            Book bookToEdit = bookList.Find(b => b.Title == title);
            //            if (bookToEdit != null)
            //            {
            //                Console.Write("Введите новое название книги: ");
            //                bookToEdit.Title = Console.ReadLine();
            //                Console.Write("Введите нового автора книги: ");
            //                bookToEdit.Author = Console.ReadLine();
            //                Console.Write("Введите новый год издания книги: ");
            //                bookToEdit.Year = int.Parse(Console.ReadLine());
            //                Console.WriteLine("Книга отредактирована успешно!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Книга не найдена.");
            //            }
            //        }

            //        // Поиск книги
            //        static void SearchBook()
            //        {
            //            Console.Write("Введите название книги или автора: ");
            //            string searchQuery = Console.ReadLine();
            //            List<Book> searchResults = bookList.FindAll(b => b.Title.Contains(searchQuery) || b.Author.Contains(searchQuery));
            //            if (searchResults.Count > 0)
            //            {
            //                Console.WriteLine("Результаты поиска:");
            //                foreach (Book book in searchResults)
            //                {
            //                    Console.WriteLine($"Название: {book.Title}, Автор: {book.Author}, Год: {book.Year}");
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Книги не найдены.");
            //            }
            //        }

            //        // Список всех книг
            //        static void ListAllBooks()
            //        {
            //            Console.WriteLine("Все книги:");
            //            foreach (Book book in bookList)
            //            {
            //                Console.WriteLine($"Название: {book.Title}, Автор: {book.Author}, Год: {book.Year}");
            //            }
            //        }
            //    }

            //    class Book
            //    {
            //        public string Title { get; set; }
            //        public string Author { get; set; }
            //        public int Year { get; set; }
            //    }
            //}

        }
    }
}
