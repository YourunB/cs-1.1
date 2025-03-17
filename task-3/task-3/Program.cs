static void InArray(int[] i)
{
    Console.WriteLine(" [0] = {0} [1] = {1}", i[0], i[1]);
}

static void Main()
{
    int[][,] imyJaggedArray1 = new int[3][,]
    {
        new int[,] { {1,2}, {3,4} },
        new int[,] { {5,6}, {4,6}, {7,8} },
        new int[,] { {0,0}, {0,0}, {0,0} }
    };

    Console.WriteLine(imyJaggedArray1.Rank); // размерность созданного массива
    Console.WriteLine(imyJaggedArray1.Length); // число элементов в созданном массиве
    Console.WriteLine("{0}", imyJaggedArray1[0][1, 0]); // вывод значения элемента [1,0] из первого элемента одномерного массива
}

Main();