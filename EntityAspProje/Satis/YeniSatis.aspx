<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YeniSatis.aspx.cs" Inherits="EntityAspProje.Satis.YeniSatis" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server">
        <div style="margin-top: 10px;">
            <asp:Label runat="server" Text="Label">Ürün Seçin</asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <div style="margin-top: 10px;">
            <asp:Label runat="server" Text="Label">Personel Seçin</asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <div style="margin-top: 10px;">
            <asp:Label runat="server" Text="Label">Müşteri Seçin</asp:Label>
            <asp:DropDownList ID="DropDownList3" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <div style="margin-top: 10px;">
            <asp:Label runat="server" Text="Label">Fiyat</asp:Label>
            <asp:TextBox ID="TxtFiyat" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div style="margin-top: 10px;">
            <asp:Button ID="BtnYeniSatis" runat="server" Text="Satış Yap" CssClass="btn btn-warning" OnClick="BtnYeniSatis_Click" />
        </div>

    </form>

</asp:Content>
