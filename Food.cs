using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua1
{
    public class Food: Product
    {
        private DateTime ex_date;

        public Food(string _ten, float _gia, string _mota, int _sl, DateTime _sx_date) : base(_ten, _gia, _mota, _sl)
        {
            this.ex_date = _sx_date;
        }
    }
}
