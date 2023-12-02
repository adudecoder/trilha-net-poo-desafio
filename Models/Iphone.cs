using System;

namespace DesafioPOO.Models
{
    // Classe filha Iphone
    public class Iphone : Smartphone
    {
        // Construtor da classe Iphone
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // TODO: Implementar lógica específica, se necessário
        }

        // Implementação do método abstrato
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no iPhone...");
            // Lógica específica para instalar aplicativo em um iPhone
        }
    }
}
