Console.Write("Введите число a: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int numberB = int.Parse(Console.ReadLine());

if(numberA > numberB)
{
    Console.WriteLine("numberA больше!");
    Console.WriteLine("numberB меньше :(");
}
if(numberB > numberA)
{
    Console.WriteLine("numberB больше!");
    Console.WriteLine("numberA меньше");
}