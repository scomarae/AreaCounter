using ClassLibraryAreaCounter;    // подключение пространства имен из библиотеки классов
using System;

Console.Write("Введите радиус круга: ");
Circle radius = new(Convert.ToDouble(Console.ReadLine()));
radius.Print();
double a;
Console.WriteLine("Введите 1 сторону треугольника: ");
a = Convert.ToDouble(Console.ReadLine());
double b;
Console.WriteLine("Введите 2 сторону треугольника: ");
b = Convert.ToDouble(Console.ReadLine());
double c;
Console.WriteLine("Введите 3 сторону треугольника: ");
c = Convert.ToDouble(Console.ReadLine());
Triangle a1 = new(a, b, c);
a1.Print();
