using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe_01
{
    class GreatWall : QinShiHuang
    {
        public int LengthKm { get; private set; }  
        public int ConstructionYears { get; private set; } 
        public string InitiatedBy { get; set; }

        public GreatWall() : base()
        {
            LengthKm = 5000; 
            ConstructionYears = 10;
            InitiatedBy = "Qin Shi Huang";
        }

        public GreatWall(string _nameOfDynasty, int _startYear, int _endYear, string _capitalCity, int _yearsReigned, int _lengthKm, int _constructionYears, string _initiatedBy)
            : base(_nameOfDynasty, _startYear, _endYear, _capitalCity, _yearsReigned)
        {
            LengthKm = _lengthKm;
            ConstructionYears = _constructionYears;
            InitiatedBy = _initiatedBy; 
        }

        public void ShowWallInfo()
        {
            Console.WriteLine($"The Great Wall of China was initiated by: {InitiatedBy}");
            Console.WriteLine($"Length: {LengthKm} km");
            Console.WriteLine($"Construction time: {ConstructionYears} years");
        }

        public new void DynastyInfo()
        {
            base.DynastyInfo();
            ShowWallInfo();
        }
    }
}
