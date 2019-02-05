using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class timeModel : PageModel
    {
        [BindProperty]
        public SelectMonth[] Months { get; set; }
            =
            {
                new SelectMonth("January", false),
                new SelectMonth("February", false),
                new SelectMonth("March", false),
                new SelectMonth("April", false),
                new SelectMonth("May", false),
                new SelectMonth("June", false),
                new SelectMonth("July", false),
                new SelectMonth("August", false),
                new SelectMonth("September", false),
                new SelectMonth("October", false),
                new SelectMonth("November", false),
                new SelectMonth("December", false),
            };

        public List<SelectListItem> Day { get;}
            = new List<SelectListItem>
            {
                new SelectListItem {Value = "Monday", Text = "Monday"},
                new SelectListItem {Value = "Tuesday", Text = "Tuesday"},
                new SelectListItem {Value = "Wednesday", Text = "Tuesday"},
                new SelectListItem {Value = "Thursday", Text = "Thursday"},
                new SelectListItem {Value = "Friday", Text = "Friday"},
                new SelectListItem {Value = "Saturday", Text = "Saturday"},
                new SelectListItem {Value = "Sunday", Text = "Sunday"}
            };

        [BindProperty] public string[] ChosenDays { get; set; } = { };

        public string Message { get; set; } = "";

        public void OnGet()
        {

        }

        public void OnPost()
        {
            
        }
    }
}