<%@ Page Title="Insert Doctor"  Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddDoctor.aspx.cs" Inherits="HospitalApplication.AddDoctor" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <table>
    <tr>
    <td>
    <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label></td>
    <td>
    <asp:TextBox ID="TextBox1" runat="server" placeholder="Add Name" MaxLength="100"></asp:TextBox>
   </td>
   </tr>
     <br />
        <tr>
            <td>
     <asp:Label ID="Label2" runat="server" Text="Speciality In: "></asp:Label>
    </td><td>
        <asp:DropDownList ID="SpecialityLst" runat="server" >
            <asp:ListItem Value="">Please Select</asp:ListItem>  
            <asp:ListItem> NeuroSurgeon </asp:ListItem>  
            <asp:ListItem>Dentist  </asp:ListItem>  
            <asp:ListItem>Psychiatrist</asp:ListItem>  
            <asp:ListItem>Pediatrics</asp:ListItem>  
        </asp:DropDownList>
    </td>
            </tr>
            <br />
     <tr>
         <td>
        <asp:Label ID="Label3" runat="server" Text="Experience (in Years): "></asp:Label>
    </td><td><asp:TextBox ID="TextBox3" TextMode="Number" runat="server" min="0" max="50" step="1"/>
    </td>
         </tr>
        <br />
        <tr>
      <td>
     <asp:Label ID="Label4" runat="server" Text="Gender(Male/Female): "></asp:Label>
    </td><td><asp:TextBox ID="TextBox4" runat="server" placeholder="Add Gender"></asp:TextBox></td></tr>
    </table>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Add Record" Onclick="Insert_Record"/>
    <asp:Label ID="lblmsg" runat="server" Text="Label" Visible="False" ></asp:Label>
</asp:Content>
