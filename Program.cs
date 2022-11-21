//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*void SecondNum(int NumN)
{
    if(NumN > 99 && NumN < 1000)
    {
        NumN = NumN / 10 % 10;
        Console.WriteLine($"Вторая цифра числа {NumN} ");
    }
    else{ Console.WriteLine("Число не трехзначное");
    }
}

Console.Write("Введите ваше число ");
int user_num = Convert.ToInt32(Console.ReadLine());
SecondNum(user_num);
*/

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*void ThirdNum(int NumN)
{
    if(NumN > 99)
    {
     if(NumN > 999)
     {  
      while(NumN > 999)
      {
        NumN = NumN /10;
      }
      NumN = NumN % 10;
      Console.WriteLine($"Третья цифра числа {NumN}");         
    }
      
     else
     {
      NumN = NumN % 10;
      Console.WriteLine($"Третья цифра числа {NumN}");
     }
} 
    else
    {
     Console.WriteLine("Третьей цифры числа нет");
    }
}

Console.WriteLine("Введите трехзначное число ");
int user_num = Convert.ToInt32(Console.ReadLine());
ThirdNum(user_num);
*/

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*void WeekEnd(int A)
{
    if(A < 8 )
    {
      if(A < 6)
      {
        Console.WriteLine("Это не выходной");
      }
      else
      {
        Console.WriteLine(""Это выходной");
      }
    }
    else
    {
      Console.WriteLine("С такой цифрой дня недели не существует");
    }
}

Console.Write("Введите номер дня недели ");
int user_num = Convert.ToInt32(Console.ReadLine());
WeekEnd(user_num);
*/
