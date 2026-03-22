using Tyuiu.StachinskiiVS.Sprint3.Task1.V18.Lib;

Console.Title = "Спринт #3| Выполнил: Стачинский В.С. | ИCПб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла for                                                *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #18                                                             *");
Console.WriteLine("* Выполнил: Стачинский В.С. | ИCПб-24-1                                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда   *");
Console.WriteLine("* по формуле                                                              *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int startValue = 1;
int stopValue = 15;
Console.WriteLine("Начало шага " + startValue);
Console.WriteLine("Конец шага " + stopValue);


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(startValue, stopValue));
Console.ReadKey();
