using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloorAndCarpet
{
    class Material
    {
        public Material(string matName, string description, decimal pricePerSquareFoot) 
        {
            MatName = matName;
            Description = description;
            PricePerSquareFoot = pricePerSquareFoot;
        }
        public string MatName { get; set; }
        public string Description { get; set; }
        public decimal PricePerSquareFoot { get; set; }
        public string Thickness { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public Boolean Installed { get; set; }
        public decimal Labor { get; set; }
        public decimal GetCost => (decimal)Area * PricePerSquareFoot;
        public double Area => Length * Width;
        public double AreaSqYards => Area * 0.111;
        public decimal LaborCost => Labor * (decimal)AreaSqYards;
        public decimal TotalCost => GetCost + Labor;
        public override string ToString()
        {
            return MatName + " " + Description + " " + PricePerSquareFoot; 
        }
        public string ToStringDetail()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0,-13}: {1, 10}\n", "Flooring Name", MatName);
            sb.AppendLine();
            sb.AppendFormat("{0,-13}: {1, 10}\n", "Desc         ", Description);
            sb.AppendLine();
            sb.AppendFormat("{0,-13}: {1, 10:C}\n", "Price        ", PricePerSquareFoot);
            sb.AppendLine();
            sb.AppendFormat("{0,-13}: {1, 10:N0}\n", "Area(Ft)     ", Area);
            sb.AppendLine();
            sb.AppendFormat("{0,-13}: {1, 10:N0}\n", "Area(Yd)     ", AreaSqYards);
            sb.AppendLine();
            sb.AppendFormat("{0,-13}: {1, 10:C}\n", "Cost         ", GetCost);
            sb.AppendLine();
            sb.AppendFormat("{0,-13}: {1, 10:C}\n", "Installation ", Labor);
            sb.AppendLine();
            sb.AppendFormat("{0,-13}: {1, 10:C}\n", "Total Price  ", TotalCost);
            return sb.ToString();
            

        }
    }
}
