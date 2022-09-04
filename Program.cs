// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

// int Prompt(string message)
// {
//     System.Console.Write(message);                    
//     int result = Convert.ToInt32(Console.ReadLine()); 
//     return result;                                    
// }

// int[,] FillArray(int numLine, int numColumns)         
// {
//     Random rand = new Random();
//     int[,] matrix = new int[numLine, numColumns];
//     for (int i = 0; i < matrix.GetLength(0); i++)  
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)     
//         {
//             matrix[i, j] = rand.Next(1, 9);    
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] matrix)  
// {
//     for (int i = 0; i < matrix.GetLength(0); i++) 
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) 
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] array = FillArray(Prompt("Количество строк: "),Prompt("Количество столбцов: "));
// Console.WriteLine("Полученный массив: ");
// PrintArray(array);

// for (var i = 0; i < array.GetLength(0); i++)
//     for (var j = 0; j < array.GetLength(1); j++)
//         for (var n = 0; n < array.GetLength(1); n++)
//         {
//             if (array[i, j] >= array[i, n])
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array[i, n];
//                 array[i, n] = temp;
//             }
//         }
// Console.WriteLine("Новый массив: ");
// PrintArray(array);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой
// элементов: 1 строка.

// int line = 4;
// int columns = 4;
// int sum = 0;
// Random rand = new Random();
// int[,] matrix = new int[line, columns];
// Random rand1 = new Random();
// int[] matrix1 = new int[line];
// for (int i = 0; i < matrix.GetLength(0); i++)  
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)     
//     {
//         matrix[i, j] = rand.Next(1, 9);
//         sum = sum + matrix[i,j];
//         Console.Write($"{matrix[i, j]}\t");   
//     }
//     matrix1[i] = sum;
//     Console.WriteLine();
//     sum = 0;
// }

// Console.WriteLine();
// int minLine = matrix1[0];
// int minSum = 1;
// for (int n = 1; n < line; n++)
// {
//     if (matrix1[n] < minLine)
//     {
//         minLine = matrix1[n];
//         minSum = n++;
//     }
// }
// Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minSum}");


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int line = 2;
// int columns = 2;
// Random rand = new Random();
// Console.WriteLine("Первый массив: ");
// int[,] matrix = new int[line, columns];
// for (int i = 0; i < matrix.GetLength(0); i++)  
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)     
//     {
//         matrix[i, j] = rand.Next(1, 9);
//         Console.Write($"{matrix[i, j]}\t");   
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Второй массив: ");
// int[,] matrix1 = new int[line, columns];
// for (int i = 0; i < matrix1.GetLength(0); i++)  
// {
//     for (int j = 0; j < matrix1.GetLength(1); j++)     
//     {
//         matrix1[i, j] = rand.Next(1, 9);
//         Console.Write($"{matrix1[i, j]}\t");   
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Произведение массивов: ");
// int[,] matrix2 = new int[line, columns];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix1.GetLength(1); j++)
//     {
//         for (int n = 0; n < matrix1.GetLength(0); n++)
//         {
//             matrix2[i,j] += matrix[i,n] * matrix1[n,j];
//         }
//         Console.Write($"{matrix2[i, j]}\t");
//     }
//     Console.WriteLine();
// }



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]}\t");
//         }
//         System.Console.WriteLine();

//     }
// }

// int Quick(string message)
// {
//     System.Console.Write(message);
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// int[,] FillSpiral(int size)
// {
//     int elements = size * size;
//     int checkElement = 0;
//     int start = 0;
//     int[,] array = new int[size, size];
//     while (checkElement < elements)
//     {
//         for (int i = start; i < size; i++)
//         {
//             checkElement++;
//             array[start, i] = checkElement;
//         }
//         for (int i = start + 1; i < size; i++)
//         {
//             checkElement++;
//             array[i, size - 1] = checkElement;
//         }
//         for (int i = size - 2; i >= start; i--)
//         {
//             checkElement++;
//             array[size - 1, i] = checkElement;
//         }
//         for (int i = size - 2; i >= start + 1; i--)
//         {
//             checkElement++;
//             array[i, start] = checkElement;
//         }
//         size -= 1;
//         start += 1;
//     }
//     return array;
// }

// int[,] matrix = FillSpiral(Quick("Задать матрицу: "));
// PrintMatrix(matrix);