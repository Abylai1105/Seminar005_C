//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива ");
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
        array[index] = new Random().Next(0, 100);
    }
}

FillArray(randomArray);
WriteArray(randomArray);

int min = int.MaxValue; // Минимальное значение
int max = int.MinValue; // Максимальное значение
for (int i = 0; i < randomArray.Length; i++)
{
    int val = randomArray[i];
    if (val < min)
    {
        min = val;
    }
    if (val > max)
    {
        max = val;
    }
}
Console.WriteLine($" Max {max}, Min {min}");

int difference = 0;
difference = max - min;

Console.WriteLine("Разница " + difference);