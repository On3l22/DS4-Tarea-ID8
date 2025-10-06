using System;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using UsoLINQ;

//================== USO BASICO ===================
//Uso sencillo de linq para hacer consulta
//Lista de frutas
var frutas = new string[] { "Sandia", "Fresa", "Mango", "Mango de azucar", "Mango verde" };

//Lista que guarda las frutas encontradas
var mangoList = frutas.Where(p=> p.StartsWith("Mango")).ToList();
mangoList.ForEach(p=> Console.WriteLine(p));





//============== USO AVANZADO  ====================
LinqQueries queries = new LinqQueries();//Nueva instancia de la clase consulta

//Metodo -> Imprimir datos en consola
void printfValues(IEnumerable<Book> listBooks)
{
    //Formato de impresion
    Console.WriteLine("{0, -60} {1, 15} {2, 15}\n ", "Titulo", "N. Paginas", "Fecha de publicacion");
    foreach(var item in listBooks)
    {
        Console.WriteLine("{0, -60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}

//Imprimir toda la coleccion
Console.WriteLine("------- TODOS LOS LIBROS");
printfValues(queries.TodaLaCollection());//Impresion 
Console.WriteLine("\n\n\n\n\n");

//Imprimir libros publicados en el año 2000
Console.WriteLine("------- LIBROS PUBLICADOS DESPUES DEL 2000");
printfValues(queries.booskBeforeOf2000());//Impresion
Console.WriteLine("\n\n\n\n\n");

//Imprimir libros del 2000 usando Query expresion
Console.WriteLine("------- USO DE QUERY EXPRESION");
printfValues(queries.booksBeforeOf200QryExp());
Console.WriteLine("\n\n\n\n\n");

//Imprimir libros con 250 paginas y con el titulo Action
Console.WriteLine("------- LIBROS CON 250 PAGINAS Y QUE CONTENGA ACTION");
printfValues(queries.books250pagANDtileAction());
Console.WriteLine("\n\n\n\n\n");

//Imprimir Verificar si los libros tiene status
Console.WriteLine("------- USO DE ALL");
Console.WriteLine("Todos los libros tiene status?: "+ queries.UseOfOperatorALL());
Console.WriteLine("\n\n\n\n\n");

//Imprimir si un libro fue publicado en el 2005
Console.WriteLine("------- USO DE ANY");
Console.WriteLine("Algun libro fue publicado en el 2005?: " + queries.UseOfOperatorANY());
Console.WriteLine("\n\n\n\n\n");

//Imprimir los libros con categoria Python
Console.WriteLine("------- USO DE CONTAINS");
printfValues(queries.booksCatPython());
Console.WriteLine("\n\n\n\n\n");

//Imprimir los libros con categoria Java y otdenarlo por nombre usando OrderBy
Console.WriteLine("------- USO DE ORDER BY");
printfValues(queries.booksCatJavaOrderByName());
Console.WriteLine("\n\n\n\n\n");

//Imprimir los libros que tenga mas de 450 paginas ordenados descendentemente
Console.WriteLine("------- USO DE ORDER BY DECENDING");
printfValues(queries.booksMore450PagOrderByDes());
Console.WriteLine("\n\n\n\n\n");

//Imprimir los tres ultimos libros
Console.WriteLine("------- USO DE TAKE");
printfValues(queries.threeBooksJavaOrderByDate());
Console.WriteLine("\n\n\n\n\n");

//Imprimir el tercer y cuarto libro con mas de 400 paginas
Console.WriteLine("------- USO DE SKIP");
printfValues(queries.thirdAndFourthBooksMore400pages());
Console.WriteLine("\n\n\n\n\n");

//Imprimir el tercer y cuarto libro con mas de 400 paginas
Console.WriteLine("------- USO DE SELECCION DINAMICA");
printfValues(queries.ThreeBooksInCollection());
Console.WriteLine("\n\n\n\n\n");