// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int [] numbers = new int [8];
for(int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    numbers [i] = Convert.ToInt32(Console.ReadLine());
}

