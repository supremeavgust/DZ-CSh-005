// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76



void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 101); // [1;100]

}

void SelectionSort(int[] array)
{
    int max = 0;
    int min = 100;
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i];
        result = max - min;
    }
    for (int i = 0; i < array.Length; i++)
    Console.Write("" );
    Console.WriteLine();
    Console.WriteLine("max:  " + max);
    Console.WriteLine("min  " + min);
    Console.WriteLine("Разница максимального и минимального:  " + (max - min));
    Console.ReadKey();
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}
Console.Clear();
Console.Write($"n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
PrintArray(array);
SelectionSort(array);

