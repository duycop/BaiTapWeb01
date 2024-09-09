using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bài toán  : Tính diện tích tam giác
            //giải thuật:
            //input : 3 cạnh của tam giác là 3 số thực
            //output: diện tích, or báo lỗi
            //thuật toán:
            //1. kiểm tra đc 3 cạnh này thoả đk là tam giác
            //   phải là 3 số dương, tổng 2 cạnh lớn hơn cạnh còn lại
            //   nếu thoả đk sang b2, ngược lại sang b3 
            //2. áp dụng công thức herong: 
            //   S=căn(p(p-a)(p-b)(p-c)
            //   trong p = (a + b + c) / 2
            //   ouput là: S
            //3. ouput là: báo lỗi

            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Phần mềm Tính diện tích tam giác - Console App1");
            Console.Write("Nhập 3 cạnh của tam giác: ");
            string s = Console.ReadLine();
            string[] items = s.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            if (items.Length == 3)
            {
                double a=double.Parse(items[0]);
                double b=double.Parse(items[1]);
                double c=double.Parse(items[2]);

                //phần tính toán
                if (a > 0 && b > 0 && c > 0 && a + b > c && b + c > a && a + c > b)
                {
                    double p = (a + b + c) / 2;
                    double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    Console.WriteLine($"Diện tích tam giác = {S}");
                }
                else
                {
                    Console.WriteLine("Lỗi: 3 cạnh không tạo thành tam giác");
                }
                //hết phần tính toán
            }
            Console.ReadKey();
        }
    }
}
