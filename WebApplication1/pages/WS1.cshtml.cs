using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class WS1Model : PageModel
    {
        public string[] MyTestArray { get; set; }
        = { "Ireland", "Scotland", "Wales", "England" };

        public void OnGet()
        {

        }
        public void OnPost()
        {
            @Model.Message = "Hello {0}", name;
        }
    }
}