<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunGuncelle.aspx.cs" Inherits="EntityAspProje.Urun.UrunGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

       <form runat="server" class="form-group">

       <div style="margin-top: 10px;">
           <asp:TextBox ID="TxtUrunAd" runat="server" placeholder="Ürün Adını Giriniz" CssClass="form-control"></asp:TextBox>
       </div>
       <div style="margin-top: 10px;">
           <asp:TextBox ID="TxtUrunMarka" runat="server" placeholder="Ürün Marka Giriniz" CssClass="form-control"></asp:TextBox>
       </div>
       <div style="margin-top: 10px;">
           <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
       </div>
       <div style="margin-top: 10px;">
           <asp:TextBox ID="TxtUrunFiyat" runat="server" placeholder="Ürün Fiyat Giriniz" CssClass="form-control"></asp:TextBox>
       </div>
       <div style="margin-top: 10px;">
           <asp:TextBox ID="TxtUrunStok" runat="server" placeholder="Ürün Stok Giriniz" CssClass="form-control"></asp:TextBox>
       </div>

       <div style="margin-top: 10px;">
           <asp:Button ID="BtnUrunGuncelle" runat="server" Text="Ürün Güncelle" CssClass="btn btn-warning" OnClick="BtnUrunGuncelle_Click" />
       </div>
   </form>

</asp:Content>
