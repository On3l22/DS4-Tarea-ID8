using System;
//Calculo del area de un triangulo.
class Program //Clase
{
    static void Main(string[] args)//Main
    {
        //----------- Area de un rectangulo ---------------
        Console.WriteLine("-- Área del Triangulo --");
        Console.Write("Ingresa la base: ");
        //Guarda la base ingresada
        var baseRec = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la altura: ");
        //Guarda la altura ingresada
        var alturaRec = Convert.ToDouble(Console.ReadLine());

        var areaRec = baseRec * alturaRec; //calculo
        Console.WriteLine($"El área del triangulo es: {areaRec}");
    }
}

