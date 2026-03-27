using Tyuiu.StachinskiiVS.Sprint3.Task7.V19.Lib;

DataService ds = new DataService();
Console.Title = "Спринт #3 | Выполнил: Стачинский В.C | ИCПб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #19                                                             *");
Console.WriteLine("* Выполнил: Стачинский В.C | ИCПб-24-                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая выводит таблицу занчений функции            *");
Console.WriteLine("* F(x) = (5x + 2,5)/(sin(x) - 2) + 2                                      *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int startValue = -5;
int stopValue = 5;
Console.WriteLine("Старт шага - " + startValue);
Console.WriteLine("Конец шага - " + stopValue);
int len = ds.GetMassFunction(startValue, stopValue).Length;
double[] valueArray;
valueArray = new double[len];
valueArray = ds.GetMassFunction(startValue, stopValue);


Console.WriteLine("***************************************************************************");
Console.WriteLine("* Результат                                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Массив значений функции - " + "[{0}]", string.Join(",", valueArray));
Console.ReadKey();