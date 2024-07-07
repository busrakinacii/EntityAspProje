using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using EntityAspProje.Entity;

namespace EntityAspProje.Urun
{
    public partial class UrunGuncelle : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack != true)
            {
                //Dropdownlist Kategorilerin Getirilmesi

                var kate = (from x in db.TBLKATEGORI select new { x.KATEGORIID, x.KATEGORIAD }).ToList();
                DropDownList1.DataTextField = "KATEGORIAD";
                DropDownList1.DataValueField = "KATEGORIID";
                DropDownList1.DataSource = kate;
                DropDownList1.DataBind();

                //Verilerin Getirilmesi
                int id = Convert.ToInt32(Request.QueryString["URUNID"]);
                var p = db.TBLURUNLER.Find(id);
                TxtUrunAd.Text = p.URUNAD;
                TxtUrunMarka.Text = p.URUNMARKA;
                DropDownList1.SelectedValue = p.URUNKATEGORI.ToString();
                TxtUrunFiyat.Text = p.URUNFIYAT.ToString();
                TxtUrunStok.Text = p.URUNSTOK.ToString();

            }
          
        }

        protected void BtnUrunGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["URUNID"]);
            var urun = db.TBLURUNLER.Find(id);
            urun.URUNAD = TxtUrunAd.Text;
            urun.URUNMARKA = TxtUrunMarka.Text;
            urun.URUNKATEGORI =byte.Parse( DropDownList1.SelectedValue.ToString());
            urun.URUNFIYAT = decimal.Parse(TxtUrunFiyat.Text);
            urun.URUNSTOK =short.Parse( TxtUrunStok.Text);
            db.SaveChanges();
            MessageBox.Show("Ürün Günvellenmiştir.", "Bilgi", MessageBoxButton.OK, MessageBoxImage.Information);
            Response.Redirect("Urunler.Aspx");

        }
    }
}