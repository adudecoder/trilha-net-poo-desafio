using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        // Criando instâncias das classes Nokia e Iphone
        Nokia nokia = new Nokia("123456789", "Nokia Modelo X", "IMEI123", 64);
        Iphone iphone = new Iphone("987654321", "iPhone Modelo Y", "IMEI456", 128);

        // Realizando operações com os smartphones
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
