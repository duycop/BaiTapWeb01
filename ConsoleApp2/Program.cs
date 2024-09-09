using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vẫn bài toán tính diện tích tam giác.
            //nhưng tách phần tính toán ra HÀM

            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Phần mềm Tính diện tích tam giác - Console App2");
            Console.Write("Nhập 3 cạnh của tam giác: ");
            string s = Console.ReadLine();
            string[] items = s.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            if (items.Length == 3)
            {
                double a = double.Parse(items[0]);
                double b = double.Parse(items[1]);
                double c = double.Parse(items[2]);

                double S = 0;
                bool ok = XuLy(a, b, c, ref S);
                if (ok)
                {
                    Console.WriteLine($"Diện tích tam giác = {S}");
                }
                else
                {
                    Console.WriteLine("Lỗi: 3 cạnh không tạo thành tam giác");
                }
            }
            Console.ReadKey();
        }

        static bool XuLy(double a, double b, double c, ref double S )
        {
            //phần tính toán
            if (a > 0 && b > 0 && c > 0 && a + b > c && b + c > a && a + c > b)
            {
                double p = (a + b + c) / 2;
                S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                //Console.WriteLine($"Diện tích tam giác = {S}");
                return true;
            }
            else
            {
                //Console.WriteLine("Lỗi: 3 cạnh không tạo thành tam giác");
                return false;
            }
        }
    }
}
