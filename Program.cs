// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
Console.WriteLine($"Input the number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = (num1.ToString().Reverse().ToArray());
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2)
Console.WriteLine($"Your number {num1} is a palindrome.");

if(num1 != num2)
Console.WriteLine($"Your number {num1} is NOT a palindrome.");

*/




// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double FindDistance(double xA, double yA, double zA, double xB, double yB, double zB)
{
double distance = Math.Sqrt(Math.Pow(xA-xB,2)+Math.Pow(yA-yB,2)+Math.Pow(zA-zB,2));
return distance;
}

Console.WriteLine("Input the first x: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input the first y: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input the first z: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input the second x: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input the second y: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input the second z: ");
double zB = Convert.ToDouble(Console.ReadLine());

double dist = Math.Round(FindDistance(xA,yA,zA,xB,yB,zB),3);
Console.WriteLine($"Distance = {dist}");
*/

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void TableOfCubes(int N)

{
    double result = 1;
    while (result <= N)
    {
    Console.Write(Math.Pow(result, 3) + " ");
    result ++;
    }
}
Console.WriteLine($"Input N: ");
int N = Convert.ToInt32(Console.ReadLine());
TableOfCubes(N);
*/