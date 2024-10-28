// Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.
// 2, 3, 5    =>   5

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if(b > max)
{
    max = b;
}
if(c > max)
{
    max = c;
}

System.Console.Write("max = " + max);