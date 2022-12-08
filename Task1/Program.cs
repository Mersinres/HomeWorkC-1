//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
    int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
    int B = Convert.ToInt32(Console.ReadLine());

    if (A > B)
{
    Console.WriteLine("Первое число  больше чем второе ");
}
else
{
    Console.WriteLine("Второе число больше чем первое ");
}