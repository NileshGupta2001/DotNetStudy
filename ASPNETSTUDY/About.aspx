<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ASPNETSTUDY.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>this is ducat</h3>
    <asp:HiddenField ID="HiddenField1" runat="server" />
    <asp:Button ID="Button1" runat="server" Text="Click Me" OnClick="Button1_Click" />
    <asp:TextBox ID="txtName" runat="server" ></asp:TextBox>
    
</asp:Content>
