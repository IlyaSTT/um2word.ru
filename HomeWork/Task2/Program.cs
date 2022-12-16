using static System.Console;

WriteLine("Введите число a:");
int a = int.Parse(ReadLine()!);

WriteLine("Введите число b:");
int b = int.Parse(ReadLine()!);

WriteLine("Введите число c:");
int c = int.Parse(ReadLine()!);

if (a > b)
{
    if (a > c)
    {
        WriteLine("Максимальное число: " + a);
    }
    else
    {
        WriteLine("Максимальное число: " + c);
    }
}

else if (b > c)
{
   WriteLine("Максимальное число: " + b);
}
else
{
    Console.WriteLine("Максимальное число: " + c);
}









