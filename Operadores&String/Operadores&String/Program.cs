using System;
class Program //Clase
{
    static void Main(string[] args)//Main
    {
        //Variables
        bool valor1 = true;
        bool valor2 = false;
        bool valor3 = false;

        var (num1, num2, num3) = (10, 5, 23);

        //---------- Operadores logicos ------------------
        // AND
        bool resultAnd = valor1 && valor2 && valor3;
        Console.WriteLine(resultAnd);

        // OR
        bool resultOr = valor1 || valor2 || valor3;
        Console.WriteLine(resultOr);

        // And y OR
        bool resultAndOr = (valor1 && valor2) || valor3;
        Console.WriteLine(resultAndOr);

        //Negacion
        bool resultNeg = !valor1;
        Console.WriteLine(resultNeg);

        //Xor
        bool resultXor = (valor1 ^ valor2) ^ valor3;
        Console.WriteLine(resultXor);

        //----------- Operadores relacionales -----------------
        // ==
        bool resultado = num1 == num2;
        Console.WriteLine($"{num1} es igual que {num2}: "+ resultado);

        // !=
        resultado = num1 != num2;
        Console.WriteLine($"{num1} es diferente de {num2}: " + resultado);

        // <
        resultado = num1 < num2  ;
        Console.WriteLine($"{num1} es menor que {num2}: " + resultado);

        // >
        resultado = num1 > num2;
        Console.WriteLine($"{num1} es mayor que {num2}: "+resultado);

        // >=
        resultado = num1 >= num2;
        Console.WriteLine($"{num1} es mayor o igual que {num2}: " + resultado);

        // <=
        resultado = num1 <= num2;
        Console.WriteLine($"{num1} es menor o igual que {num2}: " + resultado);

    }
}

