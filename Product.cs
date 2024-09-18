using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua1
{
    public class Product
    {
        public string ten { get; set; }
        public float gia { get; set; }
        public string mota { get; set; }
        public int sl { get; set; }
        public Product(string _ten, float _gia, string _mota, int _sl)
        {
            this.ten = _ten;
            this.gia = _gia;
            this.mota = _mota;
            this.sl = _sl;
        }
        public void InDisplay()
        {
            Console.WriteLine($"Ten: {ten}, Gia: {gia}, Mo ta: {mota}, So luong: {sl}");
        }
    }  
}
