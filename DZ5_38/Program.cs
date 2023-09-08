// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76



void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble();

    }
}

void PrintArray(double[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)

    {
        System.Console.Write($"{Math.Round(array[i] * 1000) / 10}, ");
    }
    System.Console.Write("]");

}

void MaximumElementAndTheDifferenceBetweenThem(double[] array)
{
    double Max = array[0];
    double Min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > Max)
        {
            Max = array[i];
        }

        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] < Min)
                Min = array[j];
        }


    }
    System.Console.WriteLine();


    System.Console.WriteLine($" разница между мин. элем. и макс. элем. : {Math.Round(Max * 1000) / 10} - {Math.Round(Min * 1000) / 10} = {Math.Round(Math.Round(Max * 1000) / 10) - (Math.Round(Min * 1000) / 10)} ");
}



double[] RealNumbers = new double[10];
System.Console.WriteLine();
FillArray(RealNumbers);
PrintArray(RealNumbers);
System.Console.WriteLine();
MaximumElementAndTheDifferenceBetweenThem(RealNumbers);
System.Console.WriteLine();