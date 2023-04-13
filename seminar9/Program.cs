/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
 */
/* Console.WriteLine("Задача 64: Программа выводит все натуральные числа в промежутке от N до 1 с помощью рекурсии");

void FindRecurNum(int n)    
{
   if (n == 0)
   {
      return;                   
   }
   Console.Write($"{n} "); 
   FindRecurNum(n - 1);    
}

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
FindRecurNum(n); */

/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*Console.WriteLine("Задача 66: Программа находит сумму натуральных элементов в промежутке от M до N с помощью рекурсии");

int FindRecurNum(int m, int n)    
{
    int sum = 0;
   if (n < m)
   {
      return sum;                   
   }
    
    sum = n;
    sum += FindRecurNum(m,n - 1);
    return sum;
     
}
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(FindRecurNum(m,n)); */

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */
/*Console.WriteLine("Задача 68: Программа вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n");

int FindAccerNum(int m, int n)    
{
  
   if (m == 0)
   {
      return n + 1;                   
   }
   else if ( m > 0 && n == 0)
   {
     return FindAccerNum(m -1,1);    
      
   }
    else if ( m > 0 && n > 0)
   {
     return FindAccerNum(m -1,FindAccerNum(m,n - 1));    
      
   }
    
    return FindAccerNum(m,n);
     
}
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(FindAccerNum(m,n)); */
