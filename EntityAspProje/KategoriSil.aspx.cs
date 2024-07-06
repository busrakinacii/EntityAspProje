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
    public partial class KategoriSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BONUSASPDBEntities db=new BONUSASPDBEntities();

            int x =Convert.ToInt32( Request.QueryString["KATEGORIID"]);
            var deger = db.TBLKATEGORI.Find(x);
            db.TBLKATEGORI.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Kategori Silinmiştir.","Bilgi",MessageBoxButton.OK, MessageBoxImage.Information);
            Response.Redirect("Kategoriler.Aspx");

        }
    }
}