<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="foodservice.delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container"style="margin-top:180px">
        <div class="row">
            <div class="col-3"></div>
            <div class="col-6">
                  <div style="width:90%;box-shadow: 0px 0px 10px grey;padding:30px;height:100%">
    <asp:Label ID="Label8" runat="server" Text="Label" Visible="False">
                  <div class="alert alert-success alert-dismissible fade show" role="alert">
  <strong>Successful!</strong> သင့်ထည့်သွင်းမှူအောင်မြင်ပါသည်..
  <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
</div>
               </asp:Label>
     <table class="w-100" >
       <tr>
           <td><asp:Label ID="Label4" runat="server" Text="Email"></asp:Label></td>
            <td> <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /></td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="သင့်အီးမေးထည့်ပါ" ControlToValidate="TextBox1" ForeColor="#CC0000"></asp:RequiredFieldValidator></td>
     </tr>
       
 
    <tr>
                <td><asp:Button ID="Button1"  runat="server" Text="delete" OnClick="Button1_Click" CssClass="sbutton" /></td>
    </tr>
        </table></div>
           <div class="col-3"></div>
                </div></div>
</asp:Content>
