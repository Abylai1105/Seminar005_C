// Задача 32: Напишите программу замена элементов массива: положительные элементы замените 
//на соответствующие отрицательные, и наоборот.

int[] array = new int[8];

for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите элимент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
WriteArray(array);

for(int i = 0; i < array.Length; i++)
{
    array[i] *= -1;
}

WriteArray(array);