// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


void ShowArray(int[] array){
    Console.Write('[');
    int len=array.Length;
    for (int i = 0; i<len-1;i++)
    {
        Console.Write(array[i]+", ");
    }
    Console.Write(array[len-1]+"]");
}
int [] GetArray(int number){
    int[] array = new int[number];
    for (int i = 0; i< array.Length;i++)
    {
        array[i]=new Random().Next(0,100);
    }
    return array;
}
int GetNum(String text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}
int num = GetNum("Введите длину массива: ");
ShowArray(GetArray(num));
