using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class api : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //all code here
            string kq = "";
            try
            {
                double a = double.Parse(this.Request.Form["a"]);
                double b = double.Parse(this.Request.Form["b"]);
                double c = double.Parse(this.Request.Form["c"]);

                lib_HinhHoc.TamGiac tg = new lib_HinhHoc.TamGiac();
                tg.a = a; tg.b = b; tg.c = c;
                tg.XuLy();


                if (tg.ok)
                {
                    kq = $"Diện tích tam giác = {tg.dientich}";
                }
                else
                {
                    kq = "Lỗi: 3 cạnh không tạo thành tam giác";
                }
            }
            catch (Exception ex)
            {
                kq = $"Lỗi: {ex.Message}";
            }
            finally
            {
                this.Response.Write(kq);
            }
        }
    }
}