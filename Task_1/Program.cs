// Напишите программу, которая на вход принимает два числа
//и выдает, какое число большее, а какое меньшее.
//a=5 b=7, max=7


Console.WriteLine("Write first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Write second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = 0;

if(num2 >= num1)
{
    max = num2;
}
else
{
    max = num1;
}

Console.WriteLine("Максимальное число" + max);