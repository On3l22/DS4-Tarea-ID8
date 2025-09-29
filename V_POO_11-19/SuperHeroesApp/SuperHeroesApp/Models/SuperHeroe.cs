using SuperHeroesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    //############# Clase Heroe ####################
    internal class SuperHeroe:Heroe, ISuperHeroe
    {
        private string _Nombre;
        public override string Nombre //Encapsulaminto
        {
            get 
            { 
                return _Nombre;
            }

            set 
            {
                _Nombre = value.Trim();//Elimina los espacios del nombre
            }
        }

        public string NombreIdentdadSecreta //Otro tipo de Encapsulamiento
        {
            get
            {
                return $"{Nombre} ({IdentidadSecreta})";
            }
        }

        public int Id { get; set; } = 1;
        public string IdentidadSecreta { get; set; }
        public string Ciudad;
        public List<SuperPoder> poderes = new List<SuperPoder>();//Lista de poderes
        public bool PuedeVolar;

        public SuperHeroe()
        {
            poderes = new List<SuperPoder>();
            PuedeVolar = false;
        }
        //Metodo para acceder a los poderes
        public void usarSuperPoder()
        {
            foreach (var item in poderes)
            {
                Console.WriteLine($"{NombreIdentdadSecreta} esta usando el super poder {item.Nombre}");
            }
        }

        //Metodo abstracto heredado
        public override string SalvarElMundo()
        {
            return $"{NombreIdentdadSecreta} Ha salvado el mundo";
        }

        public override string salvarTierra()
        {
            return $"{NombreIdentdadSecreta} ha salvado la tierra";
        }
    }
}
