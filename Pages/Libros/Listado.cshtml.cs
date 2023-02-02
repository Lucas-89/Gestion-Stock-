using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GestionStock.Servicios;
using GestionStock.Modelos;

namespace GestionStock.Pages
{
    public class ListadoModel : PageModel
    {   
        [BindProperty]
        public List<Libro> Stock{get;set;}
        public void OnGet()
        {
            var libSvr= new LibrosServicio();
            Stock=libSvr.MostrarTodos();
        }
    }
}
