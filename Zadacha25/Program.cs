/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Без использования функции Math.Pow.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/ 

Console.Write("Введите 1 число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = 1;

int Exponentiation(int number1, int number2)

{
     for(int i=1; i <= number2; i++)
    {
      result = result * number1;
    }
    return result;
}


 int exponentiation = Exponentiation(number1, number2);
 Console.WriteLine("Число в натуральной степени " + exponentiation);


