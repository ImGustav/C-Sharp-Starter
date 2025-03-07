using System.Text;

namespace HelloWorld.Concatenation;

internal class textOperations
{
    static void strings()
    {
        string texto1 = "First phrase.";
        string texto2 = "Second phrase";
        string paragrafo = texto1 + " " + 7 + "" + true + "" + texto2;

        string caminho = @"C:\teste"; // ignora o caracter de scape "\t"
        string caminhoAlt = "C:\\teste\\Gustavo\\Documentos\\keys";

        string paragrafo2 = $"Primeira frase:{texto1}\nSegunda frase:{texto2}\n{7}\n{true}"; // string interpolation

        Console.WriteLine(paragrafo);
        Console.WriteLine(caminho);
        Console.WriteLine(paragrafo2);

        StringBuilder stringBuilder = new StringBuilder("Valor1: ");

        stringBuilder.Append(paragrafo);
        stringBuilder.Append(paragrafo2);

        string resultado = stringBuilder.ToString();
    }

    static void chars()
    {
        char letter1 = 'a';
        char letter2 = 's';
        string paragrafo = letter1 + "oi";
    }

    static void dinamicPages()
    {
        string text = "O usuário {0} gosta do número {1}";

        string resultado = string.Format(text, "Vinicius", 13);

        Console.WriteLine(resultado);
    }
}
