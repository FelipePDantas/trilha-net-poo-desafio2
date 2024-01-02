namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string modelo { get; set; }

        public string imei{ get; set; }

        public int memoria { get; set; }
    
        public Smartphone(string numero,string modelo,string imei,int memoria)
        {
            Numero = numero;
            modelo = modelo;
            imei = imei;
            memoria = memoria;
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