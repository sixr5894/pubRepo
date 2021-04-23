using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.Shop
{
    public class SHPUser:User
    {
        [Key]
        public int ID { get; set; }
        private int _spentMoney = 0;
        public void AddMoney(int money)
        {
            this._spentMoney += money;
        }
        public int TotalySpent()
        {
            return this._spentMoney; 
        }
        public void ChangeTo(SHPUser user)
        {
            this.Name = user.Name;
            this._spentMoney = user._spentMoney;
        }
    }
}
