<%@ Page Title="" Language="C#" MasterPageFile="~/Shopkeeper.Master" AutoEventWireup="true" CodeBehind="Shopkeeper1.aspx.cs" Inherits="foodservice.Shopkeeper1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container " style="margin-top:180px">
        <div class="row">
            <div class="col-3"></div>
            <div class="col-6">
                 <div style="width:100%;box-shadow: 0px 0px 10px grey;padding:55px;">
                     <asp:Label ID="Label8" runat="server" Text="Label" Visible="False">
                  <div class="alert alert-success alert-dismissible fade show" role="alert">
  <strong>Successful!</strong> သင့်ထည့်သွင်းမှူအောင်မြင်ပါသည်..
  <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
</div>
               </asp:Label>
                <table class="w-100">

        <tr>
            <td style="margin-left:10px;"><asp:Label ID="lblopen" runat="server" Text="ဖွင့်ချိန်"></asp:Label></td>
            <td><asp:TextBox ID="txt1" runat="server"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td><asp:Label ID="lblclose" runat="server" Text="close"></asp:Label></td>
            <td> <asp:TextBox ID="txt2" runat="server"></asp:TextBox></td>  
        </tr>
         <tr style="padding-top:10px;">
             <td><asp:Button ID="btncancel" CssClass="ebutton" runat="server" Text="Cancel" OnClick="btncancel_Click"></asp:Button></td>
             <td><asp:Button ID="btninsert" CssClass="sbutton" runat="server" OnClick="btninsert_Click" Text="Insert" EnableViewState="False" CausesValidation="False"></asp:Button></td>
         </tr>
         </table></div></div>
            <div class="col-3"></div>
        </div>
    </div>
     
        

</asp:Content>
