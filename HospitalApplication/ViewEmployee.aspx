<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewEmployee.aspx.cs"  MasterPageFile="~/Site.Master" Inherits="HospitalApplication.ViewEmployee" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<table>
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Label" > Search By</asp:Label>

        </td>
    </tr>
    <tr>
         <td>
  
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="SearchCall">
            
      
        <asp:ListItem value="EmpID">Emp.No
        </asp:ListItem>
        <asp:ListItem value="Name">Emp.Name</asp:ListItem>
        <asp:ListItem value="Status">Emp.Status</asp:ListItem>
        </asp:RadioButtonList>    


             
             </td>
      
       
      </tr>
    
    <tr>
        <td>
        <asp:TextBox ID="SearchByNameText" runat="server" Visible="false" >

    </asp:TextBox>
            </td>
        <td>
        <asp:Button ID="SearchByNameBtn" runat="server" Text="Button"  Visible="false" OnClick="SearchByName"/>
             
            </td>
    </tr>

    <tr>
        <asp:GridView ID="grdDoctorData" AutoGenerateColumns="false" runat="server"  >

        <Columns>
            
        <asp:TemplateField HeaderText="Emp Number"> 
            <ItemTemplate >
                
                <asp:Label ID="lblID" runat="server" Text='<%# Bind("EmployeeID") %>'></asp:Label>

            </ItemTemplate>
</asp:TemplateField>
            <asp:TemplateField HeaderText="Name"> 
            <ItemTemplate >
                <asp:Label ID="lblName" runat="server" Text='<%# Bind("EmployeeName") %>'></asp:Label>

            </ItemTemplate>
</asp:TemplateField>
            <asp:TemplateField HeaderText="Address"> 
            <ItemTemplate >
                <asp:Label ID="lblAddress" runat="server" Text='<%# Bind("EmployeeAdress") %>'></asp:Label>

            </ItemTemplate>
</asp:TemplateField>
            <asp:TemplateField HeaderText="Phone"> 
            <ItemTemplate >
                <asp:Label ID="lblPhone" runat="server" Text='<%# Bind("EmployeeContact") %>'></asp:Label>

            </ItemTemplate>
</asp:TemplateField>
            <asp:TemplateField HeaderText="DOB"> 
            <ItemTemplate >
                <asp:Label ID="lblDOB" runat="server" Text='<%# Bind("DOB") %>'></asp:Label>

            </ItemTemplate>
</asp:TemplateField>
            
            <asp:TemplateField HeaderText="Status"> 
            <ItemTemplate >
                <asp:Label ID="lblStatus" runat="server" Text='<%# Bind("Status") %>'></asp:Label>

            </ItemTemplate>
</asp:TemplateField>

            </Columns>
                    </asp:GridView>
    </tr>
</table>
</asp:Content>
