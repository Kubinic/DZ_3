// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
Console.Write("Введите число : ");
int num = int.Parse(Console.ReadLine()!);
int a = 0;
int a1 = 0;
int b = 0;
int b1 = 0;
a = num / 10000;
a1 = num / 1000 % 10;
b = num % 10;
b1 = num % 100 / 10;
if (a==b&&a1==b1)
    Console.WriteLine($"число {num} является полиндромом ");
else
    Console.WriteLine($"число {num}  не является полиндромом ");