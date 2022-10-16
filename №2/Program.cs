// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
//какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Программа для определения большего числа");
Console.WriteLine("Введите первое число: ");
int numbera = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberb = Convert.ToInt32(Console.ReadLine());;
int max = 0;
if (numbera == numberb)
{
    Console.Write("числа равны");
}
else
{
    if (numbera > numberb) max = numbera ;
    else max = numberb;
    Console.Write("большее число: ");
    Console.Write(max);
}