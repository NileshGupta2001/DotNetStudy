<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Employee.aspx.cs" Inherits="HospitalApplication.Employee" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<table>
    <tr>
        <td>
    <asp:Label runat="server" Text="Employee No."></asp:Label>
            </td>
        <td>
    <asp:TextBox runat="server" id="ID"></asp:TextBox>
            </td>
        </tr>
    <tr>
        <td>
    <asp:Label runat="server" Text="Employee Name."></asp:Label>
            </td>
        <td>
    <asp:TextBox runat="server" id="Name"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td>
    <asp:Label runat="server" Text="Employee Address"></asp:Label>
            </td>
        <td>
    <asp:TextBox runat="server" id="Address"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td>
    <asp:Label runat="server" Text="Phone"></asp:Label>
            </td>
        <td>
    <asp:TextBox runat="server" id="Phone"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td>
    <asp:Label runat="server" Text="Dob"></asp:Label>
        </td>
        <td>
    <asp:Calendar runat="server" id="Dob"></asp:Calendar>
            </td>
    </tr>
    <tr>
        <td>
        <asp:Button runat="server" Text="Add" id="Add" OnClick="InsertEmployee"/>
            

    </td>
        <td>
            <a runat="server" href="~/ViewEmployee">View</a></li>
            
        </td>
            </tr>

    <tr>
        <td>
             <asp:Label ID="lblmsg" runat="server" Text="Label" Visible="False" ></asp:Label>
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

                <asp:Label ID="lblSpeciality" runat="server" Text='<%# Bind("Status") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                   <asp:DropDownList ID="updSpeciailtyLst" runat="server" >
            <asp:ListItem Value="">Please Select</asp:ListItem>  
            <asp:ListItem>Permanent </asp:ListItem>  
            <asp:ListItem>Temporary  </asp:ListItem>  
 
        </asp:DropDownList>
                </EditItemTemplate>
                </asp:TemplateField>
            

            </Columns>
                    </asp:GridView>
            
    </tr>
</table>


</asp:Content>
