Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);
for(int i = 1; i <= n; i++)
{
    if(i%2 == 0)
    System.Console.Write(i+", ");
}
System.Console.WriteLine();