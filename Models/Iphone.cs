namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {}
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp, int tamanho)
        {
            int memoria = valorMemoria();
            if (tamanho > memoria)
            {
                Console.WriteLine("Aplicativo Muito grande para o sistema \n");
            }
            else
            {
                Console.WriteLine("Instalando aplicativo ...");
                Console.WriteLine($"Aplicativo {nomeApp} Instalado \n \n");
            }
        }
    }
}