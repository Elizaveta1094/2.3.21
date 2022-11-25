//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите Х первой точки: ");
int Xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите У первой точки: ");
int Ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z первой точки: ");
int Za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Х второй точки: ");
int Xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y второй точки: ");
int Yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z второй точки: ");
int Zb = Convert.ToInt32(Console.ReadLine());
double firstpoint = Xa - Xb; 
double secondpoint = Ya - Yb;
double thirdpoint = Za - Zb;
double distanse = Math.Sqrt((Math.Pow(firstpoint, 2)) + (Math.Pow(secondpoint, 2)) + (Math.Pow(thirdpoint, 2)));
Console.WriteLine(Math.Round(distanse , 2));
