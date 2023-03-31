
/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/
/*Console.WriteLine("Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
Console.Write("input array size rows m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input array size columns  n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] CrearteArray (int m,int n)
{
    double [,] array = new double[m,n];
    double [,] realnumbers = new double[m,n];
    for (int i = 0; i < m; i++)
       for (int j = 0; j < n; j++)
          array[i,j] = new Random().Next(-100,100+1);
    
    for (int i = 0; i < m; i++)
       for (int j = 0; j < n; j++)
          realnumbers[i,j] = new Random().NextDouble(); 
    
     for (int i = 0; i < m; i++)
       for (int j = 0; j < n; j++)     
            array[i,j] += realnumbers[i,j]; 
    return array;
}
void ShowArray(double [,]initialArray)
{
    for (int i = 0; i < m; i++){
       for (int j = 0; j < n; j++){
          Console.Write($"{Math.Round((initialArray[i,j]),2)} ");}
             Console.WriteLine();}
}
double [,] initialArray = CrearteArray (m,n);
ShowArray(initialArray);*/
/*Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/ 
/*Console.WriteLine("Программа, на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.Write("input array size rows m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input array size columns  n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("input number to search: ");
int number = Convert.ToInt32(Console.ReadLine());

int [,] CrearteArray(int m, int n)
{
    int [,] array = new int [m,n];
    for(int i = 0;i < m; i++){
        for(int j = 0; j < n;j++){
            array[i,j] = new Random().Next(0,10+1);
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

bool CheckNumberInArray(int[,] array,int number)
{
    bool result = false;
    for(int i = 0;i < m; i++){
        for(int j = 0; j < n;j++){
            if(array[i,j] == number)
              {
                 result = true;
              }
        
      }
    }
   
    return result;
}

void PrintResult(bool result,int[,] array)
{
   if(result==true)
   {
       for(int i = 0;i < m; i++)
        {
            for(int j = 0; j < n;j++)
                if(array[i,j] == number) 
                {
                    Console.WriteLine($"Number {number} found at index({i},{j})");             
                }   
        }
   }
   
  if(result==false) 
  {
       Console.WriteLine($"Number {number} not found");
  } 
  
}
    
int[,] array = CrearteArray(m,n);
ShowArray(array);
Console.WriteLine();
bool result = CheckNumberInArray(array,number);
PrintResult(result,array); */

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */ /*
Console.WriteLine("Найдите среднее арифметическое элементов в каждом столбце");
Console.Write("input array size rows m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input array size columns  n: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] CrearteArray(int m, int n)
{
    int [,] array = new int [m,n];
    for(int i = 0;i < m; i++){
        for(int j = 0; j < n;j++){
            array[i,j] = new Random().Next(0,10+1);
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
double []FindSumMean(int[,] array)
{
   double sum = 0; 
  double [] sumArray = new double[n];
    for(int i = 0;i < array.GetLength(1); i++){ 
       sum = 0;
        for(int j = 0; j < array.GetLength(0);j++){
             sum +=array[j,i];     
        }
       sumArray[i]=Math.Round(sum/(double)(m),2);
    }
   return sumArray;
}
void ShowSumArray(double[] array)
{
     for(int i = 0;i < n; i++){
       
           Console.Write($"{array[i]}  ");
        }
}
int[,] array = CrearteArray(m,n);
ShowArray(array);
Console.WriteLine();
double [] sumColumns =FindSumMean(array);
ShowSumArray(sumColumns);*/