// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int C = Convert.ToInt32(Console.ReadLine());

if (A > B)
{
    if (A > C)
    {
        Console.WriteLine("Максимальное число: " + A);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + C);
    }
}

else if (B > C)
{
    Console.WriteLine("Максимальное число: " + B);
}
else
{
    Console.WriteLine("Максимальное число: " + C);
}