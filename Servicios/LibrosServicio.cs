using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionStock.Modelos;

namespace GestionStock.Servicios
{
    public class LibrosServicio
    {
        private List<Libro> ListaLibros;

        public LibrosServicio(){
            ListaLibros= new List<Libro>(){
                new Libro(){Id=1,Nombre="It", Genero="Terror"},
                new Libro(){Id=2,Nombre="El Principito", Genero="Fantasia"},
                new Libro(){Id=3,Nombre="Pinocho", Genero="Infantil"},
            };

        }
        public List<Libro> MostrarTodos(){
            return ListaLibros;
        }
        public Libro MostrarUnLibro(int id){
            return null;
        }
        public void Agregar(Libro lib){

        }
        public void Borrar(int id){

        }
        public void Modificar(Libro lib){

        }
    }
}