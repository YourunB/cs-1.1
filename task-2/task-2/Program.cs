static void Main()
{
    int[,] imyArray1 = new int[6, 3];
    int[,] imyArray2 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

    Console.WriteLine("Всего элементов = {0}  первая размерность = {1} вторая размерность = {2}", imyArray1.Length, imyArray1.GetLength(0), imyArray1.GetLength(1));
    Console.WriteLine("Всего элементов = {0}  первая размерность = {1} вторая размерность = {2}", imyArray2.Length, imyArray2.GetLength(0), imyArray2.GetLength(1));
}

Main();