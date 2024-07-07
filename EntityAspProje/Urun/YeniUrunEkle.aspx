<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YeniUrunEkle.aspx.cs" Inherits="EntityAspProje.Urun.YeniUrunEkle" %>

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
            <asp:Button ID="BtnUrunEkle" runat="server" Text="Ürün Ekle" CssClass="btn btn-primary" OnClick="BtnUrunEkle_Click" />
        </div>
    </form>

</asp:Content>
