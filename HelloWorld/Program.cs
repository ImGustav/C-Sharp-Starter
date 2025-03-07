using HelloWorld;
using HelloWorld.motocycle; // importando namespace

class Program
{
    static void Main()
    {
        Car impala = new Car();
        Motocycle harley = new Motocycle();

        impala.Ligar();
        impala.Turbo();
        impala.Desligar();

        harley.acelerar();     

        var name = "miamoto";

        string Vectra;
        var apolo; 
    }
}