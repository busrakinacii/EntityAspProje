using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Urun
{
    public partial class YeniUrunEkle : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack != true)
            {
                var kate = (from x in db.TBLKATEGORI select new { x.KATEGORIID, x.KATEGORIAD }).ToList();
                DropDownList1.DataTextField = "KATEGORIAD";
                DropDownList1.DataValueField = "KATEGORIID";
                DropDownList1.DataSource = kate;
                DropDownList1.DataBind();
            }


        }

        protected void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            TBLURUNLER urun = new TBLURUNLER();
            urun.URUNAD = TxtUrunAd.Text;
            urun.URUNMARKA = TxtUrunMarka.Text;
            urun.URUNKATEGORI = byte.Parse(DropDownList1.SelectedValue.ToString());
            urun.URUNFIYAT = decimal.Parse(TxtUrunFiyat.Text);
            urun.URUNSTOK = short.Parse(TxtUrunStok.Text);

            db.TBLURUNLER.Add(urun);
            db.SaveChanges();
            Response.Redirect("Urunler.Aspx");


        }
    }
}