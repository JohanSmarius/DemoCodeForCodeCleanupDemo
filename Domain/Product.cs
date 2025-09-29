using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace Domain
{
    public class Product
    {
        private string name;
        private double vatPercentage;

        public int Id { get; set; }

        public string Name { get => name; set => name = value; }

        public decimal Price { get; set; }

        public double VatPercentage { get => vatPercentage; set => vatPercentage = value; }

        public decimal PriceWithVat
        {
            get {
                return Price + (Price * (decimal)(VatPercentage / 100));
            }

        }
    }
}
