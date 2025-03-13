namespace HelloWorld.Colections;

class dictionary
{

    static void example()
    {
        Dictionary<int, string> dicionario = new Dictionary<int, string>(); // funciona diferente de um indice de uma lista

        dicionario.Add(1 ,"William");
        dicionario.Add(3 ,"Luana");
        dicionario.Add(134 ,"Jennifer");
        dicionario.Add(190 ,"Samuel");

        string value = dicionario[150];
        bool exist = dicionario.ContainsKey(30);


        Console.WriteLine(exist);
        Console.WriteLine(value);
    }

    static void example2()
    {
        Dictionary<string, int> dicionario1 = new Dictionary<string, int>();

        dicionario1.Add("kil", 1);
        dicionario1.Add("Kura", 20);
        dicionario1.Add("Gon", 1);
        dicionario1.Add("leorio", 130);

        int value2 = dicionario1["Gon"];
        bool exist2 = dicionario1.ContainsKey("Framengo");

        Console.WriteLine(value2);
        Console.WriteLine(exist2);
    }

}
