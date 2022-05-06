// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        array[index] = new Random().Next(-100, 100);
    }
}

FillArray(randomArray);
WriteArray(randomArray);

int sum = 0;
int mas = 0;
for (int index = 0; index < randomArray.Length; index++)
{
    while(index + 1)
    sum += index;
}
Console.WriteLine(sum);