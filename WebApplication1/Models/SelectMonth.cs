using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class SelectMonth
    {
        public string MonthName { get; set; }
        public bool IsChosen { get; set; }

        public SelectMonth(string monthName, bool isChosen)
        {
            MonthName = monthName;
            IsChosen = isChosen;
        }

        public SelectMonth()
        {
            MonthName = "";
            IsChosen = false;
        }
    }
}
