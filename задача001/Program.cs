Console.WriteLine("Найдем максимальное значение из двух чисел");
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine())!;
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine())!;

if (number1 > number2)
{
    Console.WriteLine($"Первое число больше второго, {number1} > {number2}");
}
else
{
    Console.WriteLine($"Второе число больше первого, {number2} > {number1}");  
}


