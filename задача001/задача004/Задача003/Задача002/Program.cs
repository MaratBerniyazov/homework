Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if(max<b)
{
    max=b;
}

if(max<c)
{
    max=c;
}
System.Console.WriteLine($"max = {max}");




