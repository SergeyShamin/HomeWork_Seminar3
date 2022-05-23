/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
*/

Console.WriteLine("Введите число: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

int[] digits = new int[5];


for (int i = 0; i < 5; i++)
{
    digits[i] = number % 10;
    number /= 10;
}

if (digits[0] == digits[4] && digits[1] == digits[3])
{
    Console.WriteLine("Введенное число является полиндромом.");
}
else
{
    Console.WriteLine("Введенное число не является полиндромом.");
}
