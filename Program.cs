using Abstracao.Models;

class Program
{
    static void Main(string[] args)
    {
        MostrarInformacoesSmartphone(new Nokia("123456", "Modelo 1", "111111111", 64));
        MostrarInformacoesSmartphone(new Iphone("4987", "Modelo 2", "222222222", 128));
    }

    static void MostrarInformacoesSmartphone(Smartphone smartphone)
    {
        Console.WriteLine($"{smartphone.GetType().Name}:");
        smartphone.Ligar();
        smartphone.InstalarAplicativo("Aplicativo");
        Console.WriteLine("\n");
    }
}
