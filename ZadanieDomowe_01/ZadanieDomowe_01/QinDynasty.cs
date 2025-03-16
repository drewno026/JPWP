using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe_01
{
    class QinDynasty:Dynasty
    {
        public string CapitalCity { get; set; }

        public QinDynasty():base()
        {
            CapitalCity = "Xianyang";
        }
        public QinDynasty(string _nameOfDynasty, int _startYear, int _endYear, string _capitalCity):base(_nameOfDynasty, _startYear, _endYear)
        {
            CapitalCity = _capitalCity;
        }

        public void CapitalCityInfo()
        {
            Console.WriteLine($"Capital of Qin Dynasty: {CapitalCity}");
        }
        public new void DynastyInfo()
        {
            base.DynastyInfo();
            CapitalCityInfo();
        }


    }
}
