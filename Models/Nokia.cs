namespace DesafioPOO.Models
{
    /// <summary>
    /// Herdar da classe "Smartphone"
    /// Sobrescrever o método "InstalarAplicativo"
    /// </summary>
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void DadosSmartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalado aplicativo {nomeApp} no {Modelo} numero {Numero}");
        }
    }
}