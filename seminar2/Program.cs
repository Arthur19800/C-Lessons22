/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/
   /* Console.WriteLine("Программа принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа");

    Console.Write("ВВедите трёхзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());

    int ShowSecondDigit(int num)
{
 int hundreds = num/10;
 int result = hundreds%10; 
return result;
}
int result = ShowSecondDigit(num);
Console.WriteLine(result);*/
/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа.
645 -> 5
32679 -> 6
21 -> -1*/
 /* Console.WriteLine("Программа выводит третью цифру заданного числа");
  
  Console.Write("Введите  число: ");
  int num = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine();
  int CountDigits (int num)
  {
    int count=0;
    
    if(num < 100)
      {
          return -1;
      }
    else  
    {  
          while(num > 0)
          {
            num = num /10;
            count++;
          }
    }
    return count;
    }

    int GetThreeDigits(int num_quantity,int num)
    {
        int count=3;
        while(num_quantity > count)
          {
            num = num /10;
            num_quantity--;
          }
          return num;
    }

    int GetThirdDigit(int three_digits)
    {
        return three_digits %= 10;
    }
    int num_quantity = CountDigits(num);
   Console.WriteLine($"Получили количество цифр в числе равное {num_quantity}");
   // Console.WriteLine();
    int three_digits = GetThreeDigits(num_quantity,num);
    //Console.WriteLine($"Получили трехзначное число {three_digits}");
    //Console.WriteLine();
    int third_digit = GetThirdDigit(three_digits);
    Console.WriteLine($"Получили третье число {third_digit}");*/

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
Console.WriteLine("Программа является ли этот день выходным");
Console.Write("Введите  число: ");
    
    bool CheckDay(int AnyDay)
    {
      bool result =false;
    if(AnyDay  >= 6 && AnyDay<=7)
    {
     result =true;
    }
   
    return result;
    }

 int AnyDay = Convert.ToInt32(Console.ReadLine());
 bool IfWeekend = CheckDay(AnyDay);
 Console.WriteLine($"Является день выходным результат {IfWeekend}");*/

