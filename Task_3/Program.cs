/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

Console.Write($"{number} -> ");

for (int i = 1; i <= number; i++)
{
    Console.Write($"{i * i * i} ");
}

Console.WriteLine();