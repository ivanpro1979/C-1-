// Задача 4: Напишите программу, которая на вход принимает три числа и выдаёт 
//максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Программа для определения большего числа (работает с целыми числами)");
Console.Write("Введите первое число: ");
int numbera = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberb = Convert.ToInt32(Console.ReadLine());;
Console.Write("Введите третье число: ");
int numberc = Convert.ToInt32(Console.ReadLine());;
int max = numbera;
if (numberb > numbera) max = numberb;
if (numberc > max) max = numberc;
{
    Console.Write("большее число: " + max);
}