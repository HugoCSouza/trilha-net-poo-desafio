namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // Pode adicionar inicializações específicas da classe Nokia aqui, se necessário
        }
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