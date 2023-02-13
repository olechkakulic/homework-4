// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
void getSumm(int x){
    int summa=0;
    while(x>0){
        summa+=x%10;
        x/=10;
    }
    Console.WriteLine(summa);

}
int getNumber(String text){
    Console.WriteLine(text);
    return(int.Parse(Console.ReadLine()));
}
int x = getNumber("Введите любое число");
getSumm(x);


// void getLength(int x){
//     int index=0;
//     while(x>0){
//         x=x/10;
//         index++;
//     }
//     Console.WriteLine(index);

// }
// int getNumber(String text){
//     Console.WriteLine(text);
//     return(int.Parse(Console.ReadLine()));
// }
// int x = getNumber("Введите любое число");
// getLength(x);
