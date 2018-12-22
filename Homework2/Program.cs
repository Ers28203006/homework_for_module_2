using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("На какую из задач в списке хотели бы получить ответ (от 1 до 10)?");
            int taskNumber = int.Parse(Console.ReadLine());
            switch (taskNumber)
            {

                case 1:

                    /*------- Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними -------*/

                    int newYear = 2019;

                    Console.Write("С  наступающим,  новым  ");

                    Console.Write(newYear / 1000);
                    Console.Write("  ");

                    Console.Write((newYear / 100) % 10);
                    Console.Write("  ");

                    Console.Write((newYear / 10) % 10);
                    Console.Write("  ");

                    Console.Write(newYear % 10);
                    Console.Write("  годом  !  !  !  !");

                    break;

                case 2:

                    /*-------Вывести на экран числа 5, 10 и 21 одно под другим-------*/

                    Console.WriteLine(5);
                    Console.WriteLine(10);
                    Console.WriteLine(21);

                    break;

                case 3:

                    /*-------Дано расстояние в сантиметрах. Найти число полных метров в нем.-------*/

                    double distance, distanceMetr;

                    Console.Write("Введите расстояние в сантиметрах: ");

                    distance = double.Parse(Console.ReadLine());
                    distanceMetr = distance / 100;

                    Console.Write("Число полных метров: ");
                    Console.WriteLine(distanceMetr);

                    break;

                case 4:

                    /*-------С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?-------*/

                    int day = 234;

                    Console.WriteLine("С некоторого момента прошло 234 дня.");
                    Console.Write("Полных недель за этот период прошло: ");
                    Console.WriteLine(day / 7);

                    break;

                case 5:

                    /*-------Дано двузначное число. Найти:
	                            -   число десятков в нем;
	                            -   число единиц в нем;
	                            -   сумму его цифр;
	                            -   произведение его цифр-----------*/

                    int number;

                    Console.WriteLine("Введите двузначное число: ");
                    number = int.Parse(Console.ReadLine());

                    Console.Write("Дано число ");
                    Console.WriteLine(number);

                    Console.Write("Количeство десятков в числе: ");
                    Console.WriteLine(number / 10);

                    Console.Write("Количeство единиц в числе: ");
                    Console.WriteLine(number % 10);

                    Console.Write("Сумма его цифр: ");
                    Console.WriteLine(((number / 10) % 10) + (number % 10));

                    Console.Write("Произведение его цифр: ");
                    Console.WriteLine((number / 10) * (number % 10));

                    break;

                case 6:

                    /*-------6.	Вычислить значение логического выражения при следующих значениях логических 
                     величин А, В и С: А = Истина, В = Ложь, С = Ложь:
                                                                        a.	А или В; 
                                                                        b.	А и В; 
                                                                        c.	В или С. -------------------------------*/
                    bool a = true, b = false, c = false;

                    Console.WriteLine("Начальные значения логических величин a = true, b = false, c = false");

                    Console.WriteLine("Вычислить значение логического выражения при всех возможных значениях логических величин A, B и C:");
                    Console.WriteLine("1. A или В;");
                    Console.WriteLine("2. А и В;");
                    Console.WriteLine("3. В или С");

                    Console.Write("Введите один из трех вариантов вычислений: ");
                    number = int.Parse(Console.ReadLine());

                    switch (number)
                    {
                        case 1:

                            Console.Write("Результирующее значение логического выражения: ");
                            Console.WriteLine(a || b);

                            break;

                        case 2:

                            Console.Write("Результирующее значение логического выражения: ");
                            Console.WriteLine(a && b);

                            break;

                        case 3:

                            Console.Write("Результирующее значение логического выражения: ");
                            Console.WriteLine(b || c);

                            break;
                    }

                    break;

                case 7:

                    /*------- Даны радиус круга и сторона квадрата. У какой фигуры площадь больше? --------*/

                    double radius, side;

                    Console.Write("Введите радиус круга: ");
                    radius = double.Parse(Console.ReadLine());

                    Console.Write("Введите сторону квадрата: ");
                    side = double.Parse(Console.ReadLine());

                    const double PI = 3.14;

                    double squareCircle = PI * Math.Pow(radius, 2);
                    double squareQuadrate = Math.Pow(side, 2);

                    Console.Write("Площадь окружности равна: ");
                    Console.WriteLine(squareCircle);

                    Console.Write("Площадь квадрата равна: ");
                    Console.WriteLine(squareQuadrate);

                    if (squareCircle > squareQuadrate)
                    {
                        Console.WriteLine("Площадь окружности больше площади квадрата");
                    }
                    else if (squareCircle < squareQuadrate)
                    {
                        Console.WriteLine("Площадь квадрата больше площади окружности");
                    }
                    else
                    {
                        Console.WriteLine("Площадь квадрата равна площади окружности");
                    }
                    break;


                case 8:

                    /*------- Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность? -----------*/

                    double bodyVolume1, bodyVolume2, bodyWeight1, bodyWeight2, bodyDensity1, bodyDensity2;

                    Console.Write("Объем тела 1: ");
                    bodyVolume1 = double.Parse(Console.ReadLine());

                    Console.Write("Macca тела 1: ");
                    bodyWeight1 = double.Parse(Console.ReadLine());

                    Console.WriteLine();

                    Console.Write("Объем тела 2: ");
                    bodyVolume2 = double.Parse(Console.ReadLine());

                    Console.Write("Macca тела 2: ");
                    bodyWeight2 = double.Parse(Console.ReadLine());

                    bodyDensity1 = bodyWeight1 / bodyVolume1;
                    bodyDensity2 = bodyWeight2 / bodyVolume2;

                    Console.WriteLine();

                    Console.Write("Плотность тела с материалом 1: ");
                    Console.WriteLine(bodyDensity1);

                    Console.Write("Плотность тела с материалом 2: ");
                    Console.WriteLine(bodyDensity2);

                    Console.WriteLine();

                    if (bodyDensity1 > bodyDensity2)
                    {
                        Console.WriteLine("Плотность тела с материалом 1 больше плотности тела с материалом 2");
                    }
                    else if (bodyDensity1 < bodyDensity2)
                    {
                        Console.WriteLine("Плотность тела с материалом 1 меньше плотности тела с материалом 2");
                    }
                    else
                    {
                        Console.WriteLine("Плотность тела с материалом 1 равна плотности тела с материалом 2");
                    }

                    break;
                case 9:

                    /*------- Известны сопротивления двух несоединенных друг с другом участков электрической
                     * цепи и напряжение на каждом из них. По какому участку протекает меньший ток? --------------------*/

                    double r1, r2, u = 220, i1, i2;

                    Console.Write("Сопротивление первой электрической цепи: ");
                    r1 = double.Parse(Console.ReadLine());

                    Console.Write("Сопротивление второй электрической цепи: ");
                    r2 = double.Parse(Console.ReadLine());

                    i1 = u / r1;
                    i2 = u / r2;

                    Console.WriteLine();

                    Console.Write("ток первой цепи равен: ");
                    Console.WriteLine(i1);

                    Console.Write("ток второй цепи равен: ");
                    Console.WriteLine(i2);

                    Console.WriteLine();

                    if (i1 > i2)
                    {
                        Console.WriteLine("ток первой цепи больше токa второй цепи");
                    }
                    else if (i1 < i2)
                    {
                        Console.WriteLine("ток первой цепи меньше токa второй цепи");
                    }
                    else
                    {
                        Console.WriteLine("ток первой цепи равен току второй цепи");
                    }

                    break;

                case 10:

                    /*------- Напечатать "столбиком": 
                                                        1.	все целые числа от 20 до 35;
                                                        2.	квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10);
                                                        3.	третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50);
                                                        4.	все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a) -----------*/

                    Console.WriteLine("Напечатать столбиком:");
                    Console.WriteLine("1.	все целые числа от 20 до 35;");
                    Console.WriteLine("2.	квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10);");
                    Console.WriteLine("3.	третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50);");
                    Console.WriteLine("4.	все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a).");

                    Console.WriteLine();

                    Console.Write("Введите один из четырех вариантов отображения: ");

                    number = int.Parse(Console.ReadLine());

                    int number1, number2;

                    switch (number)
                    {
                        case 1:

                            number1 = 20;
                            number2 = 35;

                            for (int i = number1; i <= number2; i++)
                            {
                                Console.WriteLine(i);
                            }

                            break;

                        case 2:

                            number1 = 10;

                            Console.Write("Введите значение b: ");
                            number2 = int.Parse(Console.ReadLine());
                            int result;

                            if (number2 <= 10)
                            {
                                number2 = 11;
                            }

                            for (int i = number1; i <= number2; i++)
                            {
                                result = i;

                                Console.WriteLine(Math.Pow(result, 2));
                            }

                            break;

                        case 3:

                            number2 = 50;

                            Console.Write("Введите значение a: ");
                            number1 = int.Parse(Console.ReadLine());

                            if (number1 >= 50)
                            {
                                number1 = 49;
                            }

                            for (int i = number1; i <= number2; i++)
                            {
                                result = i;

                                Console.WriteLine(Math.Pow(result, 3));
                            }

                            break;
                        case 4:

                            Console.Write("Введите значение a: ");
                            number1 = int.Parse(Console.ReadLine());

                            Console.Write("Введите значение b: ");
                            number2 = int.Parse(Console.ReadLine());

                            if (number2 <= number1)
                            {
                                number2 = number1 + 1;
                            }

                            for (int i = number1; i <= number2; i++)
                            {
                                Console.WriteLine(i);
                            }

                            break;
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}