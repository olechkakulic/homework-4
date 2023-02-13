// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
double getCount(int x, int y)
{
    double result = Math.Pow(x, y);
    return result;
}
int getNumber(String text)
{
    Console.WriteLine(text);
    int value = int.Parse(Console.ReadLine());
    return value;
}
int x = getNumber("Введите любое число");
int y = getNumber("Введите степень, в которую хотите возвести число ");
Console.Write(x + ", " + y + " -> " + getCount(x, y));
