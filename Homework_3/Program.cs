/*Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да*/

/*Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int A = num % 10;
int B = num / 10000;
int C = num % 100;
C = C % 10;
int D = num / 1000;
D = D % 10;

if (Compare (A, B) == true && Compare (C, B) == true)
{
    Console.WriteLine($"{num} полиндром");
}

else 
{
    Console.WriteLine($"{num} не полиндром");
}

bool Compare(int A, int B)
{
    if (A == B)
    {
        return (true);
    }
    else
    {
        return (false);
    }
}*/

/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

/*Console.Write("Введите координату x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату d1: ");
double d1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату d2: ");
double d2 = Convert.ToDouble(Console.ReadLine());

double distance = ((x2-x1)*(x2-x1)) + ((y2-y1)*(y2-y1)) + ((d2-d1)*(d2-d1));
Console.WriteLine($"ответ: {Math.Sqrt(distance)}");*/

/*Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27. 
5 -> 1, 8, 27, 64, 125*/

Console.Write("Enter num: ");
int min = 1;
int N = Convert.ToInt32(Console.ReadLine());

while (N > min)
{
    Console.Write($"{Method(min)}, ");
    min++;
}

Console.Write(N*N*N);

int Method (int N)
{
    return N*N*N;
}