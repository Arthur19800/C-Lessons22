﻿
/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
*0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

/*Console.WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");

void CountBiggerZero()
{
    Console.Write("Введите количество чисел: ");
    
    int numberOfInput =Convert.ToInt32(Console.ReadLine());
    int numbers = 0;
    int count = 0;
    for(int i = 0; i < numberOfInput; i++) {
    numbers = Convert.ToInt32(Console.ReadLine());
    if(numbers  > 0) count++;}
    Console.WriteLine($"Чисел больше 0 ввёл {count}");
}

CountBiggerZero();*/
/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

/* Console.WriteLine("Программа, находит точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.Write("b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());


void FindIntersection(double k1,double b1,double k2,double b2)
{
    double x = 0; double y = 0;
        x = (b1 - b2) / (k2-k1); y = (k2*b1 - k1*b2) / (k2-k1);
              
        if(k1 == k2) Console.WriteLine("Прямые параллельны");
            else if ((y - (k1 * x) - b1) != 0 && (y - (k2 * x) - b2) != 0)
               Console.WriteLine("Прямые не пересекаются");
            else if ((y - (k1 * x) - b1) == 0 && (y - (k2 * x) - b2) == 0)
                 Console.WriteLine($"Прямые  пересекаются в точке ({x},{y})");
        
}

FindIntersection(k1,b1,k2,b2); */