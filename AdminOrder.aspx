<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminOrder.aspx.cs" Inherits="foodservice.AdminOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="margin-top:200px;">
        <div class="row">
            
        <div class="col-9">
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" GridLines="None" ForeColor="#333333"  Height="249px" Width="100%">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
    </div>
            <div class="col-2">
            <asp:Label ID="sendLabel" runat="server" >
            
                <table class="w-100">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" AutoPostBack="True"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="Label2" runat="server" Text="Email"></asp:Label></td>
                    <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label3" runat="server" Text="Foodname"></asp:Label></td>
                    <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label4" runat="server" Text="Qty"></asp:Label></td>
                    <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="Label5" runat="server" Text="Amount"></asp:Label></td>
                    <td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="Label6" runat="server" Text="Shopname"></asp:Label></td>
                    <td><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="Label7" runat="server" Text="Location"></asp:Label></td>
                    <td><asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label8" runat="server" Text="Phnumber"></asp:Label></td>
                    <td><asp:TextBox ID="TextBox8" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label9" runat="server" Text="Date"></asp:Label></td>
                    <td><asp:TextBox ID="TextBox9" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label10" runat="server" Text="Time"></asp:Label></td>
                    <td><asp:TextBox ID="TextBox10" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label11" runat="server" Text="DelivaryName"></asp:Label></td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                          
          
                        </asp:DropDownList>
                    </td>
                </tr>

        
   <tr>
       <td> <asp:Button ID="Button1" runat="server" Text="Send" CausesValidation="False" EnableViewState="False" OnClick="Button1_Click"  CssClass="sbutton" /></td>
   </tr>
   </table>
            
                </asp:Label></div>
            </div>
        </div>
    
</asp:Content>
