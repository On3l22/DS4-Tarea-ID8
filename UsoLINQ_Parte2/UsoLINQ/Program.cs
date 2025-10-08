using System;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using UsoLINQ;

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

//#################################################
Console.WriteLine("###### SEGUNDA PARTE\n1.=============\nCount: " + queries.CantBooks200And500Pages_int());
Console.WriteLine("LongCount: " + queries.cantBooks200And500Pages_long() + "\n\n");

//Uso de MIN
Console.WriteLine($"2.===========\nDe la fecha menor de publicacion: {queries.MenorDate()}");
//Uso Max
Console.WriteLine($"Numero mayores de paginas: {queries.MaxPagBooks()}");
//Uso de MinBy
var bookMenorPages = queries.booksWhitMenorPages();
Console.WriteLine($"3.===========\n{bookMenorPages.Title} - {bookMenorPages.PageCount}\n\n");
//Uso de MaxBy
var bookDateRecent = queries.bookDatePublichResent();
Console.WriteLine($"4.===========\n{bookDateRecent.Title} - {bookDateRecent.PublishedDate.ToShortDateString()}\n\n");

//Uso de SUM
Console.WriteLine($"5.===========" +
    $"\nLa suma de todos los libros de entre 0 y 500 paginas son: {queries.sumThePagesBooks()}");

//Uso de Aggregate
Console.WriteLine($"\n6.===========" +
    $"\nLibros Despues del 2015:" +
    $"\n{queries.titleBooksBefore2015()}");

//Uso de Average
Console.WriteLine($"\n7.===========" +
    $"\nPromeido de caracteres de los titulos: {queries.PromedianCharactBoosk()}" +
    $"\n");

//Uso de GroupBy
//Funcion para poder imprimir la lista de libros
void printfGroup (IEnumerable<IGrouping<int, Book>> ListadoDeLibros)
{
    foreach (var group in ListadoDeLibros)
    {
        Console.WriteLine("");
        Console.WriteLine($"Grupo: {group.Key} -------------------------------");
        Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha de publicacion");
        foreach (var item in group)
        {
            Console.WriteLine("{0, -60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.Date.ToShortDateString());
        }
    }
}

Console.WriteLine("\n8.============");
printfGroup(queries.booksAfterThe2000GroupForYear());

//Uso de Lookup
//Funcion para imprimir el diccionario
void printfDiccionary (ILookup<char, Book> listaDeLibros, char letra)
{
    Console.WriteLine("{0, -60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha de publicacion");
    foreach (var item in listaDeLibros[letra])
    {
        Console.WriteLine("{0, -60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.Date.ToShortDateString());
    }
}

Console.WriteLine("\n9.===========");
printfDiccionary(queries.diccionaryTheBooksByLetter(), 'E');

//Uso de JOIN
Console.WriteLine("\n10.==========");
printfValues(queries.UseJoin());