using System.Diagnostics.CodeAnalysis;

int a = 2;
int b = 6;
int[,] array = new int [a,b];

Random r = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = r.Next(1, 10);
    }
}



int[] Arr = new int[array.GetLength(0) * array.GetLength(1)];
int index = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Arr[index++] = array[i, j];
    }
}

int sum = 0;

for (int i = 0; i < Arr.Length; i++)
{
    sum = sum + Arr[i];
}

Console.WriteLine(sum);


