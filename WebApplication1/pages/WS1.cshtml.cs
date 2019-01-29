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

        public string Message1 { get; set; }
        public string Message2 { get; set; }

        public void OnGet()
        {
            
        }
        public void OnPost(string name, int number1, int number2)
        {
            Message1 =
                     String.Format("Hello  {0}", name);

            int result = number1 + number2;

            Message2 =
                String.Format("The Sum of {0} and {1} is {2}", number1, number2, result);
        }
        
    }
}