// Программа, которая принимает на вход три числа и выдает самое максимальное из них.


Console.WriteLine("Write first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Write second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Write third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > max);
{
    max = num2;
}
if(num3 > max);
{
    max = num3;
}

Console.WriteLine("Max number" + max);
