<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="foodservice.Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Bootstrap demo</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />

    <style type="text/css">
        .auto-style1 {
            width: 1257px;
        }
        .auto-style3 {
            width: 90px;
        }
        .auto-style4 {
            width: 158px;
        }
        .auto-style5 {
            width: 205px;
            height: 34px;
        }
        .auto-style6 {
            height: 34px;
        }
        .auto-style7 {
            height: 34px;
            width: 929px;
        }
    </style>

  </head>
  <body>
      
      <form id="form1" runat="server">
          <nav class="navbar navbar-expand-lg bg-body-tertiary">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Navbar scroll</a>
      <asp:Button ID="Button1" runat="server" Text="Button" /><button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarScroll" aria-controls="navbarScroll" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarScroll">
      <ul class="navbar-nav me-auto my-2 my-lg-0 navbar-nav-scroll" style="--bs-scroll-height: 100px;">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="#">Home</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Link</a>
        </li>
        <li class="nav-item dropdown">
          <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
            Link
          </a>
          <ul class="dropdown-menu">
            <li><a class="dropdown-item" href="#">Action</a></li>
            <li><a class="dropdown-item" href="#">Another action</a></li>
            <li><hr class="dropdown-divider"></li>
            <li><a class="dropdown-item" href="#">Something else here</a></li>
          </ul>
        </li>
        <li class="nav-item">
          <a class="nav-link disabled" aria-disabled="true">Link</a>
        </li>
      </ul>
      <form class="d-flex" role="search">
        <input class="form-control me-2 " type="search" placeholder="Search" aria-label="Search">
        <button class="btn btn-outline-danger" type="submit">Search</button>
      </form>
    </div>
  </div>
</nav>
      <div style="height: 540px" class="bg-danger-subtle">
                  
          <asp:Panel ID="Panel1" runat="server" BackColor="#99FF33" ForeColor="Lime" Height="110px">
              <table class="w-100">
                  <tr>
                      <td class="auto-style5">
                          <asp:ImageButton ID="ImageButton2" runat="server" />
                      </td>
                      <td class="auto-style7">
                          <asp:TextBox ID="TextBox2" runat="server" Width="151px"></asp:TextBox>
                          <asp:Button ID="btnsearch0" runat="server" Text="search" />
                      </td>
                      <td class="auto-style6">
                          <asp:Button ID="Button5" runat="server" Text="Register" />
                      </td>
                      <td class="auto-style6">
                          <asp:Button ID="Button6" runat="server" Text="Login" />
                      </td>
                  </tr>
              </table>
          </asp:Panel>
              
          
              
          </div>
          
          <div class="container">
              <div class="row">
                  <div class="col-4">
          
           <div class="card" style="width: 18rem;border:none">
  <img src="10.jpg" class="card-img-top " alt="flower" style="border-radius:10%; height: 131px; width: 209px; margin-left: 0px; margin-right: 0px; margin-top: 10px;" />
  <div class="card-body">
    <h5 class="card-title">Card title</h5>
    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
    <a href="#" class="btn btn-primary">Go somewhere</a>
  </div>
</div>
                      </div></div></div>
      </form>
  </body>

</html>
