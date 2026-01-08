<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="WebApplication1.Shop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="all.min.css" rel="stylesheet" />
    

    <link href="fontawesome.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.1/css/all.min.css"  />
    <link href="bootstrap.min.css" rel="stylesheet" />
    <%--<link href="homemastercss.css" rel="stylesheet" />--%>
    <script src="bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
          <nav class="navbar " >
  <div class="container ">
     <div class="d-flex"> 
    <a class="navbar-brand">My logo</a>
         <img src="12.jpg" class="navbar-brand" alt="flower" style="height:auto; width:50px"/>

          <div class="d-flex" role="search">
              <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search" />
              <asp:Button ID="btnsearch" runat="server" Text="Search"  CssClass="btn btn-outline-danger"/> 
              
              
          </div>
      </div>
      <div id="Div1" class="float-end" runat="server">
     <a class="navbar-brand">Home</a>

          <%--<button class="btn btn-primary" type="button" data-bs-toggle="offcanvas" data-bs-target="#offcanvasright" aria-controls="offcanvasright">toggle right offcanvas</button>--%>

<div class="offcanvas offcanvas-end" tabindex="-1" id="offcanvasright" aria-labelledby="offcanvasrightlabel">
  <div class="offcanvas-header">
    <h5 class="offcanvas-title" id="offcanvasrightlabel">offcanvas right</h5>
    <button type="button" class="btn-close" data-bs-dismiss="offcanvas" aria-label="close"></button>
  </div>
  <div class="offcanvas-body">
    ...
  </div>
</div>

<%--              <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Cart.aspx">--%>
           <span class="position-absolute translate-middle badge rounded-pill bg-danger right:50"  style="z-index:12;margin-left:70px"><asp:Label ID="Label4" runat="server" Text="Label" Visible="True"></asp:Label></span>       
          <asp:Button ID="Button3" runat="server" Text="Button" CssClass="navbar-brand btn btn-primary position-relative "  data-bs-toggle="offcanvas" data-bs-target="#offcanvasright" aria-controls="offcanvasright" Style="z-index:5"/>
                   

 <%--<button type="button"  class="navbar-brand btn btn-primary position-relative" style="width:50px;height:50px" data-bs-toggle="offcanvas" data-bs-target="#offcanvasright" aria-controls="offcanvasright">
<span class="position-absolute top-0 start-100 translate-middle badge rounded-pill bg-danger">--%>
    <%--<asp:Label ID="Label4" runat="server" Text="Label" Visible="True"></asp:Label>--%>
      <%--<?php echo "5";?>--%><%--<span class="visually-hidden">unread message</span>--%>
           <%-- </span>
          </button>--%>
              <%--</asp:HyperLink>--%>


      <!-- Button trigger modal -->
<button type="button" class="navbar-brand btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal" >
    Login 
</button>
<%--      <asp:Button ID="Btn" runat="server" Text="Login" CssClass="navbar-brand btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal" EnableViewState="False" CausesValidation="False"/>--%>

<!-- Modal -->
          
<div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
    
  <div class="modal-dialog modal-dialog-centered">
    <div class="modal-content">
      <div class="modal-header">
        <h1 class="modal-title fs-5" id="exampleModalLabel">Please,login.....</h1>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
      </div>
      <div class="modal-body">
        
        
               
          <fieldset>
              <h3>Email</h3>
          <div class="d-flex">
          <asp:TextBox ID="txtemail" runat="server" ></asp:TextBox>  
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email is required" ControlToValidate="txtemail" CssClass="text-danger"></asp:RequiredFieldValidator>
              <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="error email" ControlToValidate="txtemail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red" CssClass="text-danger"></asp:RegularExpressionValidator>
              </div>
          <legend>Password</legend>
          <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>  
           <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password is required" ControlToValidate="txtpassword" CssClass="text-danger"></asp:RequiredFieldValidator><br />
          </fieldset>
          
        
      </div>
      
    </div>
  </div>
</div>

          <asp:Button ID="btnlogout" runat="server" Text="Log out" class="navbar-brand" OnClick="btnlogout_Click"/>
      
          </div>
  </div>
