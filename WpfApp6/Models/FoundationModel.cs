using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.Models
{
    public class FoundationModel
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double ConcretePrice { get; set; }
        public double ReinforcementPrice { get; set; }
        public double SandPrice { get; set; }
        public double GravelPrice { get; set; }

        public double Volume => Length * Width * Height;

        public double Mass => Volume * 2400; // Плотность бетона

        public double ConcreteCost => Volume * ConcretePrice;

        public double ReinforcementLength => (Length * 2) + (Width * 2);
        public double ReinforcementMass => ReinforcementLength * 4; // 1м арматуры = 4кг
        public double ReinforcementCost => ReinforcementMass * ReinforcementPrice;

        public double SandVolume => Volume * 0.1; // 10% от объема
        public double GravelVolume => Volume * 0.1; // 10% от объема
        public double SandCost => SandVolume * SandPrice;
        public double GravelCost => GravelVolume * GravelPrice;

        public double TotalCost => ConcreteCost + ReinforcementCost + SandCost + GravelCost;
    }

}

