/*
Reto Strings
    Resolucion de los 29 problemas, lectura de documento y creacion de
    archivo txt.

Autor: Onel Magallon
 */
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "cuento.txt"; //nombre del archivo
        string palabra = "Elías"; //Palabra a buscar
        string texto = File.ReadAllText(ruta); //Lee el archivo en busca de la palabra
        string resultado;

        //------------- Creacion y conversion ------------
        //== 1.String.Concat() =======
        //If para verificar si se encontra la palabra
        if (texto.Contains(palabra))
        {
            resultado = string.Concat(palabra ," ","Explorador");
            Console.WriteLine($"1.String.Concat():\n {resultado}\n");
        }
        else
        {
            Console.WriteLine($"La palabra {palabra} no se encontro.");
        }

        //== 2.string.Join() ========
        string[] oraciones = texto.Split('.');
        resultado = string.Join(" | ", oraciones);
        Console.WriteLine($"2.String.Join():\n {resultado}\n");

        //== 3.string.Format() ======
        int cantC = texto.Length;
        int cantP = texto.Split(' ').Length;
        Console.WriteLine($"3.String.Format():\n El cuento tiene {cantC} caracteres y {cantP} palabras\n");

        //== 4.string.Interpolation() =====
        string busca = "Guiar al zorro";
        Console.WriteLine($"4.String.Interpolation: \nEl protagonista es {palabra} y busca {busca}\n");

        //== 5.string.ToString() =======
        string longitud = "La longitud del texto es "+ Convert.ToString(texto.Length);
        Console.WriteLine($"5. String.ToString(): \n{longitud}\n");

        //---------- Busqueda y localizacion -------------
        
    }
}

//--------- Manipulacion de contenido -------------
//------ Conversion en mayusculas ---------------