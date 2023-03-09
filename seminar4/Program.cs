/*Урок 4. Функции
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)    2, 4 -> 16 */

/*Console.WriteLine("Цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

double GetPow (int a,int b)
{
    return Math.Pow(a,b);     
}

double resultPow = GetPow(a,b);
Console.WriteLine($"{a} в степени {b} -> {resultPow}");*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11 82 -> 10  9012 -> 12 */
/*Console.WriteLine("Программа, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.Write("Введите число number: ");
int number = Convert.ToInt32(Console.ReadLine());

int CountNum(int number)
{
    int count = 0;
    
    while(number > 0)
    {
        number /=10;
        count++;
    }
    return count;
}
int numbersCount = CountNum(number);
int NumbersSum (int number,int numbersCount)
{     
    int moduleDev =0;
    int temp =0;
    int newNumber = 0;

    for(int i = 0; i < numbersCount;i++)
    {
        newNumber = number;
        number %= 10;
        temp = number;
        moduleDev += temp;
        number = newNumber;
        number /= 10;
    }
     return moduleDev;
}

int countSum = NumbersSum(number,numbersCount);
Console.WriteLine($"Сумма цифр в числе {number} -> {countSum}"); */

/*Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */
/*Console.WriteLine("Программа, которая задаёт массив из m элементов и выводит их на экран.");
Console.Write("Введите количество элементов массива size = ");
int size = Convert.ToInt32(Console.ReadLine());

int []CreateArray(int size)
{
    int [] array =  new int[size];
    for (int i = 0; i < size;i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int []myArray = CreateArray(size);

void ShowArray(int []myArray) 
{
    for (int i = 0;i < size;i++)
    Console.Write($"{myArray[i]} ");
    Console.WriteLine();
}
ShowArray(myArray); */


