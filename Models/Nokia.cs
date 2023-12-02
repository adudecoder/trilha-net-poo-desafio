using System;

namespace DesafioPOO.Models
{
    // Classe filha Nokia
    public class Nokia : Smartphone
    {
        // Construtor da classe Nokia
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // TODO: Implementar lógica específica, se necessário
        }

        // Implementação do método abstrato
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia...");
            // Lógica específica para instalar aplicativo em um Nokia
        }
    }
}
