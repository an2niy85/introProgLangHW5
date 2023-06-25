// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int Promt(string meassage)
{
    Console.Write(meassage);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int[] RandomArray(int element)
{
    int[] array = new int[element];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}

int SumOdd(int[] array)
{
    int sum = 0;    
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1) sum += array[i];
    }
    return sum;
}

Console.Clear();
int element = Promt("Введите количество элементов массива: ");

int[] array = RandomArray(element);
PrintArray(array);
Console.WriteLine($"Сумма нечетных элементов в массиве равна {SumOdd(array)}");
