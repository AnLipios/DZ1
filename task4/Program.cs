Console.Write("Введите число a: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Введите число c: ");
int numberC = int.Parse(Console.ReadLine());
int max=numberA;

if(numberB>max)
{
    max=numberB;
}
if(numberC>max)
{
    max=numberC;
}

Console.WriteLine($"Наибольшее число: {max}!!!!!");