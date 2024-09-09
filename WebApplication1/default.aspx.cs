using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(TextBox1.Text);
            double b = double.Parse(TextBox2.Text);
            double c = double.Parse(TextBox3.Text);

            lib_HinhHoc.TamGiac tg = new lib_HinhHoc.TamGiac();
            tg.a = a; tg.b = b; tg.c = c;
            tg.XuLy();

            if (tg.ok)
            {
                ketqua_web.InnerHtml = $"Diện tích tam giác = {tg.dientich}";
            }
            else
            {
                ketqua_web.InnerHtml = "Lỗi: 3 cạnh không tạo thành tam giác";
            }
        }
    }
}