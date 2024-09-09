using System;
using System.Collections.Generic;
using System.Text;

namespace lib_HinhHoc
{
    public class TamGiac
    {
        //input
        public double a, b, c;
        //output
        public double dientich { get; private set; }

        public bool ok { get; private set; }
        public void XuLy()
        {
            //phần tính toán
            if (a > 0 && b > 0 && c > 0 && a + b > c && b + c > a && a + c > b)
            {
                double p = (a + b + c) / 2;
                dientich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                ok = true;
            }
            else
            {
                ok = false;
            }
        }
    }
}
