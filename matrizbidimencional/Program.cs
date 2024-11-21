using System;

Random r = new Random();   
int fil = 5, respuesta1;
int col = 3, respuesta2;
int[,] mat2 = new int[fil,col];

Console.Write("Minimo: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Maximo: ");
int max = int.Parse(Console.ReadLine());


for (int f = 0; f < mat2.GetLength(0); f++)
{
    for (int c = 0; c < mat2.GetLength(1); c++)
    {
        
        mat2[f, c] = r.Next(min,max+1);
    }
}

for (int f = 0; f < mat2.GetLength(0); f++)
{
    for (int c = 0; c < mat2.GetLength(1); c++)
    {
        Console.Write($"{mat2[f,c]}, ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int f = 0; f < mat2.GetLength(0); f++)
{
    int sum = 0;
    for (int c = 0; c < mat2.GetLength(1); c++)
    {
        sum += mat2[f, c];
    }
    Console.WriteLine($"La suma de fila {f} es: {sum}");
}
Console.WriteLine();

for (int c = 0; c < mat2.GetLength(1); c++)
{
    int sum = 0;
    for (int f = 0; f < mat2.GetLength(0); f++)
    {
        sum += mat2[f, c];
    }
    Console.WriteLine($"La suma de fila {c} es: {sum}");
}
Console.WriteLine();






