/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

/*Console.WriteLine("Программа, которая показывает количество чётных чисел в массиве.");
Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int minValue = 100;
int maxValue = 999;
int []CreateArray(int size,int minValue,int maxValue)
{
    int []array = new int[size];
    for(int i = 0;i < size;i++){
    array[i] = new Random().Next(minValue,maxValue+1);}
    return array;
}

int[] initialArray = CreateArray(size,minValue,maxValue);
void PrintArray(int []initialArray)
{
    for(int i = 0;i < size;i++)

    Console.Write($"{initialArray[i]} ");
    Console.WriteLine();
}

int SortByEven(int []initialArray)
{  
    int count = 0;
   for(int i = 0;i < size;i++)
   if(initialArray[i] %2 == 0){
     count++;
   }
   return count;
}

int evenNumCount = SortByEven(initialArray);
PrintArray(initialArray);
Console.Write($"Количество четных чисел -> {evenNumCount}");*/

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

/*Console.WriteLine("Программа находит сумму элементов, стоящих на нечётных позициях.");
Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int minValue = 0;
int maxValue = 100;
int []CreateArray(int size,int minValue,int maxValue)
{
    int []array = new int[size];
    for(int i = 0;i < size;i++){
    array[i] = new Random().Next(minValue,maxValue+1);}
    return array;
}

int[] initialArray = CreateArray(size,minValue,maxValue);
void PrintArray(int []initialArray)
{
    for(int i = 0;i < size;i++)

    Console.Write($"{initialArray[i]} ");
    Console.WriteLine();
}
int SumOfOdd(int []initialArray)
{  
   int sum = 0;
   for(int i = 0;i < size;i+=2)
     sum += initialArray[i];
     return sum;
}
int sumOdds = SumOfOdd(initialArray);
PrintArray(initialArray);
Console.Write($"Сумма элементов, стоящих на нечётных позициях -> {sumOdds}"); */

/*Задача 38: Задайте массив вещественных чисел(тип double). Найдите разницу между максимальным и минимальным элементов массива.

[3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1 */

/*Console.WriteLine("Найдите разницу между максимальным и минимальным элементов массива вещественных чисел");
Console.Write("input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int minValue = 0;
int maxValue = 100;
double[] CrearteArray (int size,int minValue,int maxValue)
{
    double [] array = new double[size];
    double []realNumbers = new double[size];
    
    for (int i = 0; i < size; i++)
    array[i] = new Random().Next(minValue,maxValue);
    
    for (int i = 0; i < size; i++)
    realNumbers[i] = new Random().NextDouble();

    for (int i = 0; i < size; i++)
    array[i] += realNumbers[i];
    return array;
}
double []initialArray = CrearteArray(size,minValue,maxValue);
void PrintArray(double [] initialArray)
{
    for (int i = 0; i < size; i++)
    Console.Write($"{Math.Round(initialArray[i],1)} ");
    Console.WriteLine();
}

PrintArray(initialArray); */
