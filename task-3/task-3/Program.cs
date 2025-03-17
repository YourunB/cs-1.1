static void Main()
{
    int[][,] imyJaggedArray1 = new int[3][,]
    {
        new int[,] { {1,2}, {3,4} },
        new int[,] { {5,6}, {4,6}, {7,8} },
        new int[,] { {0,0}, {0,0}, {0,0} }
    };

    Console.WriteLine(imyJaggedArray1.Rank);
    Console.WriteLine(imyJaggedArray1.Length);
    Console.WriteLine("{0}", imyJaggedArray1[0][1, 0]);
}

Main();