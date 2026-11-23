// Шаг 1
int age1 = 20;
if (age1 >= 21)
{
    Console.WriteLine("Доступ разрешён");
}
Console.WriteLine("Программа продолжает работу");

Console.WriteLine();

// Шаг 2
int age2 = 15;
if (age2 >= 18)
{
    Console.WriteLine("Доступ разрешён");
}
else
{
    Console.WriteLine("Доступ запрещён");
    Console.WriteLine($"До совершеннолетия осталось ждать: {18 - age2} лет");
}

Console.WriteLine();

// Шаг 3
int age3 = 65;
if (age3 < 13)
{
    Console.WriteLine("Ребёнок");
}
else if (age3 < 18)
{
    Console.WriteLine("Подросток");
}
else if (age3 >= 60)
{
    Console.WriteLine("Пенсионер");
}
else
{
    Console.WriteLine("Взрослый");
}

Console.WriteLine();

// Шаг 4
int age4 = 16;
double height = 1.4;
bool hasAdult = true;

if (age4 >= 14 && (height >= 1.5 || hasAdult))
{
    Console.WriteLine("Можно кататься");
}
else
{
    Console.WriteLine("Пока нельзя");
}

Console.WriteLine();

// Задача А
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("Чётное");
}
else
{
    Console.WriteLine("Нечётное");
}

Console.WriteLine();

// Задача Б
Console.Write("Введите оценку (2-5): ");
int mark = int.Parse(Console.ReadLine());
switch (mark)
{
    case 5:
        Console.WriteLine("Отлично");
        break;
    case 4:
        Console.WriteLine("Хорошо");
        break;
    case 3:
        Console.WriteLine("Удовлетворительно");
        break;
    case 2:
        Console.WriteLine("Неудовлетворительно");
        break;
    default:
        Console.WriteLine("Неверная оценка");
        break;
}

Console.WriteLine();

// Вариант 1
Console.Write("Введите целое число: ");
int n = int.Parse(Console.ReadLine());
if (n > 0)
{
    Console.WriteLine("Положительное");
}
else if (n < 0)
{
    Console.WriteLine("Отрицательное");
}
else
{
    Console.WriteLine("Ноль");
}

Console.WriteLine();

// Вариант 3
Console.Write("Введите номер месяца (1-12): ");
int month = int.Parse(Console.ReadLine());
switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Зима");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Весна");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Лето");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Осень");
        break;
    default:
        Console.WriteLine("Неверный месяц");
        break;
}
