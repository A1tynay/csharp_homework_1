// Напишите программу, которая на вход принимает 
// число и выдает, является ли число четным
// 4 => yes
// 5 => no

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    System.Console.WriteLine("Yes");
}
else
{
   System.Console.WriteLine("No");   
}