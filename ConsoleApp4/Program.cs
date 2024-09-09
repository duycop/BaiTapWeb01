using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // vẫn bài toán tính diện tích tam giác.
            // nhưng dùng lib Hình Học

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

                lib_HinhHoc.TamGiac tg = new lib_HinhHoc.TamGiac();
                tg.a = a; tg.b = b; tg.c = c;
                tg.XuLy();

                if (tg.ok)
                {
                    Console.WriteLine($"Diện tích tam giác = {tg.dientich}");
                }
                else
                {
                    Console.WriteLine("Lỗi: 3 cạnh không tạo thành tam giác");
                }
            }
            Console.ReadKey();
        }
    }
}
