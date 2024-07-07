using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.LinqKartlar
{
    public partial class istatistik : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.TBLURUNLER.Count().ToString();
            Label2.Text = db.TBLMUSTERI.Count().ToString();
            Label3.Text = db.TBLSATIS.Sum(x => x.FIYAT).ToString();
            Label4.Text = db.TBLKATEGORI.Count().ToString();
            Label5.Text = db.TBLURUNLER.Count(x => x.DURUM == true).ToString();
            Label6.Text = db.TBLURUNLER.Count(x => x.DURUM == false).ToString();
            Label7.Text = (from x in db.TBLURUNLER orderby x.URUNSTOK descending select x.URUNAD).FirstOrDefault();
            //En fazla olan Kategorinin Kategori Adı
            var enfazlastok_urun = (from x in db.TBLURUNLER
                                    join y in db.TBLKATEGORI on x.URUNKATEGORI equals y.KATEGORIID
                                    group x by y into item
                                    orderby item.Count() descending
                                    select item.Key.KATEGORIAD).FirstOrDefault();
            Label8.Text = enfazlastok_urun.ToString();

        }
    }
}