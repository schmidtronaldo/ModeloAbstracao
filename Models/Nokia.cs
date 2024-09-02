namespace Abstracao.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Digite o nome do app Nokia");
            nomeApp = Console.ReadLine();
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Nokia");
        }
    }
}
