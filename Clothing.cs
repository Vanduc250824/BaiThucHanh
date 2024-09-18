using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua1
{
    public class Clothing: Product
    {
        private string size;
        private string color;

        public Clothing(string _ten, float _gia, string _mota, int _sl, string _size, string _color) : base(_ten, _gia, _mota, _sl)
        {
            this.size = _size;
            this.color = _color;
        }
    }
}
