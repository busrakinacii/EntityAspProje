using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using EntityAspProje.Entity;

namespace EntityAspProje.Musteri
{
    public partial class Musteriler : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var deger = db.TBLMUSTERI.ToList();
            Repeater1.DataSource = deger;
            Repeater1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLMUSTERI t = new TBLMUSTERI();
            t.MUSTERIAD = TextBox1.Text;
            t.MUSTERISOYAD = TextBox2.Text;
            db.TBLMUSTERI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Müşteri Başarılı Bir Şekilde Kaydedilmiştir.", "Bilgi", MessageBoxButton.OK, MessageBoxImage.Information);
            Response.Redirect("Musteriler.Aspx");
        }
    }
}