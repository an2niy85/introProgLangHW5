// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int Promt(string meassage)
{
    Console.Write(meassage);
    int result = int.Parse(Console.ReadLine());
    return result;
}

double[] RandomArray(int element)
{
    double[] array = new double[element];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * 100;
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]:f2}, ");
    }
    Console.Write($"{array[array.Length - 1]:f2}");
    Console.WriteLine("]");
}

double DiffMaxMin(double[] array)
{    
    double min = Double.MaxValue;
    double max = Double.MinValue;    
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        if(array[i] < min) min = array[i];
    }
    return (max - min);
}

Console.Clear();
int element = Promt("Введите количество элементов массива: ");

double[] array = RandomArray(element);
PrintArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом в массиве равна {DiffMaxMin(array):f2}");
