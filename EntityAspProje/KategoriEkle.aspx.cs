using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class KategoriEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnKategoriEkle_Click(object sender, EventArgs e)
        {
            BONUSASPDBEntities db = new BONUSASPDBEntities();
            TBLKATEGORI t = new TBLKATEGORI();
            t.KATEGORIAD = TxtKategori.Text;
            db.TBLKATEGORI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi.","Bilgi",MessageBoxButton.OK,MessageBoxImage.Information);
            Response.Redirect("Kategoriler.Aspx");
        }
    }
}