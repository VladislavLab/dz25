//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double  Count(int i, int j)
{double res= Math.Pow((i),j);
return res;
}
Console.WriteLine("Введите два числа: ");
Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Возводим число {A} в степень {B} получаем {Count(A,B)}");
