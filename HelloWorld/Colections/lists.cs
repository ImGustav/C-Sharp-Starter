namespace HelloWorld.Colections;

class lists
{
    static void Lists()
    {
        List<int> inteiros = new List<int>();

        inteiros.Add(1);
        inteiros.Add(3);
        inteiros.Add(4);

        Console.WriteLine(inteiros.Count); // Sem elementos = 0
        Console.WriteLine(inteiros[0]);

        inteiros.Remove(4); // remove número 4

        inteiros.Remove(inteiros[1]); // remove o valor alocado no índice 1
        inteiros.RemoveAt(1); // remove o valor do índice diretamente
        inteiros.Clear();

        int firstElement = inteiros.First();
        int lastElement = inteiros.Last();
        int elementAt = inteiros.ElementAt(3); // pega o elemento selecionado pelo índice
    }

    static void moreLists()
    {
        List<string> strings = new List<string>();

        strings.Add("Hello");
        strings.Add("World");
        strings.Add("World");
        strings.Add("World");

        string resultado = string.Join("", strings);

        List<decimal> @decimal = new List<decimal>();

        @decimal.Add(12.23m);

        List<bool> @bool = new List<bool>();

        @bool.Add(true);

        List<object> @object = new List<object>();

        @object.Add(true);
        @object.Add(7);
        @object.Add("23");

    }
}