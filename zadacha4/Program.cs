// Задание 4
Console.Write("Введите любое натуральное число: ");
int number = int.Parse(Console.ReadLine()!);
int i = 0;
while (i <= number)
{
Console.Write($"{i},");
  i++;
}

