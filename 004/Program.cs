// Написать программу, которая обменивает элементы первой строки и последней строки
void PrintIn(string message)
{
    Console.WriteLine(message);
}

void FillMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        {for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i,j]=new Random().Next(0,10);
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
Console.WriteLine();
int[] array=new int[lenght];
for (int i = 0; i < matrix.GetLength(1); i++)
{ array[i]=matrix[hight-1,i];
  matrix[hight-1,i]=matrix[0,i];  
  matrix[0,i]=array[i];
}
//for (int i = 0; i < matrix.GetLength(0); i++)
 //  {
    
 //  }
PrintMatrix(matrix);