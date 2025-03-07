namespace HelloWorld.Primitive_Data;

class @enum
{
    enum nivelDeDificuldade
    {
        Baixo = 0,
        Medio = 1, // sem números duplicados
        Alto = 2
    }

    static void play()
    {
        nivelDeDificuldade nivel = nivelDeDificuldade.Medio;

        int nivelInteiro = (int)nivel;

        Console.WriteLine(nivel);
        Console.WriteLine(nivelInteiro);
    }
}
