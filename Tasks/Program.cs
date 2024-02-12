/* ЗАДАЧА 1
Напишите программу, которая принимает на вход число и проверяет,
кратно ли оно одновременно 7 и 23. */

System.Console.WriteLine("Введите число на проверку кратности на 7 и 23 одновременно");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0)
{
    System.Console.WriteLine("Да, кратно");
}
else
{
    System.Console.WriteLine("Нет, не кратно");
}


System.Console.WriteLine();


/* ЗАДАЧА 2
Напишите программу, которая принимает на вход координаты точки (X и Y),
причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
в которой находится эта точка.  */

System.Console.WriteLine("Введите координату X");
int cordX = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y");
int cordY = Convert.ToInt32(Console.ReadLine());
if (cordX > 0 && cordY > 0)
{
    System.Console.WriteLine("У вас 1-ая четверть плоскости");
}
else if (cordX < 0 && cordY > 0)
{
    System.Console.WriteLine("У вас 2-ая четверть плоскости");
}
else if (cordX < 0 && cordY < 0)
{
    System.Console.WriteLine("У вас 3-я четверть плоскости");
}
else if (cordX > 0 && cordY < 0)
{
    System.Console.WriteLine("У вас 4-ая четверть плоскости");
}
else if (cordX == 0 || cordY == 0)
{
    System.Console.WriteLine("Одна из координат находится на одной из оси плоскости");
}


System.Console.WriteLine();


/* ЗАДАЧА 3
Напишите программу, которая принимает на вход целое число из отрезка [10, 99]
и показывает наибольшую цифру числа.    */

System.Console.WriteLine("Введите двухзначное число");
number = Convert.ToInt32(Console.ReadLine());
while ((number < 10 && number > 99) || (number > -99 && number < -10))
{
    System.Console.WriteLine("Введите двухзначное число");
    number = Convert.ToInt32(Console.ReadLine());
}
int leftDigit = number / 10 ;
int rightDigit = number % 10 ;
int result = 0;
if (leftDigit > rightDigit)
{
    result = leftDigit;
}
else if (leftDigit < rightDigit)
{
    result = rightDigit;
}
if (result == 0)
{
    System.Console.WriteLine("Обе цифры равны");
}
else
{
System.Console.WriteLine($"Ответ: {result}");
}
