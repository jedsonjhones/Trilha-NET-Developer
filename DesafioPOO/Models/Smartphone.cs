namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
        public string GetModelo()
        {
            return $"Modelo: {Modelo}";
        }

        public string GetIMEI()
        {
            return $"IMEI: {IMEI}";
        }

        public string GetMemoria()
        {
            return $"Memoria: {Memoria} GB";
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}