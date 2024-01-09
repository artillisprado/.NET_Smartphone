using System;
using System.Collections.Generic;

// Classe abstrata Smartphone
abstract class Smartphone
{
    public string Numero { get; set; }
    public string Modelo { get; set; }
    public string IMEI { get; set; }
    public int Memoria { get; set; }

    public abstract void Ligar();
    public abstract void ReceberLigacao();
    public abstract void InstalarAplicativo(string nome);
}

// Classe concreta Nokia que herda de Smartphone
class Nokia : Smartphone
{
    public override void Ligar()
    {
        Console.WriteLine("Nokia ligando...");
    }

    public override void ReceberLigacao()
    {
        Console.WriteLine("Nokia recebendo ligação...");
    }

    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Nokia instalando aplicativo: {nome}");
    }
}

// Classe concreta Iphone que herda de Smartphone
class Iphone : Smartphone
{
    public override void Ligar()
    {
        Console.WriteLine("iPhone ligando...");
    }

    public override void ReceberLigacao()
    {
        Console.WriteLine("iPhone recebendo ligação...");
    }

    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"iPhone instalando aplicativo: {nome}");
    }
}

class Program
{
    static void Main()
    {
        // Exemplo de uso
        Nokia nokia = new Nokia
        {
            Numero = "123456789",
            Modelo = "Nokia XYZ",
            IMEI = "123456789012345",
            Memoria = 64
        };

        Iphone iphone = new Iphone
        {
            Numero = "987654321",
            Modelo = "iPhone ABC",
            IMEI = "987654321098765",
            Memoria = 128
        };

        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Jogo1");

        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("App2");
    }
}

