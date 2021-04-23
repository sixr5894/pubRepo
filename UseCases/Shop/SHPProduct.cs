using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.Shop
{
    public class SHPProduct : Product
    {
        [Key]
        public int ID { get; set; }
        public string ImagePath { get; set; }
        public bool AreEqual(SHPProduct product)
        {
            return this.ImagePath == product.ImagePath && this.Name == product.Name && this.Price == product.Price;
        }
    }
}
