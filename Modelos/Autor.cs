using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionStock.Modelos
{
    public class Autor
    {
        public string Nombre{get;set;}
        public string Apellido{get;set;}
        public string Nacionalidad{get;set;}
        public DateTime FechaNac{get;set;}
        public bool Contemporaneo{get;set;} //vivo o muerto

    }
}