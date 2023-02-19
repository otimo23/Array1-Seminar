/* Задача 19: Напишите программу,которая принимает
//  на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да*/

Console.WriteLine("Enter number from 10000 to 99999: ");
int N = int.Parse(Console.ReadLine()!);

int A = N / 1000;
int A1 = A / 10;
int A2 = A % 10;
int B = N % 100;
int B1 = B / 10;
int B2 = B % 10;

if(A1 == B2 && A2 == B1)
{
    Console.Write("Yes");
}

else
{
    Console.WriteLine("No");
}