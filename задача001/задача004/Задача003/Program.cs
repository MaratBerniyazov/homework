Console.Write ("Введите значение: ");
int number = int.Parse(Console.ReadLine()!);

if (number % 2 == 0)
{
    Console.WriteLine($"Введеное значение {number} является четным");

}
else
{
    Console.WriteLine($"Введеное значение {number} является нечетным");
}