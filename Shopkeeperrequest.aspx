<%@ Page Title="" Language="C#" MasterPageFile="~/Shopkeeper.Master" AutoEventWireup="true" CodeBehind="Shopkeeperrequest.aspx.cs" Inherits="foodservice.Shopkeeperrequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="margin-top:250px;">
        <div class="row">
            
        <div class="col-9">
    <asp:GridView ID="GridView1" runat="server" Visible="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="249px" Width="100%">
        
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
        
    </asp:GridView>
        </div>
     <div class="col-2 " >
            <table class="">
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
                    <td><asp:Label ID="Label4" runat="server" Text="Quantity"></asp:Label></td>
                    <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="Label5" runat="server" Text="Amount"></asp:Label></td>
                    <td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="Label6" runat="server" Text="PhNumber"></asp:Label></td>
                    <td><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="Label7" runat="server" Text="Location"></asp:Label></td>
                    <td><asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label8" runat="server" Text="Date"></asp:Label></td>
                    <td><asp:TextBox ID="TextBox8" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label9" runat="server" Text="Time"></asp:Label></td>
                    <td><asp:TextBox ID="TextBox9" runat="server"></asp:TextBox></td>
                </tr>
        
   <tr>
       <td> <asp:Button ID="Button2" runat="server" Text="Cancel" CausesValidation="False" EnableViewState="False" OnClick="Button2_Click"   /></td>
       <td> <asp:Button ID="Button1" runat="server" Text="Confirm" CausesValidation="False" EnableViewState="False" OnClick="Button1_Click"   /></td>
       
   </tr>
   </table>
            </div>
        </div>
    </div>
</asp:Content>
