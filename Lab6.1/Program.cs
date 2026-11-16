//using biblio;
//Random random = new Random();
//int[] mas = new int[random.Next(10, 30)];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10, 50);
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();
//Console.WriteLine($"Сумма массива: {Class1.MultiMatrix(mas)}");


//вариант 5 и задание базовый уровень, да

using biblio;

double[,] matrix = new double[6, 4];

Console.WriteLine("Введите элементы матрицы 6 на 4:");
for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"Элемент [{i},{j}]: ");
        matrix[i, j] = double.Parse(Console.ReadLine()!);
    }
}

Console.WriteLine("\nИсходная матрица:");
for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

double[] maxMas = OurClassLibrary.MaxRows(matrix);

Console.WriteLine("\nМаксимальные элементы каждой строки:");
for (int i = 0; i < 6; i++)
{
    Console.Write(maxMas[i] + " ");
}