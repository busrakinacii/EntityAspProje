using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using EntityAspProje.Entity;

namespace EntityAspProje.Satis
{
    public partial class YeniSatis : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack != true)
            {
                //Ürünleri DropDownListte Çekme
                var urun = (from x in db.TBLURUNLER
                            select new
                            {
                                x.URUNID,
                                x.URUNAD
                            }).ToList();
                DropDownList1.DataTextField = "URUNAD";
                DropDownList1.DataValueField = "URUNID";
                DropDownList1.DataSource = urun;
                DropDownList1.DataBind();

                //Müşterileri DropDownListe Çekme
                var mus = (from x in db.TBLMUSTERI
                           select new
                           {
                               x.MUSTERIID,
                               ADSOYAD = x.MUSTERIAD + " " + x.MUSTERISOYAD
                           }).ToList();
                DropDownList3.DataTextField = "ADSOYAD";
                DropDownList3.DataValueField = "MUSTERIID";
                DropDownList3.DataSource = mus;
                DropDownList3.DataBind();

                //Personelleri DropDownListtte Çekme
                var per = (from x in db.TBLPERSONEL
                           select new
                           {
                               x.PERSONELID,
                               x.PERSONELADSOYAD
                           }).ToList();
                DropDownList2.DataTextField = "PERSONELADSOYAD";
                DropDownList2.DataValueField = "PERSONELID";
                DropDownList2.DataSource = per;
                DropDownList2.DataBind();
            }

        }

        protected void BtnYeniSatis_Click(object sender, EventArgs e)
        {
            TBLSATIS t = new TBLSATIS();
            t.URUN = int.Parse(DropDownList1.SelectedValue);
            t.PERSONEL = byte.Parse(DropDownList2.SelectedValue);
            t.MUSTERI = int.Parse(DropDownList3.SelectedValue);
            t.FIYAT = decimal.Parse(TxtFiyat.Text);
            db.TBLSATIS.Add(t);
            db.SaveChanges();
            MessageBox.Show("Satış İşlemi Başarıyla Kaydedilmiştir.", "Bilgi", MessageBoxButton.OK, MessageBoxImage.Information);
            Response.Redirect("Satislar.Aspx");

        }
    }
}