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

        //Metodo -> Extrar los datos de todos los libros
        public IEnumerable<Book> TodaLaCollection()
        {
            return librosCollection;
        }

        //Metodo -> Extrar libros publicados despues del año 2000
        public IEnumerable<Book> booskBeforeOf2000()
        {
            return librosCollection.Where(p => p.PublishedDate.Year > 2000);
        }

        //Metodo -> Extraer libros del 2000 usando Query expresion
        public IEnumerable<Book> booksBeforeOf200QryExp()
        {
            return from l in librosCollection where l.PublishedDate.Year > 2000 select l;
        }

        //Metodo -> Extraer libros con 250pag. y Titulo contenga Action.
        public IEnumerable<Book> books250pagANDtileAction()
        {
            //return librosCollection.Where(p => p.PageCount > 250 && p.Title.Contains("in Action"));
            return from l in librosCollection where l.PageCount > 250 && l.Title.Contains("in Action") select l;
        }

        //Metodo -> Uso de operador ALL, Verificar si todos los libros tienen status
        public bool UseOfOperatorALL()
        {
            return librosCollection.All(p => p.Status != string.Empty);
        }

        //Metodo -> Uso de ANY para verificar si algun libro fue publicado en el 2005
        public bool UseOfOperatorANY()
        {
            return librosCollection.Any(p => p.PublishedDate.Year == 2005);
        }

        //Metodo -> Uso de Contains, Retornar los elementos con categoria Python
        public IEnumerable<Book> booksCatPython() 
        {
            return librosCollection.Where(p => p.Categories.Contains("Python"));
        }

        //Metodo -> Uso de OrderBy, retornar los elementos que sean de la categoria java ordenados por nombre
        public IEnumerable<Book> booksCatJavaOrderByName()
        {
            return librosCollection.Where(p => p.Categories.Contains("Java")).OrderBy(p => p.Title);
        }

        //Metod -> Uso de OrderByDescending, Retornar los libros que tengan mas de 450 paginas
        //Ordenados por numero de paginas de forma descendente
        public IEnumerable<Book> booksMore450PagOrderByDes()
        {
            return librosCollection.Where(p => p.PageCount > 450).OrderByDescending(p => p.PageCount);
        }

        //Metodo -> Uso de Take para optener los tres ultimos libros ordenados por fecha
        public IEnumerable<Book> threeBooksJavaOrderByDate()
        {
            return librosCollection
                .Where(p => p.Categories.Contains("Java"))
                .OrderBy(p => p.PublishedDate)
                .TakeLast(3);
        }

        //Metodo -> Uso de Skip para obtener el tercer y cuarto libro con mas de 400 paginas
        public IEnumerable<Book> thirdAndFourthBooksMore400pages()
        {
            return librosCollection
                .Where(p => p.PageCount > 400)
                .Take(4)
                .Skip(2);
        }
        
        //Metodo -> Uso de Seleccion dinamica
        public IEnumerable<Book> ThreeBooksInCollection()
        {
            return librosCollection
                .Take(3)
                .Select(p => new Book() { Title = p.Title, PageCount = p.PageCount });//Se crea una nueva coleccion solo con dos datos
        }
    }

}