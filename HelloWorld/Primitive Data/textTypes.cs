namespace HelloWorld.Primitive_data;

internal class textTypes
{
    static void text()
    {
        // Variáveis do tipo TEXTO
        // char
        // string

        char letra = 'a';
        char numero = '1'; // números são aceitos contanto que esteja em aspas
        char caracter = '@';
        char space = ' ';
        string text = "Never give up";
        char firstLetter = text[0];

        Console.WriteLine(text);
        Console.WriteLine(firstLetter);

        Console.WriteLine("\n My name");

        string myName = "           Gustavo Henrique          ";
        string nomeSemEspaço = myName.Trim(); // Remove os espaços de uma string, retornando o valor

        Console.WriteLine(myName);
        Console.WriteLine(nomeSemEspaço);

        Console.WriteLine("\nStarts With and Ends With");

        bool startsWith = nomeSemEspaço.StartsWith('G'); // identifica case sensitive
        bool startsWith1 = nomeSemEspaço.StartsWith("Gust"); // identifica case sensitive
        bool endsWith = nomeSemEspaço.EndsWith('t');

        Console.WriteLine(startsWith);
        Console.WriteLine(endsWith);
        Console.WriteLine(startsWith1);

        Console.WriteLine("\nReplace");

        string replace = nomeSemEspaço.Replace('a', '4');

        Console.WriteLine(replace);

        Console.WriteLine("\nContains");

        bool contains = text.Contains("Never"); // verifica se o conjunto em aspas está na string

        Console.WriteLine("\nEquals");

        bool equals = text.Equals("Never"); // verifica se o conjunto em aspas na função correponde totalmente com o da string
    }
}