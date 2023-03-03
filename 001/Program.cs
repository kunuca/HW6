// Показать двумерный массив размером m×n заполненный вещественными числами
void PrintIn(string message)
{
    Console.WriteLine(message);
}

void FillMatrix(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        {for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i,j]=new Random().Next(-10,10);
            }
        
    }
}

void PrintMatrix(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"\t {arr[i,j]}");
    }
        Console.WriteLine();
    }
}


PrintIn("Введите ширину матрицы");
int lenght=int.Parse(Console.ReadLine()!);
PrintIn("Введите высоту матрицы");
int hight=int.Parse(Console.ReadLine()!);
double[,] matrix=new double[lenght,hight];
FillMatrix(matrix);
PrintMatrix(matrix);
