// Задача 33: Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве

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
Console.Write("Введите чисто, которое хотите найти ");
int searchNum = Convert.ToInt32(Console.ReadLine());


for(int i = 0; i < array.Length; i++)
{
    if(array[i] == searchNum)
    {
        Console.WriteLine($"Число {searchNum} в элементе массива {i} ");
        break;
    }
    else if (array[i] != searchNum)
    {
        Console.WriteLine($"Число {searchNum} нету в элементе массива ");
        break;
    }
}
