<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NumberCount._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <asp:Button ID="btnNumberCount" runat ="server" Text="NumberCount" OnClick="btnNumberCount_Click" /></br>
        <asp:Label ID="lblTotalCount" runat ="server" Visible ="false">Total Count: </asp:Label> <asp:Label ID="lblcount" runat="server" Visible ="false"></asp:Label>
    </div>
</asp:Content>
