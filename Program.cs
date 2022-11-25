//напишите програму, которая принимает на вход трехзначное число и на выходе показывает вторую цифру числа
Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int ostatok = number/10%10;
Console.WriteLine($"Вторая цифра числа {ostatok}");