// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.WriteLine("Введите размер массива");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[sizeArray];

void WriteArray(int[] array)
{
    for(int index = 0; index < array.Length; index++)
    {
        Console.Write(array[index] + " ");
    }
    Console.WriteLine();
}
void FillArray(int[] array)
{
    for(int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(100, 1000);
    }
}

FillArray(randomArray);
WriteArray(randomArray);

int count = 0;
for (int index = 0; index < randomArray.Length; index++)
{
    if ((index % 2) == 0)
    count++;
}
Console.WriteLine(count);

