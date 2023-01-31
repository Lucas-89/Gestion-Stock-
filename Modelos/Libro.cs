using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionStock.Modelos
{
    public class Libro
    {
        public string Nombre{get;set;}
        public string Genero{get;set;}
        public int CantHojas{get;set;}
        public bool TapaDura{get;set;}
        public DateTime FechaPublicacion {get;set;}
        public int Calificacion{get;set;}
    }
}