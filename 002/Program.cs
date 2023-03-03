// Задать двумерный массив следующим правилом: Aₘₙ = m+n
void PrintIn(string message)
{
    Console.WriteLine(message);
}

void FillMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        {for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i,j]=i+j;
            }
        
    }
}

void PrintMatrix(int[,] arr)
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
int[,] matrix=new int[hight,lenght];
FillMatrix(matrix);
PrintMatrix(matrix);
