/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33-> [6, 1, 33]
))) Не ясно по примеру, сделал по условию 
*/

int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
    int EnterNum(string phrase)
    {
        Console.WriteLine(phrase);
        return int.Parse(Console.ReadLine()!);
    }
    int numbersForArray = EnterNum($"Введите число: {i + 1} элемента массива ");
    array[i] = numbersForArray;
}

Console.Write($"Элементы массива: ");
for (int i = 0; i < array.Length; i++)
{

    Console.Write(array[i]);
    if (i < array.Length - 1) Console.Write(", ");
}







