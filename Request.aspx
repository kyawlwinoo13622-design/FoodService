<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Request.aspx.cs" Inherits="foodservice.Request" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container " style="margin-top:150px;">
        <div class="row">

        <div class="col-9">
    <asp:GridView ID="GridView1" runat="server" Visible="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="249px" Width="808px" >
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
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
       <div class="col-3" >
            <table class="">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" AutoPostBack="True"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="Label2" runat="server" Text="Name"></asp:Label></td>
                    <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label3" runat="server" Text="Email"></asp:Label></td>
                    <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label4" runat="server" Text="Password"></asp:Label></td>
                    <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="Label5" runat="server" Text="Shopname"></asp:Label></td>
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
       <td> <asp:Button ID="Button1" runat="server" Text="Accept" CausesValidation="False" EnableViewState="False" OnClick="Button1_Click"  CssClass="sbutton" /></td>
   </tr>
   </table>
            </div>
        </div>
    </div>
</asp:Content>
