//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число ");

int num = int.Parse(Console.ReadLine());

if (a > 99)
{

    while (num > 999)
    {
        num = num / 10;
    }

    Console.WriteLine(num - num / 10 * 10);
}
else
{
    Console.WriteLine("Нет третей цифры");
}