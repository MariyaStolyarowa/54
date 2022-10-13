//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
void FillArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(0, 100);
        }
}
void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($" {Array[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}   
Console.Clear();
Console.Write("Введите число строк массива m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива n = ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] Array1= new int[m,n];
FillArray(Array1);
PrintArray(Array1);
for (int i = 0; i < Array1.GetLength(0); i++)
    {
        for (int j = 0; j < Array1.GetLength(1)-1; j++)
        {
            {
                for (int k=0; k<Array1.GetLength(1)-1-j; k++)
                {
                     if (Array1[i,k]<Array1[i,k+1])
                    {
                    int temp=Array1[i,k];
                    Array1[i,k]=Array1[i,k+1];
                    Array1[i,k+1]=temp;
                    }
                }
            }
        }
    }
Console.WriteLine();
PrintArray(Array1);