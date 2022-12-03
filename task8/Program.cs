Console.Write("Введите число: ");
int n=int.Parse(Console.ReadLine());
int a=1;

while (a<=n)
{
    if(a%2==0)
    {
        Console.WriteLine($"{a}");
        
    }
    a++;
}