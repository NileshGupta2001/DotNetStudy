<%@ Page Title="Show Doctors"  EnableEventValidation="true" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewDoctors.aspx.cs" Inherits="HospitalApplication.ViewDoctors" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <asp:GridView ID="grdDoctorData" AutoGenerateColumns="false" runat="server" OnRowCommand="grdDoctorData_RowCommand" >

        <Columns>
            
        <asp:TemplateField HeaderText="Doctor ID"> 
            <ItemTemplate >
                <asp:Label ID="lblID" runat="server" Text='<%# Bind("ID") %>'></asp:Label>

            </ItemTemplate>
</asp:TemplateField>
            <asp:TemplateField HeaderText="Name"> 
            <ItemTemplate >
                <asp:Label ID="lblName" runat="server" Text='<%# Bind("Name") %>'></asp:Label>

            </ItemTemplate>
                <EditItemTemplate>
                 <asp:TextBox ID="updName" runat="server" Text='<%# Bind("Name") %>' MaxLength="100"></asp:TextBox>
                    </EditItemTemplate>
</asp:TemplateField>
            <asp:TemplateField HeaderText="Speciality"> 
            <ItemTemplate >

                <asp:Label ID="lblSpeciality" runat="server" Text='<%# Bind("Speciality") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                   <asp:DropDownList ID="updSpeciailtyLst" runat="server" >
            <asp:ListItem Value="">Please Select</asp:ListItem>  
            <asp:ListItem> NeuroSurgeon </asp:ListItem>  
            <asp:ListItem>Dentist  </asp:ListItem>  
            <asp:ListItem>Psychiatrist</asp:ListItem>  
            <asp:ListItem>Pediatrics</asp:ListItem>  
        </asp:DropDownList>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Edit"> 
            <ItemTemplate >
                <asp:Button ID="btnEdit" runat="server" Text="Edit" CommandName="Edit" CommandArgument='<%# Bind("ID") %>' />

            </ItemTemplate>
</asp:TemplateField>
            <asp:TemplateField HeaderText="Delete"> 
            <ItemTemplate >
                <asp:Button ID="btnDelete" runat="server" Text="Delete" CommandName="Delete" CommandArgument='<%# Bind("ID") %>' />

            </ItemTemplate>
</asp:TemplateField>
    
        </Columns>
    </asp:GridView>
    
</asp:Content>
