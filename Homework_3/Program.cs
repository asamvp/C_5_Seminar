/*Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
double[] GenerateArray(int len = 5)// функция генерации массива
{
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -50.0 + rnd.NextDouble() * (50.0 + 50.0);
    }
    return array;
}
double Summ(double[] array)  //разница между максимальным и минимальным элементов массива
{
    double max=0, min=array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max<array[i]) max=array[i];
        if (min>array[i]) min=array[i];
    }
    return max-min;
}
void PrintArray(double[] array) //вывод массива
{
    foreach (double item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}
Console.Clear();
double[] array = GenerateArray();
PrintArray(array);
System.Console.WriteLine($"разница между максимальным и минимальным элементов массива -> {Summ(array)}");