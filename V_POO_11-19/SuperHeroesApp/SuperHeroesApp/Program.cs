using SuperHeroesApp;
using SuperHeroesApp.Models;
using System.Linq.Expressions;

var imprimirInfo = new Imprimir();

//############# Poderes ##################
var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para volar y planear";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "SuperFuerza";
superFuerza.Descripcion = "Puede alzar mucho peso";
superFuerza.Nivel = NivelPoder.NivelTres;

var regeneracion = new SuperPoder();
regeneracion.Nombre = "Regeneracion";
regeneracion.Descripcion = "Sus organos se regeneran muy rapido";
regeneracion.Nivel = NivelPoder.NivelTres;



//########## Heroes #####################
Console.WriteLine("---------- HEROE -----------");
var superman = new SuperHeroe(); //Instancia de la clase SuperHeroes

//Atributos del objeto SuperHeroes
superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

imprimirInfo.ImprimirSuperHeroe(superman);


//Lista de sus poderes
List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
superman.poderes = poderesSuperman;

superman.usarSuperPoder();

Console.WriteLine(superman.SalvarElMundo());
Console.WriteLine(superman.salvarTierra());

//########## Anti Heroe ##################
Console.WriteLine("\n-------- ANTI HEROE -------");
var wolverine = new AntiHeroe();

wolverine.Id = 6;
wolverine.Nombre = "Wolverine";
wolverine.IdentidadSecreta = "Logan";
wolverine.PuedeVolar = false;

List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(regeneracion);
poderesWolverine.Add(superFuerza);
wolverine.poderes = poderesWolverine;

imprimirInfo.ImprimirSuperHeroe(wolverine);

wolverine.usarSuperPoder();
string accion = wolverine.AccionDeAntiHeroe("Atacar a la policia");
Console.WriteLine(accion);

//############## Enumeracion ##############
enum NivelPoder
{
    NivelUno, 
    NivelDos,
    NivelTres
}