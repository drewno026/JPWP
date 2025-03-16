using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe_01
{
    class Dynasty
    {
        public string NameOfDynasty { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public Dynasty()
        {
            NameOfDynasty = "Unwknown";
            StartYear = 0;
            EndYear = 0;
        }
        public Dynasty(string _nameOfDynasty, int _startYear, int _endYear)
        {
            NameOfDynasty = _nameOfDynasty;
            StartYear = _startYear;
            EndYear = _endYear;
        }
        public int GetDynastyAge()
        {
            return StartYear - EndYear;
        }
        public void DynastyInfo()
        {
            Console.WriteLine($"Name of Dynasty: {NameOfDynasty}");
            Console.WriteLine($"Duration of Dynasty(from {StartYear} to {EndYear} b. c.): {GetDynastyAge()} ");
        }
    }
}
