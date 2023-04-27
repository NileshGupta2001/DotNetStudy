<%@ Page Title="Update Doctors" Language="C#" EnableEventValidation="true" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateDoctor.aspx.cs" Inherits="HospitalApplication.UpdateDoctor" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <asp:GridView ID="grdUpdDoctorData" AutoGenerateColumns="false" runat="server" OnRowCommand="grdUpdDoctorData_RowCommand" >

        <Columns>
            
        <asp:TemplateField HeaderText="Name"> 
            <ItemTemplate >
                
                <asp:TextBox ID="updName" runat="server" Text='<%# Bind("Name") %>' MaxLength="100"></asp:TextBox>
            </ItemTemplate>
</asp:TemplateField>
            <asp:TemplateField HeaderText="Speciality"> 
            <ItemTemplate >
                <asp:DropDownList ID="SpecialityLst" runat="server" >
            <asp:ListItem Value="">Please Select</asp:ListItem>  
            <asp:ListItem> NeuroSurgeon </asp:ListItem>  
            <asp:ListItem>Dentist  </asp:ListItem>  
            <asp:ListItem>Psychiatrist</asp:ListItem>  
            <asp:ListItem>Pediatrics</asp:ListItem>  
        </asp:DropDownList>

            </ItemTemplate>
</asp:TemplateField>
            <asp:TemplateField HeaderText="Years of Experience"> 
            <ItemTemplate >
                <asp:TextBox ID="updExp" TextMode="Number" runat="server" min="0" max="50" step="1"/>

            </ItemTemplate>
</asp:TemplateField>
            <asp:TemplateField HeaderText="Gender"> 
            <ItemTemplate >
                <asp:DropDownList ID="GenderLst" runat="server" >
            <asp:ListItem Value="">Please Select</asp:ListItem>  
            <asp:ListItem> Male </asp:ListItem>  
            <asp:ListItem>Female  </asp:ListItem>  
            <asp:ListItem>Others</asp:ListItem>  
            
        </asp:DropDownList>

            </ItemTemplate>
</asp:TemplateField>
            <asp:TemplateField HeaderText="Update"> 
            <ItemTemplate >
                <asp:Button ID="btnUpdate" runat="server" Text="Update" CommandName="Update" CommandArgument='<%# Bind("ID") %>' />
            </ItemTemplate>
</asp:TemplateField>
    
        </Columns>
    </asp:GridView>
    
</asp:Content>
