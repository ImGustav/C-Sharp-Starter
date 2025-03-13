namespace HelloWorld.Colections;

class arrays
{
    static void array()
    {
        int[] inteiros = new int[10];
        int[] inteiros2 = [1, 20, 32];

        inteiros[0] = 1;
        inteiros[1] = 15;
        inteiros[2] = 19;

        Console.WriteLine(inteiros.Length);
        Console.WriteLine(inteiros2.Length);

        Console.WriteLine(inteiros[0]);
        Console.WriteLine(inteiros[1]);
        Console.WriteLine(inteiros[2]);
    }

    static void matriz()
    {
        int[,] matr = new int[10, 10];
        int[,,] matr2 = new int[10, 10, 10];

        matr[0, 1] = 10;
        matr[0, 9] = 2;
        matr[0, 1] = 10;
    }
}
