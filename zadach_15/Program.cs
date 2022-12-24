/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
    Console.Clear();
    Console.Write("Введите целое число от 1 до 7: ");
    int number = int.Parse(Console.ReadLine());
    if (number<1 || number>7)
    {
      Console.Write("Вы ввели  число не от 1 до 7");
    }
    else
    {
    if(6<=number && number <=7)
      {
    Console.Write("Да");      
      }
      else
      {
    Console.Write("Нет");          
      }
    }
    