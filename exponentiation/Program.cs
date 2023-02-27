//Задача 23
//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
//* при N < 0, нужно вывести от N до -1
Console.Write("Введите число : ");
int num = int.Parse(Console.ReadLine()!);
int exp = 3;
int count = 0;
int digit = 1;
if(num > 0){
    while (count <num){
    Console.Write($"{Math.Pow(digit, exp)}, ");
    digit++;
    count++;
    }
}
else
    while(count < (num*(-1))){
    Console.Write($"{(Math.Pow(digit, exp)*(-1))}, ");
    digit++;
    count++;
    }