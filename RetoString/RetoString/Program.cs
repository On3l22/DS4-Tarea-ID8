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
        string palabra = "Bitín"; //Palabra a buscar
        string texto = File.ReadAllText(ruta); //Lee el archivo en busca de la palabra
        string resultado;

        //------------- Creacion y conversion ------------
        //== 1.String.Concat() =======
        //If para verificar si se encontra la palabra
        if (texto.Contains(palabra))
        {
            resultado = string.Concat(palabra, " ", "Explorador");
            Console.WriteLine($"_________________1.String.Concat():Une el nombre del personaje Btin con la palabra explorador y muestra el resultado\n {resultado}\n");
        }
        else
        {
            Console.WriteLine($"__________________La palabra {palabra} no se encontro.");
        }

        //== 2.string.Join() ========
        string[] oraciones = texto.Split('.');
        resultado = string.Join(" | ", oraciones);
        Console.WriteLine($"_____________________2.String.Join():Separa el cuento en oraciones por '.' y unelas nuevamente con el separador '|'\n {resultado}\n");

        //== 3.string.Format() ======
        int cantC = texto.Length;
        int cantP = texto.Split(' ').Length;
        Console.WriteLine($"_______________3.String.Format(): Muestra en consola 'El cuento tiene x caracteres y y palabras' Usando formato\n El cuento tiene {cantC} caracteres y {cantP} palabras\n");

        //== 4.string.Interpolation() =====
        string busca = "descubrir qué había al otro lado del gran firewall";
        Console.WriteLine($"_____________________4.String.Interpolation: Use interpolacion para mostrar 'El protagonista es [nombre] y busca [meta]'\nEl protagonista es {palabra} y busca {busca}\n");

        //== 5.string.ToString() =======
        string longitud = "La longitud del texto es " + Convert.ToString(texto.Length);
        Console.WriteLine($"____________________5. String.ToString(): Convertir un numero a cadena y muestralo concatenado con un mensaje.\n{longitud}\n");

        //---------- Busqueda y localizacion -------------
        //== 6. IndexOf() ==========
        int primeraMundo = ruta.IndexOf("mundo");

        Console.WriteLine("________________ 6. IndexOf(): Encuentre la primera posicion donde aparece la palabra 'Mundo'\n");
        if (primeraMundo != -1)
        {
            Console.WriteLine($"La palabra 'mundo' aparece primero en la posición {primeraMundo}\n");
        }
        else
        {
            Console.WriteLine("La palabra 'mundo' no aparece en el cuento.");
        }
            

        //== 7. LastIndexOf() ========
        int ultimaCeros = ruta.LastIndexOf("ceros");

        Console.WriteLine("__________________7. LastIndexOf(): Encuentre la ultima vez que aparece la palabra 'ceros'");
        if (ultimaCeros != -1)
        {
            Console.WriteLine($"La palabra 'ceros' aparece por última vez en la posición {ultimaCeros}\n");
        }
        else
        {
            Console.WriteLine("La palabra 'ceros' no aparece en el cuento.\n");
        }


        //== 8. Contains() ==========
        Console.WriteLine("__________________8. Contains(): Verifica si el cuento menciona al palabra 'nube' y muestra un mensaje de confirmacion\n");
        if (ruta.Contains("Nube"))
        {
            Console.WriteLine("El cuento menciona la palabra 'Nube'.\n");
        }
        else
        {
            Console.WriteLine("La palabra 'Nube' no se encontró en el cuento.\n");
        }


        //== 9. StartsWith() =========
        Console.WriteLine("____________________ 9. StartsWith(): Comprueba si el cuento inicia con 'En el vasto universo'\n");
        if (ruta.StartsWith("En el vasto universo"))
        {
            Console.WriteLine("El cuento inicia con 'En el vasto universo'.\n");
        }
        else
        {
            Console.WriteLine("El cuento no inicia con 'En el vasto universo'.\n");
        }


        //== 10. EndsWith() =========
        Console.WriteLine("___________________10. EndsWith(): Comprueba si el cuento termina con 'ceros y uno.'\n");
        if (ruta.Trim().EndsWith("ceros y unos."))
        {
            Console.WriteLine("El cuento termina con 'ceros y unos.'.\n");
        }
        else
        {
            Console.WriteLine("El cuento no termina con 'ceros y unos.'.\n");
        }

        //--------- Manipulacion de contenido -------------
        // 11. Substring()
        // Extraer "ciudades luminosas"
        int inicio = texto.IndexOf("ciudades luminosas");
        string extraido = texto.Substring(inicio, "ciudades luminosas".Length);
        Console.WriteLine($"________________ 11. Substring(): Extrae la palabra 'Ciudades luminosas' del texto original.\n {extraido}\n");

        // 12. Remove()
        string resto = texto.Remove(0, 15);
        Console.WriteLine($"__________________12. Remove(): Elimina las primeras 15 caracteres del cuento y muestra el resto.\n {resto}\n");

        // 13. Replace()
        string reemplazo = texto.Replace("Bitín", "ProgramaX");
        Console.WriteLine($"______________13. Replace(): Sustituye todas las apariciones de Bitin por ProgramaX.\n {reemplazo}\n");

        // 14. Insert()
        int posFirewall =texto.IndexOf("firewall");
        if (posFirewall != -1)
        {
            string insertado = texto.Insert(posFirewall + "firewall".Length, " (IMPORTANTE)");
            Console.WriteLine($"________________14. Insert(): Inseta la palabra 'IMPORTANTE' despues de la palabra 'Firewall.'\n {insertado}\n");
        }

        // 15. PadLeft()
        string nombre = "Bitín";
        string padIzquierda = nombre.PadLeft(10, '*');
        Console.WriteLine($"__________________15. PadLeft(): Rellena la palabra Bitin a la izquierda con '*' hasta tener 10 caracteres.\n {padIzquierda}\n");

        // 16. PadRight()
        string nube = "Nube";
        string padDerecha = nube.PadRight(12, '-');
        Console.WriteLine($"_________________16. PadRight(): Rellena la palabra Nube a la derecha con '-' hasta tener 12 caracteres.\n {padDerecha}\n");

        // 17. Trim()
        string conEspacios = "  firewall  ";
        Console.WriteLine($"________________17. Trim(): Toma un fragmento con espacio extra 'firewall' y elimina los espacios.\n '{conEspacios.Trim()}'\n");

        // 18. TrimStart()
        string inicioEspacios = "   Mundo binario";
        Console.WriteLine($"_________________18. TrimStart(): Elimina solo los espacios iniciales de la frase 'mundo binario'\n '{inicioEspacios.TrimStart()}'\n");

        // 19. TrimEnd()
        string finEspacios = "Bitín explorador   ";
        Console.WriteLine($"_________________19. TrimEnd(): Elimina solo los espacios finales de la frase 'Bitin explorador\n '{finEspacios.TrimEnd()}'\n");

        // 20. Split()
        string[] palabras = texto.Split(' ');
        Console.WriteLine("________________20. Split(): Divide el cuento en palabras individuales y muestra las primeras 10.");
        for (int i = 0; i < Math.Min(10, palabras.Length); i++)
        {
            Console.WriteLine(palabras[i]);
        }

        //------ Comparacion y validacion ---------------
        // 21. Equals()
        string palabra1 = "Nube";
        string palabra2 = "nube";
        bool iguales = palabra1.Equals(palabra2); // sensible a mayúsculas/minúsculas
        Console.WriteLine($"___________________21. Equals(): Compara si nube y Nube sin iguales (sensible a mayusuclas y minusculas). \n ¿'Nube' y 'nube' son iguales?: {iguales}");

        // 22. Compare()
        // Devuelve: <0 si 'Bitín' < 'Firewall', 0 si iguales, >0 si 'Bitín' > 'Firewall'
        Console.WriteLine("__________________22. Compare(): Compara alfabeticamente Bitin y Firewall e indica cual va primero. ");
        int comparacion = String.Compare("Bitín", "Firewall");
        if (comparacion < 0)
            Console.WriteLine("Alfabéticamente 'Bitín' va antes que 'Firewall'.\n");
        else if (comparacion > 0)
            Console.WriteLine("Alfabéticamente 'Firewall' va antes que 'Bitín'.\n");
        else
            Console.WriteLine("'Bitín' y 'Firewall' son iguales.\n");

        // 23. CompareTo()
        // Igual que Compare, pero llamado directamente sobre el objeto string
        int resultado2 = "Nube".CompareTo("Cielo");
        Console.WriteLine("_________________23. CompareTo(): Aplica compareTo entre nube y cielo y explica el resultado numerico");
        Console.WriteLine($"Resultado de 'Nube'.CompareTo('Cielo'): {resultado}");
        // Explicación
        if (resultado2 < 0)
            Console.WriteLine("'Nube' va antes que 'Cielo'.\n");
        else if (resultado2 > 0)
            Console.WriteLine("'Cielo' va antes que 'Nube'.\n");
        else
            Console.WriteLine("'Nube' y 'Cielo' son iguales.\n");

        // 24. IsNullOrEmpty()
        string cadenaVacia = "";
        Console.WriteLine($"______________24. IsNullOrEmpty(): Declara una cadena vacia y verifica si lo es.\n ¿La cadena está vacía?: {string.IsNullOrEmpty(cadenaVacia)} \n");

        // 25. IsNullOrWhiteSpace()
        string cadenaEspacios = "   ";
        Console.WriteLine($"________________25. IsNullOrWhiteSpace(): Declara una cadena con solo espacios y valida el resultado.\n ¿La cadena tiene solo espacios o está vacía?: {string.IsNullOrWhiteSpace(cadenaEspacios)}\n");

        //------ Conversion en mayusculas ---------------

        // 26. ToLower() → convierte todo el cuento a minúsculas
        string cuentoMinusculas = texto.ToLower();
        Console.WriteLine("___________________26. ToLower(): Convierte todo el cuento a miniscula. \nCuento en minúsculas:");
        Console.WriteLine(cuentoMinusculas);
        Console.WriteLine();

        // 27. ToUpper() → convierte todo el cuento a mayúsculas
        string cuentoMayusculas = texto.ToUpper();
        Console.WriteLine("_______________27. ToUpper(): Convierte todo el cuento a mayusucla. \nCuento en mayúsculas:");
        Console.WriteLine(cuentoMayusculas);
        Console.WriteLine();

        // 28. ToLowerInvariant() → convierte la palabra "Nube" a minúsculas
        string palabraNube = "Nube";
        string nubeMinuscula = palabraNube.ToLowerInvariant();
        Console.WriteLine($"_______________28. ToLowerInvariant(): Conveirte la palabra NUBE a minusculas \n'Nube' en minúsculas (Invariant): {nubeMinuscula}\n");

        // 29. ToUpperInvariant() → convierte la palabra "Bitín" a mayúsculas
        string palabraBitin = "Bitín";
        string bitinMayuscula = palabraBitin.ToUpperInvariant();
        Console.WriteLine($"_______________29. ToUpperInvariant(): Convierte la palabra Bitin a mayusculas con ToUpperInvariant. \n'Bitín' en mayúsculas (Invariant): {bitinMayuscula}");

    }
}


