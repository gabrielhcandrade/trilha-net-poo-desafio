namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string Imei { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Random random = new Random();
            string numeroAleatorio = random.Next(10000000, 99999999).ToString();
            Console.WriteLine($"Recebendo ligação. Numero {numeroAleatorio}");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}