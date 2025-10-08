using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoLINQ
{
    //================= CLASE DE CONSULTAS ==================
    internal class LinqQueries
    {
        private List<Book> librosCollection = new List<Book>();//Lista de libros
        public LinqQueries() //Constructor
        {
            using (StreamReader reader = new StreamReader("books.json"))//lee cada linea del archivo json
            {
                string json = reader.ReadToEnd();
                this.librosCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            }
        }

        //#################################################################
        //SEGUNDA PARTE DE LOS RETOS

        //====== METODO Uso de COUNT ==================
        //Uso de count y longCount para mostrar la cantidad de libros mayores o iguales a 200 paginas y menor o igual a 500
        public int CantBooks200And500Pages_int()
        {
            return librosCollection.Where(p => p.PageCount >= 200 && p.PageCount <= 500).Count();
        }

        //====== Uso de LongCount =====================
        public long cantBooks200And500Pages_long()
        {
            return librosCollection.LongCount(p => p.PageCount >= 200 && p.PageCount <= 500);
        }

        //====== METODO uso de Min ===================
        //Uso de Min, retornar la fecha menor de libros publicados
        public DateTime MenorDate()//Min
        {
            return librosCollection.Min(p => p.PublishedDate);
        }

        //====== Uso de Max =========================
        public int MaxPagBooks()//Max
        {
            return librosCollection.Max(p => p.PageCount);
        }

        //======= Método ============================
        // USo de MinBy
        public Book booksWhitMenorPages()//MinBy
        {
            // MinBy puede devolver null si la colección está vacía, así que se debe manejar ese caso.
            return librosCollection
                .Where(p => p.PageCount > 0)
                .MinBy(p => p.PageCount) 
                ?? new Book();
        }

        //====== Uso de MaxBy ========================
        public Book bookDatePublichResent()//MaxBy
        {
            return librosCollection
                .MaxBy(p => p.PublishedDate) 
                ?? new Book();
        }

        //====== Metodo Que usa el Operador SUM ======================
        public int sumThePagesBooks() {
            return librosCollection
                .Where(p => p.PageCount >= 0 && p.PageCount <= 500)
                .Sum(p => p.PageCount);
        }

        //====== Metodo Que usa Aggregate ============================
        public string titleBooksBefore2015()
        {
            return librosCollection
                .Where(p => p.PublishedDate.Year > 2015)
                .Aggregate("", (titleBooks, next) =>
                {
                    if (titleBooks != string.Empty)
                        titleBooks += "\n" + next.Title;
                    else
                        titleBooks += next.Title;
                    return titleBooks;
                });
        }

        //====== Metodo que usa Average =============================
        //Retorna el pormedio de caracteres que tienen los titulos de la coleccion
        public double PromedianCharactBoosk()
        {
            return librosCollection.Average(p => p.Title.Length);
        }

        //---------------------------
        // AGRUPACION
        //---------------------------
        
        //====== Metodo que usa GroupBy
        //Libros publicados a partir del 2000 agrupados por anio
        public IEnumerable<IGrouping<int, Book>> booksAfterThe2000GroupForYear()
        {
            return librosCollection
                .Where(p => p.PublishedDate.Year >= 2000)
                .GroupBy(p => p.PublishedDate.Year);
        }

        //====== Metodo que usa Lookup
        /*Retorna un diccionario usando lookup que permite consultar los libros
          de acuerdo a la letra con la que inicia le titulo del libro*/
        public ILookup<char, Book> diccionaryTheBooksByLetter()
        {
            return librosCollection
                .ToLookup(p => p.Title[0], p => p);
        }

        //Metodo para usar el operador JOIN
        /*
         Obtener una coleccion que tenga todos los libros con mas de 500 paginas y
         que contenga los libros publicados despues del 2005 utilizando la clausula
         join, retornar los libros que esten en ambas colecciones
         */
        public IEnumerable<Book> UseJoin()
        {
            var booksAfter2005 = librosCollection.Where(p => p.PublishedDate.Year > 2005);
            var booksWhiteMore500Pages = librosCollection.Where(p => p.PageCount > 500);

            return booksAfter2005.Join(booksWhiteMore500Pages, p => p.Title, x => x.Title, (p, x) => p);
        }
    }
}