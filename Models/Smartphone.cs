namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo {get; set;}
        private string IMEI {get; set;}
        public int memoria {get; set;}
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero)
        {
            this.Numero = numero;
            this.Modelo = Modelo;
            this.IMEI = IMEI;
            this.memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}