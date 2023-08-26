// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int EnterNumber(string phrase)
{
  Console.WriteLine(phrase);
  return int.Parse(Console.ReadLine()!);
}

int number = EnterNumber("Введите число возводимое в степень: ");
int degree = EnterNumber("Введите число требуемой степени: ");
int result = number;
for (int i = 1; i < degree; i++)
{
  result = result * number;
}
Console.WriteLine($"Результат числа {number} в {degree} степени равен: {result}");
