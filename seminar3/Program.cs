/*Урок 3. Базовые алгоритмы. Продолжение
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет  12821 -> да  23432 -> да */

 /*  Console.WriteLine("Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом");
   Console.Write("Введите число: ");
   int n = Convert.ToInt32(Console.ReadLine());
  
    int GetLastNum (int n)
    {
        int lastnumbers = n % 100;
        return lastnumbers;
    }
    int last_digits = GetLastNum (n);
   
   int GetFirstNum1 (int n)
    {
        int digit_1 = n;
        digit_1 = n / 10000;
        int digit_2 = ((((n / 1000) % 10) *10));
        int sum = digit_1 + digit_2;
        return sum;
    }
    int first_digits = GetFirstNum1(n);
    
    bool CheckPalindrome( int first_digits, int last_digits)
    {    
        bool result = false;
        if ( first_digits == last_digits)
        {
           result = true;
           Console.WriteLine("Число является палиндромом");
        }

        else
        {
             result = false;
             Console.WriteLine("Число не является палиндромом");
        }
         return result;
    }
bool IfPalindrome = CheckPalindrome(first_digits,last_digits);*/
/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/
    /*Console.WriteLine("Программа, которая принимает на вход  координаты двух точек и находит расстояние между ними в 3D пространстве");
    Console.WriteLine("Введите координаты точки A: ");
    int Ax = Convert.ToInt32(Console.ReadLine());
    int Ay = Convert.ToInt32(Console.ReadLine());
    int Az = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки B: ");
    int Bx = Convert.ToInt32(Console.ReadLine());
    int By = Convert.ToInt32(Console.ReadLine());
    int Bz = Convert.ToInt32(Console.ReadLine());
    double Lx = Ax - Bx;
    double Ly = Ay - By;
    double Lz = Az - Bz;
    double two_points_distance=Math.Round(Math.Sqrt(Math.Pow(Lx,2)+Math.Pow(Ly,2)+Math.Pow(Lz,2)),2);
    Console.WriteLine($"Расстояние между двумя точками -> {two_points_distance}");*/

/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
/*Console.WriteLine("Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N");
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
void PrintCubicNumber(int n)
{
    int count = 1;
    while (count <= n)
    {
        Console.Write($" {Math.Pow(count,3)} ");
        count++;
    }
}
PrintCubicNumber(n);*/

