using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace WebApplication1.Pages
{
    public class taghelpplayModel : PageModel
    {
        [BindProperty] public int Number1 { get; set; }
        [BindProperty] public int? Number2 { get; set; }
        [BindProperty] public double Number3 { get; set; }
        [BindProperty] public double? Number4 { get; set; }
        [BindProperty] public decimal Number5 { get; set; }
        [BindProperty] public decimal? Number8 { get; set; }
        [BindProperty] public float Number6 { get; set; }
        [BindProperty] public float? Number7 { get; set; }
        [BindProperty] public string Text1 { get; set; }
        [BindProperty] public DateTime Datetime { get; set; }
        [BindProperty] public DateTime? DateTime2 { get; set; }
        [BindProperty] public bool Contact { get; set; }

        public string Message { get; private set; }

        public string Message2 { get; private set; }
        public string Message3 { get; private set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            
            Message =
            $"{Number1} , {Number2} , {Number3} , {Number4} , {Number5} , " +
                $"{Number8} , {Number6} , {Number7} , {Text1} , {Datetime} , {DateTime2}";

            Message2 =
                $"{Contact} = Yes, Contact is allowed";
            Message3 =
                $"{Contact} = No, Contact is not allowed";

        }
    }
}