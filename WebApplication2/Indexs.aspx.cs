using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Indexs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string user = TextBox1.Text;
            string pwd = TextBox2.Text;
            string code = TextBox3.Text;
            if (Session["vcode"].ToString() == code.ToLower())
            {
                if (user == "admin" && pwd == "123456")
                {
                    Response.Redirect("link.aspx");
                }
                else
                {
                    Label1.Text = "账号或密码错误！";
                }
                
            }
            else
            {
                Label1.Text = "验证码不正确！";
            }
        }
    }
}