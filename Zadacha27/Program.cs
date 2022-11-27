/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int countDigit = 0;
int sum = 0;

int temp = number;

while (temp > 0)
{
    countDigit = countDigit + 1;
    temp /= 10;
}

int[] numbers = new int[countDigit];
int index = 0;

while (number > 0)
{
    numbers[index++] = number % 10;
    number /= 10;
}

for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}

Console.WriteLine("Сумма равна: " + sum);