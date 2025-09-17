using System;
//Calculo del area de un circulo.
class Program //Clase
{
    static void Main(string[] args)//Main
    {
        //---------- Area de un circulo -------------------
        Console.WriteLine("\n-- Área del Circulo --");
        Console.Write("Ingresa el radio: ");

        //Guarda el radio
        var radio = Convert.ToDouble(Console.ReadLine());

        var areaCirc = Math.PI * Math.Pow(radio, 2);//calculo
        var formateo = areaCirc.ToString("0.00");
        Console.WriteLine($"El área del circulo es: {formateo}");
    }
}
