// Задача 35: Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 200);
    }
}
int[] randomArray = new int[123];
FillArray(randomArray);
WriteArray(randomArray);

int count = 0;
for (int i = 0; i < randomArray.Length; i++)
{
    if (randomArray[i] > 10 && randomArray[i] < 100)
    count++;
}
Console.WriteLine("Количества элементов в отрезке [10, 99] " + count);