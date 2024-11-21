int fil = 5;
int col = 3;
int[][] mat = new int[fil][];

for (int f = 0; f < mat.Length; f++)
{
    mat[f] = new int[col];
}
    
for (int f = 0; f < mat.Length; f++)
{
    for (int c = 0; c < mat[0].Length; c++)
    {
        Console.WriteLine($"En fila {f}, ingrese numero {c}");
        mat[f][c] = Convert.ToInt32(Console.ReadLine());
    }
}

for (int f = 0; f < mat.Length; f++)
{
    for (int c = 0; c < mat[0].Length; c++)
    {
        Console.Write($"{mat[f][c]}, ");
    }
    Console.WriteLine();
}
Console.WriteLine();
