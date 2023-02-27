//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.d = (x1-x2)+(y1-y2)+(z1-z2)
Console.WriteLine("Введите координаты точки 1 ");
Console.Write("Оси x1 : ");
double x1 = double.Parse(Console.ReadLine()!);
Console.Write("Оси y1 : ");
double y1 = double.Parse(Console.ReadLine()!);
Console.Write("Оси z1 : ");
double z1 = double.Parse(Console.ReadLine()!);

double distance = 0;
double resalt = 0;

Console.WriteLine("Введите координаты точки 2 ");
Console.Write("Оси x2 : ");
double x2 = double.Parse(Console.ReadLine()!);
Console.Write("Оси y2 : ");
double y2 = double.Parse(Console.ReadLine()!);
Console.Write("Оси z2 : ");
double z2 = double.Parse(Console.ReadLine()!);


resalt = Math.Sqrt((Math.Pow((x2-x1), 2)+Math.Pow((y2-y1), 2)+Math.Pow((z2-z1), 2)));


    
Console.WriteLine($"{Math.Round(resalt, 2)}");