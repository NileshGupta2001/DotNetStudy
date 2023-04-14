<%@ Page Title="Show Doctors" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewDoctors.aspx.cs" Inherits="HospitalApplication.ViewDoctors" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <asp:GridView ID="grdDoctorData" AutoGenerateColumns="false" runat="server" >
        <Columns>
            
        <asp:TemplateField HeaderText="Doctor ID"> 
            <asp:ItemTemplate >
                <asp:Label ID="lblID" runat="server" Text='<%# Eval("ID") %>'></asp:Label>

            </asp:ItemTemplate>
</asp:TemplateField>
            <asp:TemplateField HeaderText="Edit"> 
            <asp:ItemTemplate >
                <asp:Button ID="btnEdit" runat="server" Text="Edit" />

            </asp:ItemTemplate>
</asp:TemplateField>
    
        </Columns>
    </asp:GridView>
    
</asp:Content>
