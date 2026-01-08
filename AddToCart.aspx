<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddToCart.aspx.cs" Inherits="foodservice.AddToCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 216px;
        }
        .auto-style2 {
            width: 177px;
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
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
     
    <div style="margin-top:200px;margin-left:500px;box-shadow:0px 0px 10px grey;width:30%;padding:20px;">
    <%--No1--%>
       
    <asp:Label ID="Cart1" runat="server" Text="Label" >
    <table class="w-100">
        <tr>
            <td class="auto-style1">
                <asp:Image ID="Cart1Image" runat="server" Height="82px" Width="134px" style="padding-right:20px;"/>
            </td>
            <td class="auto-style2">
                <asp:Label ID="Cart1Name" runat="server"  ></asp:Label>
                <br />
                <br />
                <asp:Label ID="Cart1Price" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Panel ID="Panel1" runat="server" Height="60px" Width="272px" style="padding-right:20px;">
                    <asp:Button ID="Cart1Minus" runat="server" Text="-" BorderStyle="None" Height="19px" Width="30px" BackColor="White" OnClick="Cart1Minus_Click" CausesValidation="False" EnableViewState="False"  />
                    <asp:Label ID="Cart1Total" runat="server" CssClass="text-center mt-0" Font-Strikeout="False" ></asp:Label>
                    <asp:Button ID="Cart1Plus" runat="server" BorderStyle="None" Height="24px" Text="+" Width="30px" BackColor="White" OnClick="Cart1Plus_Click" CausesValidation="False" EnableViewState="False" />
                </asp:Panel>
            </td>
        </tr>
    </table>
    </asp:Label>
    <%--No1--%>


    <%--No2--%>
    <asp:Label ID="Cart2" runat="server" Text="Label">
    <table class="w-100">
        <tr>
            <td class="auto-style1">
                <asp:Image ID="Cart2Image" runat="server" Height="82px" Width="134px" style="padding-right:20px;"/>
            </td>
            <td class="auto-style2">
                <asp:Label ID="Cart2Name" runat="server" ></asp:Label>
                <br />
                <br />
                <asp:Label ID="Cart2Price" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Panel ID="Panel2" runat="server" Height="60px" Width="272px" style="padding-right:20px;">
                    <asp:Button ID="Cart2Minus" runat="server" Text="-" BorderStyle="None" Height="19px" Width="27px" BackColor="White" OnClick="Cart2Minus_Click" CausesValidation="False" EnableViewState="False" />
                    <asp:Label ID="Cart2Total" runat="server" CssClass="text-center mt-0" Font-Strikeout="False" ></asp:Label>
                    <asp:Button ID="Cart2Plus" runat="server" BorderStyle="None" Height="24px" Text="+" Width="30px" BackColor="White" OnClick="Cart2Plus_Click" CausesValidation="False" EnableViewState="False" />
                </asp:Panel>
            </td>
        </tr>
    </table>
    </asp:Label>
    <%--No2--%>

    <%--No3--%>
    <asp:Label ID="Cart3" runat="server" Text="Label">
    <table class="w-100">
        <tr>
            <td class="auto-style1">
                <asp:Image ID="Cart3Image" runat="server" Height="82px" Width="134px" style="padding-right:20px;"/>
            </td>
            <td class="auto-style2">
                <asp:Label ID="Cart3Name" runat="server" ></asp:Label>
                <br />
                <br />
                <asp:Label ID="Cart3Price" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Panel ID="Panel3" runat="server" Height="60px" Width="272px" style="padding-right:20px;">
                    <asp:Button ID="Cart3Minus" runat="server" Text="-" BorderStyle="None" Height="19px" Width="27px" BackColor="White" OnClick="Cart3Minus_Click" CausesValidation="False" EnableViewState="False" />
                    <asp:Label ID="Cart3Total" runat="server" CssClass="text-center mt-0" Font-Strikeout="False" ></asp:Label>
                    <asp:Button ID="Cart3Plus" runat="server" BorderStyle="None" Height="24px" Text="+" Width="30px" BackColor="White" OnClick="Cart3Plus_Click" CausesValidation="False" EnableViewState="False" />
                </asp:Panel>
            </td>
        </tr>
    </table>
    </asp:Label>
    <%--No3--%>

    <%--No4--%>
    <asp:Label ID="Cart4" runat="server" Text="Label">
    <table class="w-100">
        <tr>
            <td class="auto-style1">
                <asp:Image ID="Cart4Image" runat="server" Height="82px" Width="134px" style="padding-right:20px;"/>
            </td>
            <td class="auto-style2">
                <asp:Label ID="Cart4Name" runat="server" ></asp:Label>
                <br />
                <br />
                <asp:Label ID="Cart4Price" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Panel ID="Panel4" runat="server" Height="60px" Width="272px" style="padding-right:20px;">
                    <asp:Button ID="Cart4Minus" runat="server" Text="-" BorderStyle="None" Height="19px" Width="27px" BackColor="White" OnClick="Cart4Minus_Click" CausesValidation="False" EnableViewState="False" />
                    <asp:Label ID="Cart4Total" runat="server" CssClass="text-center mt-0" Font-Strikeout="False" ></asp:Label>
                    <asp:Button ID="Cart4Plus" runat="server" BorderStyle="None" Height="24px" Text="+" Width="30px" BackColor="White" OnClick="Cart4Plus_Click" CausesValidation="False" EnableViewState="False" />
                </asp:Panel>
            </td>
        </tr>
    </table>
    </asp:Label>
    <%--No4--%>

    <%--No5--%>
    <asp:Label ID="Cart5" runat="server" Text="Label">
    <table class="w-100">
        <tr>
            <td class="auto-style1">
                <asp:Image ID="Cart5Image" runat="server" Height="82px" Width="134px" style="padding-right:20px;"/>
            </td>
            <td class="auto-style2">
                <asp:Label ID="Cart5Name" runat="server" ></asp:Label>
                <br />
                <br />
                <asp:Label ID="Cart5Price" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Panel ID="Panel5" runat="server" Height="60px" Width="272px" style="padding-right:20px;">
                    <asp:Button ID="Cart5Minus" runat="server" Text="-" BorderStyle="None" Height="19px" Width="27px" BackColor="White" OnClick="Cart5Minus_Click" CausesValidation="False" EnableViewState="False" />
                    <asp:Label ID="Cart5Total" runat="server" CssClass="text-center mt-0" Font-Strikeout="False" ></asp:Label>
                    <asp:Button ID="Cart5Plus" runat="server" BorderStyle="None" Height="24px" Text="+" Width="30px" BackColor="White" OnClick="Cart5Plus_Click" CausesValidation="False" EnableViewState="False" />
                </asp:Panel>
            </td>
        </tr>
    </table>
    </asp:Label>
    <%--No5--%>


    <%--No6--%>
    <asp:Label ID="Cart6" runat="server" Text="Label">
    <table class="w-100">
        <tr>
            <td class="auto-style1">
                <asp:Image ID="Cart6Image" runat="server" Height="82px" Width="134px" style="padding-right:20px;"/>
            </td>
            <td class="auto-style2">
                <asp:Label ID="Cart6Name" runat="server" ></asp:Label>
                <br />
                <br />
                <asp:Label ID="Cart6Price" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Panel ID="Panel6" runat="server" Height="60px" Width="272px" style="padding-right:20px;">
                    <asp:Button ID="Cart6Minus" runat="server" Text="-" BorderStyle="None" Height="19px" Width="27px" BackColor="White" OnClick="Cart6Minus_Click" CausesValidation="False" EnableViewState="False" />
                    <asp:Label ID="Cart6Total" runat="server" CssClass="text-center mt-0" Font-Strikeout="False" ></asp:Label>
                    <asp:Button ID="Cart6Plus" runat="server" BorderStyle="None" Height="24px" Text="+" Width="30px" BackColor="White" OnClick="Cart6Plus_Click" CausesValidation="False" EnableViewState="False" />
                </asp:Panel>
            </td>
        </tr>
    </table>
    </asp:Label>
    <%--No6--%>

    <%--No7--%>
    <asp:Label ID="Cart7" runat="server" Text="Label">
    <table class="w-100">
        <tr>
            <td class="auto-style1">
                <asp:Image ID="Cart7Image" runat="server" Height="82px" Width="134px" style="padding-right:20px;"/>
            </td>
            <td class="auto-style2">
                <asp:Label ID="Cart7Name" runat="server" ></asp:Label>
                <br />
                <br />
                <asp:Label ID="Cart7Price" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Panel ID="Panel7" runat="server" Height="60px" Width="272px" style="padding-right:20px;">
                    <asp:Button ID="Cart7Minus" runat="server" Text="-" BorderStyle="None" Height="19px" Width="27px" BackColor="White" OnClick="Cart7Minus_Click" CausesValidation="False" EnableViewState="False" />
                    <asp:Label ID="Cart7Total" runat="server" CssClass="text-center mt-0" Font-Strikeout="False" ></asp:Label>
                    <asp:Button ID="Cart7Plus" runat="server" BorderStyle="None" Height="24px" Text="+" Width="30px" BackColor="White" OnClick="Cart7Plus_Click" CausesValidation="False" EnableViewState="False" />
                </asp:Panel>
            </td>
        </tr>
    </table>
    </asp:Label>
    <%--No7--%>

    <%--No8--%>
    <asp:Label ID="Cart8" runat="server" Text="Label">
    <table class="w-100">
        <tr>
            <td class="auto-style1">
                <asp:Image ID="Cart8Image" runat="server" Height="82px" Width="134px" style="padding-right:20px;" />
            </td>
            <td class="auto-style2">
                <asp:Label ID="Cart8Name" runat="server" ></asp:Label>
                <br />
                <br />
                <asp:Label ID="Cart8Price" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Panel ID="Panel8" runat="server" Height="60px" Width="272px" style="padding-right:20px;">
                    <asp:Button ID="Cart8Minus" runat="server" Text="-" BorderStyle="None" Height="19px" Width="27px" BackColor="White" OnClick="Cart8Minus_Click" CausesValidation="False" EnableViewState="False" />
                    <asp:Label ID="Cart8Total" runat="server" CssClass="text-center mt-0" Font-Strikeout="False" ></asp:Label>
                    <asp:Button ID="Cart8Plus" runat="server" BorderStyle="None" Height="24px" Text="+" Width="30px" BackColor="White" OnClick="Cart8Plus_Click" CausesValidation="False" EnableViewState="False" />
                </asp:Panel>
            </td>
        </tr>
    </table>
    </asp:Label>
    <%--No8--%>

    <%--No9--%>
    <asp:Label ID="Cart9" runat="server" Text="Label">
    <table class="w-100">
        <tr>
            <td class="auto-style1">
                <asp:Image ID="Cart9Image" runat="server" Height="82px" Width="134px" style="padding-right:20px;" />
            </td>
            <td class="auto-style2">
                <asp:Label ID="Cart9Name" runat="server" ></asp:Label>
                <br />
                <br />
                <asp:Label ID="Cart9Price" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Panel ID="Panel9" runat="server" Height="60px" Width="272px" style="padding-right:20px;">
                    <asp:Button ID="Cart9Minus" runat="server" Text="-" BorderStyle="None" Height="19px" Width="27px" BackColor="White" OnClick="Cart9Minus_Click" CausesValidation="False" EnableViewState="False" />
                    <asp:Label ID="Cart9Total" runat="server" CssClass="text-center mt-0" Font-Strikeout="False" ></asp:Label>
                    <asp:Button ID="Cart9Plus" runat="server" BorderStyle="None" Height="24px" Text="+" Width="30px" BackColor="White" OnClick="Cart9Plus_Click" CausesValidation="False" EnableViewState="False" />
                </asp:Panel>
            </td>
        </tr>
    </table>
    </asp:Label>
    <%--No9--%>

    <%--No10--%>
    <asp:Label ID="Cart10" runat="server" Text="Label">
    <table class="w-100">
        <tr>
            <td class="auto-style1">
                <asp:Image ID="Cart10Image" runat="server" Height="82px" Width="134px" style="padding-right:20px;"/>
            </td>
            <td class="auto-style2">
                <asp:Label ID="Cart10Name" runat="server" ></asp:Label>
                <br />
                <br />
                <asp:Label ID="Cart10Price" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Panel ID="Panel10" runat="server" Height="60px" Width="272px" style="padding-right:20px;">
                    <asp:Button ID="Cart10Minus" runat="server" Text="-" BorderStyle="None" Height="19px" Width="27px" BackColor="White" OnClick="Cart10Minus_Click" CausesValidation="False" EnableViewState="False" />
                    <asp:Label ID="Cart10Total" runat="server" CssClass="text-center mt-0" Font-Strikeout="False" ></asp:Label>
                    <asp:Button ID="Cart10Plus" runat="server" BorderStyle="None" Height="24px" Text="+" Width="30px" BackColor="White" OnClick="Cart10Plus_Click" CausesValidation="False" EnableViewState="False" />
                </asp:Panel>
            </td>
        </tr>
    </table>
    </asp:Label>
    <%--No10--%>


        <hr />

        <%--<asp:Label ID="lbltotal" runat="server" Text="Total:"></asp:Label>
        <asp:Label ID="lblTo" runat="server"></asp:Label>--%>

        <div class="container ">

            <div class="row">
                <div class="col-6"> <asp:Label ID="Label3" runat="server" Text="သင့်တည်နေရာကိုရွေးချယ်ပါ"></asp:Label></div>
                <div class="col-2"></div>
                <div class="col-4"><asp:DropDownList ID="Location" runat="server"  placeholder="Location" style="display:block;margin-right:50px;margin-bottom:5px;">
            <asp:ListItem Value="1">Phayagi</asp:ListItem>
            <asp:ListItem Value="2">ShweDaGar</asp:ListItem>
            <asp:ListItem Value="3">MyotThit</asp:ListItem>
        </asp:DropDownList></div>
            </div>
        </div>
        
        <div class="container">

            <div class="row">
                <div class="col-6">
                    <asp:Label ID="Label2" runat="server" Text="သင့်ဖုန်းနံပါတ်ထည့်ပါ"></asp:Label></div>
                <div class="col-4"> <div style="display:block;">
        <asp:TextBox ID="ph" runat="server"  placeholder="Phone Number" Style="margin-bottom:10px;"></asp:TextBox>
        
        </div></div>
                <div class="col-2">
       </div></div></div>

        <div class="container">

            <div class="row">
                <div class="col-6"></div>
                <div class="col-3"></div>
                <div class="col-2"><asp:Button ID="UserOrder"  runat="server" Text="Order" CausesValidation="False" EnableViewState="False" OnClick="UserOrder_Click"  CssClass="sbutton" /></div>


               
    </div>
            <div class="row">
                <asp:Label ID="lblyes" runat="server" Visible="false"></asp:Label>
                 <asp:Label ID="Label1" runat="server" Visible="false"></asp:Label>
                 <asp:Label ID="Label4" runat="server" Visible="false"></asp:Label>
                 <asp:Label ID="Label5" runat="server" Visible="false"></asp:Label>
                 <asp:Label ID="Label6" runat="server" Visible="false"></asp:Label>
                <asp:Label ID="Label7" runat="server" Visible="false"></asp:Label>
                <asp:Label ID="lblno" runat="server" Visible="false"></asp:Label>
                
                <asp:Label ID="Label8" runat="server" Visible="false"></asp:Label>
                <asp:Label ID="Label9" runat="server" Visible="false"></asp:Label>
                <asp:Label ID="Label10" runat="server" Visible="false"></asp:Label>
                <asp:Label ID="Label11" runat="server" Visible="false"></asp:Label>
                <asp:Label ID="Label12" runat="server" Visible="false"></asp:Label>
                <asp:Label ID="Label13" runat="server" Visible="false"></asp:Label>
                <asp:Label ID="Label14" runat="server" Visible="false"></asp:Label>
                
                <asp:Label ID="Label15" runat="server" Visible="false"></asp:Label>
                <asp:Label ID="Label16" runat="server" Visible="false"></asp:Label>
                <asp:Label ID="Label17" runat="server" Visible="false"></asp:Label>
                <asp:Label ID="Label18" runat="server" Visible="false"></asp:Label>
                <asp:Label ID="Label19" runat="server" Visible="false"></asp:Label>
                <asp:Label ID="Label20" runat="server" Visible="false"></asp:Label>



            </div>
            </div>
            
        </div>
   
</asp:Content>

