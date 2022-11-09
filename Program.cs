/* задайте двумерный мссив m*n, заполненный случайными вещественными числами
m= 3, n= 4
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

double [,] CreateArray(int lenRows, int lenColumns)
{
        double [,] array = new double[lenRows, lenColumns];
        Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++) // генерация строк
        {
                for (int j = 0; j < array.GetLength(1); j++) // генерация столбцов
                {
                        array[i, j] = random.Next(-9, 10)+ random.NextDouble(); // задали вывод случайных, вещественных элементов массива, ограничили диапазон
                }
        }
        return array; // вернули двумерный массив
}

void PrintArray(double[,] array) // вывод на экран
{
        for (int i = 0; i < array.GetLength(0); i++)
        {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                        Console.Write($"{array[i, j]:f2}\t");
                }
                System.Console.WriteLine(); // переход на следующую строку
        }
}

double[,] array = CreateArray(3, 4); // задали размер двумерного массива
PrintArray(array); // вывели масив на экран
