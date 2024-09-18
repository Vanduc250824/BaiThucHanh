using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua1
{
    public class Electronic: Product
    {
        private int BaoHanh;

        public Electronic(string _ten, float _gia, string _mota, int _sl, int _BaoHanh) : base(_ten, _gia, _mota, _sl)
        {
            this.BaoHanh = _BaoHanh;
        }
    }
}
