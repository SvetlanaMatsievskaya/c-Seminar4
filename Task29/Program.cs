
void FillArray(int[] matr)
{
  for (int i = 0; i < matr.Length; i++)
  {
    matr[i] = new Random().Next(1,100);
  }
    
}
void PrintArray(int[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write($"{matrix[i]} ");
    }
}
int [] array = new int[8];
FillArray(array);
PrintArray(array);

Console.WriteLine();

int [] array2 = {2,4,6,8,9,0,4,9};
PrintArray(array2);