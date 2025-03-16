using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe_01
{
    class QinShiHuang:QinDynasty
    {
        public bool UnifiedChina { get; set; }
        public int YearsReigned { get; set; }
        public QinShiHuang() : base("Qin Dynasty", 221, 206, "Xianyang") 
        {
            UnifiedChina = true;
            YearsReigned = 11;       
        }
        
        public QinShiHuang(string _nameOfDynasty, int _startYear, int _endYear, string _capitalCity, int _yearsReigned) : base(_nameOfDynasty, _startYear, _endYear, _capitalCity)
        {
            UnifiedChina = true;
            YearsReigned = _yearsReigned;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Years reigned: {YearsReigned}");
            Console.WriteLine($"UnifiedChina?: {(UnifiedChina ? "Yes": "No")}");
        }

        public new void DynastyInfo()
        {
            base.DynastyInfo();
            ShowInfo();
        }
    }
}
