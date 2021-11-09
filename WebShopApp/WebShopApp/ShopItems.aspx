<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShopItems.aspx.cs" Inherits="WebShopApp.ShopItems" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="Label_ShopItems" runat="server" Text="Stanje u magacinu:"></asp:Label>

    <br />

    <asp:ListBox ID="ListBox_ShopItems" runat="server" Height="320px" Width="920px"></asp:ListBox>

   

</asp:Content>
