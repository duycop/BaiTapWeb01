using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsTamGiac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = (double)numericUpDown1.Value;
            double b = (double)numericUpDown2.Value;
            double c = (double)numericUpDown3.Value;

            lib_HinhHoc.TamGiac tg = new lib_HinhHoc.TamGiac();
            tg.a = a; tg.b = b; tg.c = c;
            tg.XuLy();

            if (tg.ok)
            {
                label_kq.Text = $"Diện tích tam giác = {tg.dientich}";
            }
            else
            {
                label_kq.Text = "Lỗi: 3 cạnh không tạo thành tam giác";
            }
        }
    }
}
