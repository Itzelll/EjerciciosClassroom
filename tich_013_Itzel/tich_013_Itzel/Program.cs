
int[] arreglo = { -8, 4, 5, 8, 9, 23, 25, 32, 40, 45, 56, 60, 78 };

for (int i = 0; i < arreglo.Length; i++)
{
    int j = 40;
    if (j == arreglo[i])
    {
        Console.WriteLine($"El numero a localizar:40 se encuentra en el indice {i}");
    }        
}