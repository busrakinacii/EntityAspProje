<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="KategoriGuncelle.aspx.cs" Inherits="EntityAspProje.KategoriGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server" class="form-group">
        <div style="margin-top: 10px;">
            <asp:TextBox ID="TxtID" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>
        <div style="margin-top: 10px;">
            <asp:TextBox ID="TxtKategori" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div style="margin-top: 10px;">
            <asp:Button ID="BtnKategoriEkle" runat="server" Text="Kategori Güncelle" CssClass="btn btn-default" OnClick="BtnKategoriEkle_Click" />
        </div>
    </form>

</asp:Content>
