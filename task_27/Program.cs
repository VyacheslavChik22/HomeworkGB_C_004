/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int EnterNum(string phrase)
{
    Console.WriteLine(phrase);
    return int.Parse(Console.ReadLine()!);
}

int introdusedNumber = EnterNum("Введите любое (желательно многозначное) число: ");

int theSumOfThePartsOfANumber(int number)
{
    int result = 0;
    int temp = 0;
    for (int i = 0; number > 0; i++)
    {
        temp = number % 10;
        number /= 10;
        result += temp;
    }
    return result;
}

System.Console.WriteLine($"Сумма элементов числа {introdusedNumber} равна: {theSumOfThePartsOfANumber(introdusedNumber)}");