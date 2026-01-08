<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Deliveryform.aspx.cs" Inherits="foodservice.Deliveryform" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="margin-top:180px">
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
       <tr >
           <td><asp:Label ID="lblname" runat="server" Text="Name"></asp:Label></td>
            <td> <asp:TextBox ID="txtname" runat="server"></asp:TextBox><br /></td>
          <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="သင့်နာမည်ထည့်ပါ" ControlToValidate="txtname" ForeColor="#CC0000"></asp:RequiredFieldValidator></td>
     </tr>
       <tr>
           <td><asp:Label ID="lblemail" runat="server" Text="Email"></asp:Label></td>
           <td> <asp:TextBox ID="txtemail" runat="server"></asp:TextBox></td>
           <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="သင့်အီးမေးထည့်ပါ" ControlToValidate="txtemail" ForeColor="#CC0000"></asp:RequiredFieldValidator></td>
       </tr>
   <tr>
       <td><asp:Label ID="lbllocation" runat="server" Text="Location"></asp:Label></td>
       <td><asp:DropDownList ID="DropDownList1" runat="server">
           <asp:ListItem Value="1">Shwedaga</asp:ListItem>
           <asp:ListItem Value="2">Phayagyi</asp:ListItem>
           <asp:ListItem Value="3">Myothit</asp:ListItem>
           <asp:ListItem></asp:ListItem>
           </asp:DropDownList></td>
   </tr>
  <tr>
           <td><asp:Label ID="lblphone" runat="server" Text="Phonenumber"></asp:Label></td>
           <td> <asp:TextBox ID="txtphone" runat="server"></asp:TextBox></td>
    
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="သင့်ဖုန်းနံပါတ်ထည့်ပါ" ControlToValidate="txtphone" ForeColor="#CC0000"></asp:RequiredFieldValidator></td>
       </tr>
   <tr>
       <td><asp:Label ID="lblpassword" runat="server" Text="Password"></asp:Label></td>
       <td><asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox></td>
       <td><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="သင့်ပတ်စဝှက်ထည့်ပါ" ControlToValidate="txtpassword" ForeColor="#CC0000"></asp:RequiredFieldValidator></td>
   </tr>
    <tr>
        <td><asp:Button ID="btncancel"  runat="server" Text="cancel" CssClass="ebutton" OnClick="btncancel_Click" CausesValidation="False" EnableViewState="False" /></td>
        <td><asp:Button ID="btninsert" CssClass="sbutton" runat="server" Text="insert" OnClick="btninsert_Click" CausesValidation="False" EnableViewState="False" /></td>
    </tr>
        </table>
      
        </div>
            </div>
            <div class="col-3"></div>
        </div>
    </div>


    
</asp:Content>
