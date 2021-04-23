using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.Shop
{
    public class SHPOrder
    {
        public SHPOrder() { var temp = new DateTime(); temp = DateTime.Now; this.ID = temp.ToString(); }
        public SHPOrder(int sum, string name, string city)
        {
            var temp = new DateTime();
            temp = DateTime.Now;
            this.ID = temp.ToString();
            this.Sum = sum;
            this.ClientName = name;
            this.City = city;
            this.PaymentDone = false;
        }
        [Key]
        public string ID { get; set; }
        public int Sum { get; set; }
        public string ClientName { get; set; }
        public string City { get; set; }
        public bool PaymentDone { get; set; }
    }
}
