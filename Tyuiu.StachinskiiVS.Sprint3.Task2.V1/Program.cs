using Tyuiu.StachinskiiVS.Sprint3.Task2.V1.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 / Выполнил: Стачинский В. С. | ИCПб-24-1";

Console.WriteLine("**********************************************************************");
Console.WriteLine("* Спринт #3                                                          *");
Console.WriteLine("* Задание #2                                                         *");
Console.WriteLine("* Вариант #1                                                         *");
Console.WriteLine("**********************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                           *");
Console.WriteLine("* Написать программу, используя цикл do...while, которая вычисляет   *");
Console.WriteLine("* сумму ряда по формуле                                              *");
Console.WriteLine("**********************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                   *");
Console.WriteLine("**********************************************************************");

int startValue = 1;
int stopValue = 10;

Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);

Console.WriteLine("**********************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                          *");
Console.WriteLine("**********************************************************************");
Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(startValue, stopValue));

Console.ReadKey();