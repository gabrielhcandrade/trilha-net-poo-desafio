namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeapp)
        {
            Console.WriteLine($"Instalando: {nomeapp}");
            Console.WriteLine($"Aplicativo Instalado com sucesso. Agora você já pode usar o {nomeapp} no Iphone");

        }
    }
}