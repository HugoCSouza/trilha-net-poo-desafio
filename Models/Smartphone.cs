namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo {get; set;}
        private string IMEI {get; set;}
        private int Memoria {get; set;}
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            this.Numero = numero;
            this.Modelo = modelo;
            this.IMEI = imei;
            this.Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar(string numeroDestinario)
        {
            Console.WriteLine($"Ligando para {numeroDestinario}... \n \n");
        }
        public void ReceberLigacao(string numeroLigante)
        {
            Console.WriteLine($"O número {numeroLigante} está te ligando");
            Console.WriteLine("Desligou! \n  n");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}