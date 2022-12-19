
// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

/*

Console.Write("Input a firs number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad = num2 * num2;
if(num1 == quad)
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No!");
}
*/

// Задача 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

/*
Console.Write("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = -num;

while(current <= num)
{     Console.Write(current + " ");
      current++; 
      }


12345 / 10 = 1234
12345 / 100 = 123
12345 / 1000 = 12
12345 / 10000 = 1

12345 % 10 = 5
12345 % 100 = 45
12345 % 1000 = 345
12345 % 10000 = 2345
12345 % 100000 = 12345

*/ 
// Homework1

// Task 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Enter a number "); 
int num1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Enter a number "); 
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
      Console.WriteLine("one number " + num1 + " more than the second " + num2);
   }
else
{
    Console.WriteLine("two number " + num2 + " more that the first " + num1);
} 
*/

// Task 4:  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Enter a number "); 
int num1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Enter a number "); 
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number "); 
int num3 = Convert.ToInt32(Console.ReadLine());
int max=num1;
if (num2 > max)
max = num2;
if (num3 > max)
max = num3;
        Console.WriteLine("Number max " + max);
/*

