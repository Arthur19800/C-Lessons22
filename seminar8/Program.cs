/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */
/*
Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
Console.Write("input array size rows m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input array size columns  n: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] CrearteArray(int m, int n)
{
    int [,] array = new int [m,n];
    for(int i = 0;i < m; i++){
        for(int j = 0; j < n;j++){
            array[i,j] = new Random().Next(0,10);
        }
    }
     return array;
}

void ShowArray(int[,] array)
{
     for(int i = 0;i < m; i++){
        for(int j = 0; j < n; j++){
           Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }

}
int [,] SortArray(int[,] array)
{
   

    
    int temp = 0;
   
   for(int k = 0;k < n; k++){
    for(int i = 0;i < m; i++){

        for(int j = 0; j < n-1;j++){
          
           if(array[i,j] > array[i,j+1] )
                 {
                    temp = array[i,j]; 
                    array[i,j] = array[i,j+1];
                    array[i,j+1] = temp;

                 }
        }
    }
   }    
     return array;
}


int[,] array = CrearteArray(m,n);
ShowArray(array);
int[,] sortedArray = SortArray(array);
Console.WriteLine();
ShowArray(sortedArray); */
/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

/*Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
Console.Write("input array size rows m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input array size columns  n: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] CrearteArray(int m, int n)
{
    int [,] array = new int [m,n];
    for(int i = 0;i < m; i++){
        for(int j = 0; j < n;j++){
            array[i,j] = new Random().Next(0,10);
        }
    }
     return array;
}

void ShowArray(int[,] array)
{
     for(int i = 0;i < m; i++){
        for(int j = 0; j < n; j++){
           Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}
int [] SortArray(int[,] array)
{
    int [] arrayRowSum = new int [m];  
    int sum = 0;
     for(int i = 0;i < m; i++)
     {
        for(int j = 0; j < n;j++)
           {
              sum += array[i,j];
           }
       arrayRowSum [i] = sum;
       sum = 0;
    }
     return arrayRowSum;
}

int FindMinSumRow(int[] array)
{    
  int min = array[0];
  int rowIndex = 0;
  int numberRow = 0;
     for(int i = 0;i < m; i++)
        {
          if (min > array[i]) 
          {       
          min = array[i];
          rowIndex = i;
          }
        }  
       numberRow = rowIndex +1;
      return  numberRow;
}
int[,] array = CrearteArray(m,n);
ShowArray(array);
Console.WriteLine();
int[] sortedArray = SortArray(array);
int rowMinNumber = FindMinSumRow(sortedArray);
Console.WriteLine($"Cтрока с наименьшей суммой элементов {rowMinNumber}"); */
 
/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
/*Console.WriteLine("Задача 60: Программу, находит строку с наименьшей суммой элементов в трёхмерном массиве из неповторяющихся двузначных чисел.");
Console.Write("input array size rows m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input array size columns  n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("input array size 3D array dimension  k: ");
int k = Convert.ToInt32(Console.ReadLine());

int [,,] CrearteArray(int m, int n, int k)
{
    int [,,] array = new int [m,n,k];
    int repeatingNumber;
    bool ifRepeated = false;
    for(int i = 0;i < m; i++){
        for(int j = 0; j < n;j++){
            for(int l = 0; l < k;l++)
            
            {
            repeatingNumber = new Random().Next(0,10);
            ifRepeated = FindRepeatingNumber(array,repeatingNumber);
            if(ifRepeated){
             array[i,j,l] = repeatingNumber;   
            }
            else 
            {
              l--;
            }
        }
    }
    }
     return array;
}
bool FindRepeatingNumber(int[,,] array, int repeatingNumber)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int l = 0; l < k; l++)
            {
                if (array[i, j, l] == repeatingNumber)
                {
                    return false;
                }
            }
        }
    }
    return true;
}
void ShowArray(int[,,] array)
{
  for(int i = 0;i < m; i++)
     {
      for(int j = 0; j < n;j++)
          {
             for(int l = 0; l < k;l++){
                Console.Write($"{array[i,j,l]}{(j,l,i)} ");
             }
             Console.WriteLine();
          }

    }   
}
int[,,] array = CrearteArray(m,n,k);
Console.WriteLine();
ShowArray(array);*/