</nav>





        <div class="container mt-5">
            <div class="row ">
                <div class="col-3" >

                    <div style="border:2px solid black;box-shadow:whitesmoke 10px 10px 10px;border-radius:15px;text-align:center;width:200px">
                       
                        <h3>hello</h3>
                        <span>open and close</span>
                    </div>
                    </div>
                     <div class="col-3">

                    <div style="border:2px solid black;box-shadow:red 10px 10px 10px;border-radius:15px;text-align:center;width:200px">
                       
                        <h3>hello</h3>
                        <span>show</span>
                    </div>
                </div>
                     <div class="col-3">

                    <div style="border:2px solid black;box-shadow:red 10px 10px 10px;border-radius:15px;text-align:center;width:200px">
                       
                        <h3>hello</h3>
                        <asp:Button ID="Button4" runat="server" Text="Button" CausesValidation="False" EnableViewState="False" OnClick="Button4_Click" />
                    </div>
                </div>
                     <div class="col-3">

                    <div style="border:2px solid black;box-shadow:red 10px 10px 10px;border-radius:15px;text-align:center;width:200px">
                       
                        <h3>hello</h3>
                        <asp:Button ID="Button5" runat="server" Text="Button" CausesValidation="False" EnableViewState="False" OnClick="Button5_Click"  />
                    </div>
                </div>
                
            </div>
           
            <br />
            <br />
            
            <div class="container ">
                <div class="row">
                    
                     <div class="col-6" style="width:500px;height:500px">
                          <%--<asp:Label ID="Label5" runat="server" Visible="True" >--%>
    <table style="border:3px solid brown;width:100%" >
        <tr>
       <td> <asp:Label ID="lblfoodname" runat="server" Text="Foodname"></asp:Label></td>
        <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            </tr>
        <br />
         <tr>
       <td> <asp:Label ID="lblemail" runat="server" Text="Email"></asp:Label></td>
        <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            </tr>
    <tr>
       <td><asp:Label ID="lblprice" runat="server" Text="Price"></asp:Label></td>
        <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
        </tr>

         <tr>
       <td><asp:Label ID="lbltypeoffood" runat="server" Text="Type of Food"></asp:Label></td>
        <td><%--<asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple"></asp:ListBox>--%>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
        </tr>

        <%--<tr>
       <td><asp:fileupload id="fileupload1" runat="server" />
    
       </td>
            </tr>--%>
        <tr>
       <td> <asp:Label ID="lbldescription" runat="server" Text="Description"></asp:Label></td>
            
            <td>
                <asp:TextBox ID="TextBox5" runat="server" ></asp:TextBox>

            </td>
        </tr>
        <tr>
       <td><asp:Button ID="btnUpload" runat="server" Text="Cancel" OnClick="btnUpload_Click"/></td>
        

        </tr>
</table><%--</asp:Label>--%></div>
                </div>
            </div>
      






            <%--<center>
                <asp:Label ID="Label1" runat="server" Visible="False">
                  <table>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="lblfoodname1" runat="server" Text="FoodName"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td class="auto-style1">
                <asp:Label ID="lblemail1" runat="server" Text="Email"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtemail1" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td class="auto-style1">
                <asp:Label ID="lblprice1" runat="server" Text="Price"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtprice1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="lbltypeoffood1" runat="server" Text="Type Of Food"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txttypeoffood" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblimage" runat="server" Text="Image"></asp:Label>
            </td>
            <td class="auto-style3">
               <asp:Image ID="Image1" runat="server"></asp:Image>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lbldescription1" runat="server" Text="Description"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="txtdescription" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Button ID="btncancel" runat="server" Text="Cancel"></asp:Button>
            </td>
            <td> 
                <asp:Button ID="btnrequest" runat="server"  Text="Update" EnableEventValidation="false"  CausesValidation="False" EnableViewState="False"/>
            </td>
        </tr>
        
    </table></asp:Label>
            </center>--%>
        </div>


























       
    </div>
    </form>
</body>
</html>
