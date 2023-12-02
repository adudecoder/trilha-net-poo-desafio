using System;

namespace DesafioPOO.Models
{
    // Classe abstrata Smartphone
    public abstract class Smartphone
    {
        // Propriedade pública
        public string Numero { get; set; }
        // Propriedade privada
        private string Modelo { get; set; }
        // Propriedade privada
        private string Imei { get; set; }
        // Propriedade privada
        private int Memoria { get; set; }

        // Construtor da classe abstrata
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        // Método abstrato a ser implementado nas classes filhas
        public abstract void InstalarAplicativo(string nomeApp);

        // Métodos comuns a todos os smartphones
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
    }
}
