<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delivary.aspx.cs" Inherits="foodservice.Delivary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="utf-8" />
    <meta charset="iso-8859-1" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title></title>
   <link href="bootstrap.min.css" rel="stylesheet" />
    <%--<link href="homemastercss.css" rel="stylesheet" />--%>
    <script src="bootstrap.min.js"></script>
     <link href="all.min.css" rel="stylesheet" />
    <link href="fontawesome.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.1/css/all.min.css"  />
    
    <link href="Mycss.css" rel="stylesheet" />
    
     <style type="text/css">
        
        .btttn {
            background-color:white;
            border:none;
            transition:background-color 1s,border 1s,opacity 1s;
        }
            .btttn:hover {
                background-color:darkseagreen;
                border:1px solid black;
                border-radius:5px;
               opacity:0.6;
                
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
            .ebutton { background-color:red;
                   border-radius:2px;
                    transition:background-color 1s,border 1s,opacity 1s;
         }
            .ebutton:hover {
                 background-color:red;
                border:1px solid black;
                border-radius:5px;
               opacity:0.8;
             }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
          <div class="container" style="margin-top:60px">
        <div class="row">
            <div class="col-0"></div>
            <div class="col-12">
                <div style="width:100%;box-shadow: 0px 0px 10px grey;padding:55px;height:auto;">


                    <div class="row mt-0" style="margin-bottom:100px;">
                        
                        <div class="col-auto"> <a class="navbar-brand"><i>Food Service</i></a> <img src="12.jpg" class="navbar-brand" alt="flower" style="height:auto; width:50px;margin-right:780px;"/></div>
                        
        
                        <div class="col-auto">
                            <asp:Button ID="Button1" runat="server" Text="Home"  CssClass="navbar-brand btttn " style="font-size:20px;" EnableViewState="False" CausesValidation="False"  PostBackUrl="~/homemaster.aspx" />


                        <%--<span class=" translate-middle badge rounded-pill bg-danger" style="position:absolute;margin-left:0px;z-index:4; top: 120px; left: 1150px; ">
                    <asp:label id="label2" runat="server" text="label" visible="true"></asp:label>
                     </span>
                             <asp:Button ID="btnnoti"  runat="server" Text="noti" class="navbar-brand btn btn-primary position-relative" style="width:50px;height:50px;z-index:1; top: 1px; left: 0px;" CausesValidation="False" EnableViewState="False" />--%>
                              <i class="fa-regular fa-bell position-relative navbar-brand" style="width:30px;height:30px;font-size:35px;color:black;margin-right:20px;" onload="count()">
             <span class="position-absolute top-0 start-100 translate-middle badge rounded-pill bg-danger" style="margin-right:25px;">
    <asp:Label ID="label2" runat="server" ></asp:Label>
   </span></i>

                            <asp:Button ID="btnlogoutd" runat="server" Text="Logout" CausesValidation="False" EnableViewState="False" style="margin-bottom:200px;font-size:20px;" OnClick="btnlogoutd_Click" CssClass="navbar-brand btttn" />
                        </div>
                        
                        
       

</div>
                    <div class="container "  style="border:1px solid black;margin-bottom:20px;">
                        <div class="row" style="margin-bottom: 50px;margin-top:50px;margin-left:20px">
                            <div class="col">
                                <asp:Label ID="Label3" runat="server" Text="Customer Email" Style="margin-left: 10px;"></asp:Label>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </div>
                            <div class="col">
                                <asp:Label ID="Label4" runat="server" Text="Customer Password"></asp:Label>
                                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                            </div>
                            <div class="col">
                                <asp:Label ID="Label5" runat="server" Text="Food Name"></asp:Label>
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                            </div>
                            <div class="col">
                                <asp:Label ID="Label6" runat="server" Text="Quantity"></asp:Label>
                                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                            </div>
                            <div class="col">
                                <asp:Label ID="Label1" runat="server" Text=" " ></asp:Label>
                                <br />
                                <asp:CheckBox ID="CheckBox1" runat="server" Text=" လက်ံခံရရှိပါသည်" OnCheckedChanged="CheckBox1_CheckedChanged" AutoPostBack="True" />
                            </div>

                        </div>
















                        <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
                </div>
             <div class="col-0"></div>
            <%--<asp:Label ID="Label7" runat="server" Text="ex"></asp:Label>--%>
            </div></div>

        
    </div>
    </form>
</body>
</html>
