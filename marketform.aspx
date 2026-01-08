<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="marketform.aspx.cs" Inherits="foodservice.marketform" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 370px;
        }
        .auto-style2 {
            width: 370px;
            height: 24px;
        }
        .auto-style3 {
            height: 24px;
        }
        .auto-style4 {
            width: 370px;
            height: 30px;
        }
        .auto-style5 {
            height: 30px;
        }
        .btttn {
            background-color:darkseagreen;
            border:none;
            transition:background-color 1s,border 1s,opacity 1s;
        }
            .btttn:hover {
                background-color:darkseagreen;
                border:1px solid black;
                border-radius:5px;
               opacity:0.4;
                
            }
            .sbutton { background-color:darkseagreen;
                   border-radius:2px;
                    transition:background-color 1s,border 1s,opacity 1s;
         }
            .sbutton:hover {
                 background-color:darkseagreen;
                border:1px solid black;
                border-radius:5px;
               opacity:0.8;
             }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <%--class="alert alert-success d-flex align-items-center"
    class="bi flex-shrink-0 me-2"--%>
    <div class="container " style="margin-top:200px;margin-bottom:200px;">
        <div class="row">
            <div class="col-3"></div>
            <div class="col-6">   
                <div style="width:100%;box-shadow: 0px 0px 10px grey;padding:55px;">
               <asp:Label ID="Label1" runat="server" Text="Label" Visible="False">
                  <div class="alert alert-success alert-dismissible fade show" role="alert">
  <strong>Successful!</strong> သင့်ထည့်သွင်းမှူအောင်မြင်ပါသည်..
  <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
</div>
               </asp:Label>
    <table class="w-100">
        <tr>
            <td class="auto-style1">
                <asp:Label ID="lblname" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Name is required" ControlToValidate="txtname" ForeColor="#CC0000" CssClass="text-danger"></asp:RequiredFieldValidator></td>
        </tr>
         <tr>
            <td class="auto-style1">
                <asp:Label ID="lblemail" runat="server" Text="Email"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
            </td>
             <td> <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email is required" ControlToValidate="txtemail" CssClass="text-danger"></asp:RequiredFieldValidator>
              <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="error email" ControlToValidate="txtemail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red" CssClass="text-danger"></asp:RegularExpressionValidator></td>
        </tr>
         <tr>
            <td class="auto-style1">
                <asp:Label ID="lblpassword" runat="server" Text="Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
             <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Password is required" ControlToValidate="txtpassword" ForeColor="#CC0000" CssClass="text-danger"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="lblshopname" runat="server" Text="shopname"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtshopname" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Shopname is required" ControlToValidate="txtshopname" ForeColor="#CC0000" CssClass="text-danger"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblphonenumber" runat="server" Text="Phonenumber"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtphonenumber" runat="server" TextMode="Phone"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Phonenumber is required" ControlToValidate="txtphonenumber" ForeColor="#CC0000" CssClass="text-danger"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Please enter phonenumber" ControlToValidate="txtphonenumber" ForeColor="#CC0000" CssClass="text-danger" ValidationExpression="phone"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lbllocation" runat="server" Text="Location"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="txtlocation" runat="server"></asp:TextBox>
            </td>
             <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Location is required" ControlToValidate="txtlocation" ForeColor="#CC0000" CssClass="text-danger"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CausesValidation="False" EnableViewState="False" CssClass="btn btn-danger" />
            </td>
            <td> 
               <%-- <asp:Button ID="btnrequest" runat="server" OnClick="btnrequest_Click" Text="Request"  CssClass="buton-kayit-ekle" CausesValidation="False" EnableViewState="False"/>--%>
                <asp:Button ID="Button1" runat="server" Text="Request" OnClick="Button1_Click" CausesValidation="False" EnableViewState="False" CssClass="btn btn-success" />
            </td>
        </tr>
       
    </table></div></div>
            <div class="col-3"></div>
        </div>
    </div>
 
   
</asp:Content>
