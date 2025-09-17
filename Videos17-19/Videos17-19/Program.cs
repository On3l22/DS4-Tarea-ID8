using System.ComponentModel.DataAnnotations;
using System.Drawing;

//Variables
int totalJugador = 0;
int totalDealer = 0;
int num = 0;
int platziCoins = 0;
string message = "";
string controlOtraCarta = "";
string switchControl = "menu";

string verificarEntrada;

System.Random random = new System.Random();

//Blackjack, Juntar 21 pidiendo, en casa de pasarte de 21 pierdes.
//cartas o en caso de tener menos
//de 21 igual tener mayor puntuación que el dealer

try //Try catch para atrapar errores inesperados
{
    while (true) //While que se repite siempre
    {
        //Mensaje de bienvenida
        Console.WriteLine("///////////////// Bienvenido al CASI..NO ////////////////////");
        Console.WriteLine("¿Cuántos intentos deseas? \n" +
                           "Ingresa un número entero \n" +
                           "!!!! Recuerda que necesitas 1 por ronda !!!");

        bool ctrlError = false;
        do//Bucle que se repite si digita un valor incorrecto
        {
            try
            {
                Console.WriteLine("Numero: ");
                platziCoins = int.Parse(Console.ReadLine());//Lectura de canitdad de monedas
                break;
            }
            catch (Exception ex) {
                ctrlError = true;
                Console.WriteLine("######### El valor ingresado no es un numero entero ##########");
            }
        } while (ctrlError);


        for (int i = 0; i < platziCoins; i++) //Bucle repetir la cantidad de veces que se necesite
        {
            totalJugador = 0;
            totalDealer = 0;

            switch (switchControl)// Manejo de opciones
            {
                case "menu":

                    Console.WriteLine("--- Escriba ‘21’ para jugar al 21 ---");
                    switchControl = Console.ReadLine();
                    i = i - 1;//ignorar el incremento de i cada que se ingresa al menu

                    break;
                case "21":

                    do//Bucle que se repite si el jugador quiere sumar mas cartas
                    {
                        num = random.Next(1, 12);//carta random para el jugador
                        totalJugador = totalJugador + num;//suma la carta al maso del jugador
                        Console.WriteLine("-Toma tu carta, jugador,");
                        Console.WriteLine($"-Te salió el número: {num} ");
                        Console.WriteLine("-¿Deseas otra carta ?");
                        Console.WriteLine("Respuesta: ");
                        controlOtraCarta = Console.ReadLine();//guarda la apcion del jugador 
                        Console.WriteLine("\n");

                    } while (controlOtraCarta == "Si" ||
                             controlOtraCarta == "si" ||
                             controlOtraCarta == "yes");

                    totalDealer = random.Next(14, 23);//Asigna cartas al dealer
                    Console.WriteLine($"[El dealer tiene {totalDealer}]");

                    ///// If para controlar las multiples jugadas que puede obtener el jugador
                    if (totalJugador > totalDealer && totalJugador < 22)//Cuando gana
                    {
                        message = "Venciste al dealer, felicidades";
                        switchControl = "menu";//Vuelve al menu
                    }
                    else if (totalJugador >= 22)//Cuando pierde por que se paso
                    {
                        message = "Perdiste vs el dealer, te pasaste de 21";
                        switchControl = "menu";//Vuelve al menu
                    }
                    else if (totalJugador <= totalDealer)//Cuando pierde por maso menor al del dealer
                    {
                        message = "Perdiste vs el dealer, lo siento";
                        switchControl = "menu";//Vuelve al menu
                    }
                    else
                    {
                        message = "condición no válida";
                    }
                    Console.WriteLine(message+"\n");//Imprime el mensaje
                    break;
                default:
                    Console.WriteLine("Valor ingresa no válido en el CASINO");
                    break;
            }
        }
    }
}
catch(Exception)
{
    Console.WriteLine("############### Ups.. Ocurrio un ERROR inesperado ##################");//Mensaje de error 
}


