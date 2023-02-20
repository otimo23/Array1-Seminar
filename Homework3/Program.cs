/*Напишите программу, которая принимает на вход координаты двух точе
 и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
/ A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
//double s = Math.Sqrt(...);
The distance between two points in a three dimensional - 3D
 - coordinate system can be calculated as. 
d = ((x2 - x1)2 + (y2 - y1)2 + (z2 - z1)2)1/2*/
Console.Clear();
Console.WriteLine("Enter xA coordinates: ");
double xA = double.Parse(Console.ReadLine());
Console.WriteLine("Enter yA coordinates");
double yA = double.Parse(Console.ReadLine());
Console.WriteLine("Enter zA coordinates");
double zA = double.Parse(Console.ReadLine());
Console.WriteLine("Enter xB coordinates");
double xB = double.Parse(Console.ReadLine());
Console.WriteLine("Enter yB coordinates");
double yB = double.Parse(Console.ReadLine());
Console.WriteLine("Enter zB coordinates");
double zB = double.Parse(Console.ReadLine());
double d = Math.Sqrt(Math.Pow((xA - xB), 2) + Math.Pow((yA - yB), 2) + Math.Pow((zA - zB), 2));
Console.WriteLine($"d = {d:f2}");
