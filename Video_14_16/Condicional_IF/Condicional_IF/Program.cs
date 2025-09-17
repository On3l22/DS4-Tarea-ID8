/*
Video 16 de platzi
Uso de la sentencia IF, Switch y bucle while para crear un juego.

Autor: Onel Magallón 
ID: 8
 */

using System.Linq.Expressions;
System.Random r = new System.Random();

string message = "";
string control = "menu";
int num = 0;
string op = "";

//Try catch para controlar errores
try
{
    //While para validar y luego ejecutar
    while (true)
    {
        //Variables
        int totalJugador = 0;
        int totalDealer = r.Next(1, 12);

        //Menu usando switch
        switch (control)
        {
            case "menu":
                Console.WriteLine("-------- Bienvenido al CASINO ---------");
                Console.WriteLine("Escribe '21' para comenzar a jugar");
                control = Console.ReadLine();
                break;

            case "21":
                //Bucle para ejecutar y validar
                do
                {
                    num = r.Next(1, 12);
                    totalJugador = totalJugador + num;
                    Console.WriteLine("\n--\nToma tu carta jugador,");
                    Console.WriteLine($"Te salio el numero: {num}");
                    Console.WriteLine("Deseas otra carta?");
                    op = Console.ReadLine();
                }while(op == "si" || op == "Si" || op == "yes");
                Console.WriteLine("\n");
                //If para manejar los variantes
                if (totalJugador > totalDealer && totalJugador <= 21)
                {
                    message = $"Venciste al dealer, felicidades\nJ:{totalJugador}\nD:{totalDealer}";
                    control = "menu";
                }
                else if (totalJugador > 21)
                {
                    message = "Perdite vs el dealer, te pasaste de 21";
                    control = "menu";
                }
                else if (totalJugador <= totalDealer)
                {
                    message = $"Perdiste vs el dealer, lo siento. \nJ:{totalJugador}\nD:{totalDealer}";
                    control = "menu";
                }
                else
                {
                    message = "Condicion no valida";
                }

                //Mensaje final
                Console.WriteLine(message);
                break;

            default: //En caso de no cumplirse ningun caso
                Console.WriteLine("Valor ingresado no valido en el CASINO");
                control = "menu";
                break;
        }
    }
}
catch (Exception)
{
    Console.WriteLine("Ups, algo no salio bien.");
}

