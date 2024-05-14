using DesafioPOO.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        Smartphone iphone = new Iphone("9988-6576", "iPhone 15", "123456789123456", 128);
        Smartphone nokia = new Nokia("99345-8934", "Nokia C13", "6543211987654321", 64);

        Console.WriteLine("IPhone:");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");
        Console.WriteLine(iphone.GetModelo());
        Console.WriteLine(iphone.GetIMEI());
        Console.WriteLine(iphone.GetMemoria());

        Console.WriteLine("\nNokia:");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("YouTube");
        Console.WriteLine(nokia.GetModelo());
        Console.WriteLine(nokia.GetIMEI());
        Console.WriteLine(nokia.GetMemoria());
    }
}
