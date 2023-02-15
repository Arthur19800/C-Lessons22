/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 

Console.WriteLine("Определение наибольшего числа из двух ");
Console.Write("Ввидите первое число a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввидите второе число b = ");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b) 
{
    Console.WriteLine("Максимальное число a = " +a);
}
else if(a<b)
{
    Console.WriteLine("Максимальное число b = " +b);
} */

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 
*/
/*Console.WriteLine("Определение наибольшего числа из трех ");
        Console.Write("Введите первое число a = ");
        int a = Convert.ToInt32(Console.ReadLine());
       
        Console.Write("Введите второе число b = ");
        int b = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Введите третье число с = ");
        int c = Convert.ToInt32(Console.ReadLine());

    if ((a > b) && (a > c))
        {
            Console.WriteLine("Максимальное число a = " + a);
        }
    else if ((b >a)  && (b > c))
        {
            Console.WriteLine("Максимальное число b = " + b);
        }
    else if ((c > a) && (c > b))
        {
            Console.WriteLine("Максимальное число c = " + c);
        }     
    */ 
/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет 

        Console.WriteLine("Определение является ли число чётным ");
        Console.Write("Введите число ");
        int number = Convert.ToInt32(Console.ReadLine());

        if(number % 2 == 0)
        {
           Console.WriteLine("Число " +number+ " явяляется четным");
        }
        else 
        { 
            Console.WriteLine($"Число {number} явяляется нечетным");
        }*/
/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */
/*Console.WriteLine("Определение чётных числа от 1 до N");
Console.Write("Введите число N = ");
int n = Convert.ToInt32(Console.ReadLine());
int initial = 1;

while(initial <= n)
{
    if (initial % 2 == 0)
    {
      Console.Write($"{initial} ");
    }
    initial++;
}*/
