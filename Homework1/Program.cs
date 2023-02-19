/*Задача 23: Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125*/

Console.Clear();
Console.Write("Enter number ");
int N = int.Parse(Console.ReadLine());
int i = 1;
int s = N;

int[]kub = new int[s];
for(int j =0; i <= N; i++)
{
    kub [j] = i * i * i;
    j++;
}

for(int j = 0; j < s; j++)
{
    Console.Write($"{kub[j]} ");
}