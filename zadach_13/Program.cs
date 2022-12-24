/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

    Console.Clear();
    Console.Write("Введите целое число, лучше трехзначное и больше: ");
    int number = int.Parse(Console.ReadLine());
    int number1 = number;
    int n=0;
    while (number1>0)
      {
        number1 /=10;
        n++;
      }
    Console.Write("А теперь магия, третья слева цифра Вашего чиса: ");
    int x=Convert.ToInt32(Math.Pow(10,n-3));
    if (n<3)
      {
    Console.Write("А вот и нет... Третьей цифры в Вашем числе нет :(");        
      }
    else
      {
    Console.Write($"{(number/x)%10}");
      }