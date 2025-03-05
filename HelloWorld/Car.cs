namespace HelloWorld;

class Car
{

    public void Ligar()
    {
        Console.WriteLine("Carro ligado!");
    }

    public void Desligar()
    {
        Freiar();
        Console.WriteLine("Carro desligado");
    }

    private void Freiar()
    {
        Console.WriteLine("Freiando carro");
    }

    internal void Turbo()
    {

        Console.WriteLine("Agora o bicho vai pegar");
    }

}