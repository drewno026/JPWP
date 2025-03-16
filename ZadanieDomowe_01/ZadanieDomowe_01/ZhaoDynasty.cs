using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ZadanieDomowe_01
{
    class ZhaoDynasty : Dynasty
    {
        public string LastRuler { get; private set; } 

        public ZhaoDynasty() : base()
        {
            LastRuler = "Zhao Qian";
        }

        public ZhaoDynasty(string _nameOfDynasty, int _startYear, int _endYear, string _lastRuler)
            : base(_nameOfDynasty, _startYear, _endYear)
        {
            LastRuler = _lastRuler;
        }

        public void ShowZhaoInfo()
        {
            Console.WriteLine($"Last Ruler: {LastRuler}");
        }

        public new void DynastyInfo()
        {
            base.DynastyInfo();
            ShowZhaoInfo();
        }
    }
}

