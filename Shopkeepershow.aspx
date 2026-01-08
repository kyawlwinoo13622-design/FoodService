<%@ Page Title="" Language="C#" MasterPageFile="~/Shopkeeper.Master" AutoEventWireup="true" CodeBehind="Shopkeepershow.aspx.cs" Inherits="foodservice.Shopkeepershow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container" style="margin-top:100px;">
        <div class="row">
          
                <asp:Label ID="Label1" runat="server"  CssClass="d-flex mt-5" >
            <asp:Label ID="lblFirst" runat="server" >
        <div class='col-4 m-4'>
            <div class='card' style='width: 18rem;box-shadow:0px 0px 10px grey;'>
                <asp:Image ID="image1" runat="server"  />
                <div class='card-body'>
                    <h5 class='card-title'>
                        <asp:Label ID="lblfoodname1" runat="server"></asp:Label>
                     </h5>
           
                     
                        <asp:Label ID="lblprice1" runat="server"  CssClass="card-text"></asp:Label>
                    
                  <br />
                     
                     <asp:Label ID="lbldescription1" runat="server" CssClass="card-text"></asp:Label>
                       
                   <br /><br />
                 
                   <%-- <asp:Button ID="btnex" runat="server" Text="ex" CausesValidation="False" EnableViewState="False" OnClicK="btnex_Click"/>--%>

                </div>
                
            </div>

        </div></asp:Label>
            <%--<asp:Label ID="Label1" runat="server" Text="Label">
             </asp:Label>

            <asp:Label ID="lblview1" runat="server" Text="view" Visible="False"></asp:Label>--%>

                     <asp:Label ID="lblSecond" runat="server" >
        <div class='col-4 m-4'>
            <div class='card' style='width: 18rem;box-shadow:0px 0px 10px grey'>
                <asp:Image ID="image2" runat="server" />
                <div class='card-body'>
                    
                    <h5 class='card-title'>
                        <asp:Label ID="lblfoodname2" runat="server" CssClass="card-text"></asp:Label>
                     </h5>
           
                    
                        <asp:Label ID="lblprice2" runat="server" CssClass="card-text"></asp:Label>
                   <br />
                    
                         <asp:Label ID="lbldescription2" runat="server" CssClass="card-text"></asp:Label>
                    <br /><br />
                    
                </div>

            </div>

        </div></asp:Label>

                  
                     <asp:Label ID="lblThird" runat="server" >
        <div class='col-4 m-4'>
            <div class='card' style='width: 18rem;box-shadow:0px 0px 10px grey'>
                <asp:Image ID="image5" runat="server" />
                <div class='card-body'>
                     
                    <h5 class='card-title'>
                        <asp:Label ID="lblfoodname3" runat="server" CssClass="card-text"></asp:Label>
                     </h5>
           
                   
                        <asp:Label ID="lblprice3" runat="server" CssClass="card-text"></asp:Label>
                  <br />
                   
                        <asp:Label ID="lbldescription3" runat="server" CssClass="card-text"></asp:Label>
                    <br />
                    
                </div>

            </div>

        </div></asp:Label>

                     <asp:Label ID="lblFourth" runat="server" >
        <div class='col-4 m-4'>
            <div class='card' style='width: 18rem;box-shadow:0px 0px 10px grey;'>
                <asp:Image ID="image7" runat="server" style="width:100%;padding-left:7px;text-align:center;padding-top:7px;padding-right:7px;" />
                <div class='card-body'>
                    
                    <h5 class='card-title'>
                        <asp:Label ID="lblfoodname4" runat="server" CssClass="card-text"></asp:Label>
                     </h5>
           
                   
                        <asp:Label ID="lblprice4" runat="server" CssClass="card-text"></asp:Label>
                   <br />
                    
                       <asp:Label ID="lbldescription4" runat="server" CssClass="card-text"></asp:Label>
                   <br />
                    
                </div>

            </div>

        </div></asp:Label>
                </asp:Label>


      <asp:Label ID="lblSecond2" runat="server"  CssClass="d-flex mt-5" >
            <asp:Label ID="lblSecondFirst" runat="server" >
        <div class='col-4 m-4'>
            <div class='card' style='width: 18rem;box-shadow:0px 0px 10px grey;'>
                <asp:Image ID="lblSecondFirstImage" runat="server" />
                <div class='card-body'>
                   
                    <h5 class='card-title'>
                        <asp:Label ID="lblSecondFirstFoodname" runat="server" CssClass="card-text"></asp:Label>
                     </h5>
           
                   
                        <asp:Label ID="lblSecondFirstPrice" runat="server" CssClass="card-text"></asp:Label>
                   <br />
                        
                  
                       <asp:Label ID="lblSecondFirstDescription" runat="server" CssClass="card-text"></asp:Label>
                   <br /><br />
                        
                    
                   <%-- <asp:Button ID="btnex" runat="server" Text="ex" CausesValidation="False" EnableViewState="False" OnClicK="btnex_Click"/>--%>

                </div>
                
            </div>

        </div></asp:Label>
            <%--<asp:Label ID="Label1" runat="server" Text="Label">
             </asp:Label>

            <asp:Label ID="lblview1" runat="server" Text="view" Visible="False"></asp:Label>--%>

                     <asp:Label ID="lblSecondSecond" runat="server" >
        <div class='col-4 m-4'>
            <div class='card' style='width: 18rem;box-shadow:0px 0px 10px grey'>
                <asp:Image ID="lblSecondSecondImage" runat="server" />
                <div class='card-body'>
                    
                    <h5 class='card-title'>
                        <asp:Label ID="lblSecondSecondFoodname" runat="server" CssClass="card-text"></asp:Label>
                     </h5>
           
                    
                        <asp:Label ID="lblSecondSecondPrice" runat="server" CssClass="card-text"></asp:Label>
                    <br />
                        
                    
                       <asp:Label ID="lblSecondSecondDescription" runat="server" CssClass="card-text"></asp:Label>
                    <br /><br />
                   
                </div>

            </div>

        </div></asp:Label>

                  
                     <asp:Label ID="lblSecondThird" runat="server" >
        <div class='col-4 m-4'>
            <div class='card' style='width: 18rem;box-shadow:0px 0px 10px grey'>
                <asp:Image ID="lblSecondThirdImage" runat="server" />
                <div class='card-body'>
                    
                    <h5 class='card-title'>
                        <asp:Label ID="lblSecondThirdFoodname" runat="server" CssClass="card-text"></asp:Label>
                     </h5>
           
                   
                        <asp:Label ID="lblSecondThirdPrice" runat="server" CssClass="card-text"></asp:Label>
                  <br />
                       
                  
                        <asp:Label ID="lblSecondThirdDescription" runat="server" CssClass="card-text"></asp:Label> 
                    <br /><br />
                    
                </div>

            </div>

        </div></asp:Label>

                     
                </asp:Label>
            </div>
            </div>
    
</asp:Content>
