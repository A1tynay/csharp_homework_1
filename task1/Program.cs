// Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое 
// меньшее
// a = 5, b = 7  => max = 7, min = 5

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > secondNumber)
{
    System.Console.WriteLine(firstNumber);
}
else
{
    System.Console.WriteLine(secondNumber);
}