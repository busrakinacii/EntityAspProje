using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using EntityAspProje.Entity;
namespace EntityAspProje
{
    public partial class KategoriGuncelle : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack != true)
            {
                int id = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
                TxtID.Text = id.ToString();

                var ktgr = db.TBLKATEGORI.Find(id);
                TxtKategori.Text = ktgr.KATEGORIAD;
            }

        }

        protected void BtnKategoriEkle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
            var ktgr = db.TBLKATEGORI.Find(id);

            ktgr.KATEGORIAD = TxtKategori.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellenmiştir.", "Bilgi", MessageBoxButton.OK, MessageBoxImage.Information);
            Response.Redirect("Kategoriler.Aspx");

        }
    }
}