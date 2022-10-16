// Задача 8: Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все четные числа от 1 до (N).
Console.Clear();
Console.WriteLine("Программа для определения всех четных чисел от 1 до заданного (работает с целыми числами)");
Console.Write("Задайте число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i < number - 1)
{
    i +=2;
    Console.Write(i);
    Console.Write(",");
}