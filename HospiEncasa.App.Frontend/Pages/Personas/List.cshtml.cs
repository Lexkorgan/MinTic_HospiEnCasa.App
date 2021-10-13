using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hospiencasa.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
        private string[] Personas = {"Juan", "Troy", "Jack", "Malaver","Ana"};



        public List<string> ListPersonas {get; set; }

        public void OnGet()
    
        {

            ListPersonas = new List<string>();
            ListPersonas.AddRange(Personas);
        }
    }
}
