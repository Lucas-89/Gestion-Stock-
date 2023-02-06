using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GestionStock.Pages
{
    public class NuevoModel : PageModel
    {
        public string Mensaje="Este mensaje viene desde el .CS usando el @Model";
       
        public string NombreLibro{get;set;}
        public void OnGet()
        {
            ViewData["instituto"]="Istea";
            NombreLibro="El Principito";
        }
        public void OnPost()
        {
            NombreLibro="IT";
            var formulario=Request.Form;
            var numeroid=Request.Form["id"];
        }

        public void OnPostModificar()
        {
            NombreLibro="Este es el Modificar";
        }

        public IActionResult OnPostVerificar()
        {
            return RedirectToPage("Listado");
        }
    }
}
