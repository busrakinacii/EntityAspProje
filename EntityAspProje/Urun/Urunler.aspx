<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Urunler.aspx.cs" Inherits="EntityAspProje.Urun.Urunler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered">
        <tr>
            <th>ÜRÜN ID</th>
            <th>ÜRÜN AD</th>
            <th>MARKA</th>
            <th>KATEGORİ</th>
            <th>FİYAT</th>
            <th>STOK</th>
            <th>SİL</th>
            <th>GÜNCELE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("URUNID") %></td>
                    <td><%#Eval("URUNAD") %></td>
                    <td><%#Eval("URUNMARKA") %></td>
                    <td><%#Eval("KATEGORIAD") %></td>
                    <td><%#Eval("URUNFIYAT") %></td>
                    <td><%#Eval("URUNSTOK") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"~/Urun/UrunSil.Aspx?URUNID="+Eval("URUNID") %>' runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink></td>
                    <td>
                        <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"~/Urun/UrunGuncelle.aspx?URUNID="+Eval("URUNID")%>' runat="server" CssClass="btn btn-success">GÜNCELLE</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>

    </table>
    <a href="YeniUrunEkle.aspx" class="btn btn-info">Yeni Ürün</a>

</asp:Content>
