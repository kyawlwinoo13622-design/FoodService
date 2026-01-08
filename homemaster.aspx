 <%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homemaster.aspx.cs" Inherits="foodservice.homemaster" %>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
     <style type="text/css">
         .auto-style1 {
             width: 308px;
         }
         .auto-style2 {
             width: 102px;
         }
         .auto-style3 {
             width: 69px;
         }
     </style>
 </asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    
   
    <div class="container" style="margin-bottom:80px;margin-top:200px">
        <center>
         <div class="row">
              

             <div class="col-2"  style="margin-left:20px;">
                
                 <asp:ImageButton ID="btnkorea" runat="server" style="border-radius:30%;;margin-bottom:0px;width:130px;height:100px" ImageUrl="~/korea.jpg" CausesValidation="False" EnableViewState="False" OnClick="btnkorean_Click" />
                  <br /><asp:Label ID="lblkorean" runat="server" Text="ကိုရီးယားအစားအစာများ" style="margin-top:0px;font-family:'Monotype Corsiva';font-size:large;" Font-Bold="True"></asp:Label>

                    
             </div>

             <div class="col-2" style="margin-left:80px;">
                
                 <asp:ImageButton ID="btnshan" runat="server" style="border-radius:30%;;margin-bottom:0px;width:130px;height:100px" ImageUrl="~/37.jpg" CausesValidation="False" EnableViewState="False" OnClick="btnshan_Click" />
                  <br /><asp:Label ID="chanfood" runat="server" Text="ရှမ်းအစားအစာများ" style="margin-top:0px;font-family:'Monotype Corsiva';font-size:large;" Font-Bold="True"></asp:Label>

                    
             </div>

             <div class="col-2" style="margin-left:80px;">
                
                 <asp:ImageButton ID="btnthai" runat="server" style="border-radius:30%;;margin-bottom:0px;width:130px;height:100px" ImageUrl="~/thai.jpg" CausesValidation="False" EnableViewState="False" OnClick="btnthai_Click" />
                  <br /><asp:Label ID="Label4" runat="server" Text="ထိုင်းအစားအစာများ" style="margin-top:0px;font-family:'Monotype Corsiva';font-size:large;" Font-Bold="True"></asp:Label>

                    
             </div>

             <div class="col-2" style="margin-left:80px;">
                
                 <asp:ImageButton ID="btnjuice" runat="server" style="border-radius:30%;;margin-bottom:0px;width:130px;height:100px" ImageUrl="~/kiwi1.jpg" CausesValidation="False" EnableViewState="False" OnClick="btnjuice_Click" />
                  <br /><asp:Label ID="Label5" runat="server" Text="ဖျော်ရည်" style="margin-top:0px;font-family:'Monotype Corsiva';font-size:large;" Font-Bold="True"></asp:Label>

                    
             </div>

             <div class="col-2" style="margin-left:80px;">
                
                 <asp:ImageButton ID="btnsalad" runat="server" style="border-radius:30%;;margin-bottom:0px;width:130px;height:100px" ImageUrl="~/33.jpg" CausesValidation="False" EnableViewState="False" OnClick="btnsalad_Click" />
                  <br /><asp:Label ID="Label6" runat="server" Text="အသုပ်အမျိုးမျိုး" style="margin-top:0px;font-family:'Monotype Corsiva';font-size:large;" Font-Bold="True"></asp:Label>

                    
             </div>

             <div class="col-2" style="margin-left:80px;">
                
                 <asp:ImageButton ID="btnother" runat="server" style="border-radius:30%;margin-bottom:0px;width:130px;height:100px" ImageUrl="~/31.jpg"  CausesValidation="False" EnableViewState="False" OnClick="btnother_Click" />
                  <br /><asp:Label ID="Label3" runat="server" Text="အခြား" style="margin-top:0px;font-family:'Monotype Corsiva';font-size:large;" Font-Bold="True"></asp:Label>

                    
             </div>


         </div>
            </center>
        </div>
  
     
   <%-- Page load paw tar--%>
    <div class="container mt-5" style="margin-top:400px;">
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
                     <asp:Label ID="lblshopname1" runat="server" CssClass="card-text"></asp:Label>
                       
               <br />
                     <asp:Label ID="lbldescription1" runat="server" CssClass="card-text"></asp:Label>
                       
                   <br /><br />
                        <asp:Button ID="btnview1" runat="server" Text="More" CssClass="card-text sbutton" EnableViewState="False" CausesValidation="False" OnClicK="btnview1_Click" /> 
                 
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
                    <asp:Label ID="lblshopname2" runat="server" CssClass="card-text"></asp:Label>
                       
                    <br />
                         <asp:Label ID="lbldescription2" runat="server" CssClass="card-text"></asp:Label>
                    <br /><br />
                         <asp:Button ID="btnview2" runat="server" CssClass="card-text sbutton" OnClick="btnview2_Click" Text="More" EnableViewState="False" CausesValidation="False" />
                    
                </div>

            </div>

        </div></asp:Label>

                  
                     <asp:Label ID="lblThird" runat="server" >
        <div class='col-4 m-4'>
            <div class='card' style='width: 18rem;box-shadow:0px 0px 10px grey;'>
                <asp:Image ID="image5" runat="server" />
                <div class='card-body'>
                     
                    <h5 class='card-title'>
                        <asp:Label ID="lblfoodname3" runat="server" CssClass="card-text"></asp:Label>
                     </h5>
           
                   
                        <asp:Label ID="lblprice3" runat="server" CssClass="card-text"></asp:Label>
                  <br />
                    <asp:Label ID="lblshopname3" runat="server" CssClass="card-text"></asp:Label>
                        
                    <br />
                        <asp:Label ID="lbldescription3" runat="server" CssClass="card-text"></asp:Label>
                    <br /><br />
                         <asp:Button ID="btnview3" runat="server" CssClass="card-text sbutton" OnClick="btnview3_Click" Text="More" EnableViewState="False" CausesValidation="False" />
                    
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
                     <asp:Label ID="lblshopname4" runat="server" CssClass="card-text"></asp:Label>
                        
                  <br />
                       <asp:Label ID="lbldescription4" runat="server" CssClass="card-text"></asp:Label>
                   <br /><br />
                         <asp:Button ID="btnview4" runat="server" CssClass="card-text sbutton" Text="More" EnableViewState="False" CausesValidation="False" OnClick="btnview4_Click"/>
                    
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
                     <asp:Label ID="lblSecondFirstShopname" runat="server" CssClass="card-text"></asp:Label>
                        
                   <br />
                       <asp:Label ID="lblSecondFirstDescription" runat="server" CssClass="card-text"></asp:Label>
                   <br /><br />
                        <asp:Button ID="btnview5" runat="server" CssClass="card-text sbutton" Text="More" EnableViewState="False" CausesValidation="False" OnClicK="btnview5_Click" /> 
                        
                    
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
                     <asp:Label ID="lblSecondSecondShopname" runat="server" CssClass="card-text"></asp:Label>
                        
                    <br />
                       <asp:Label ID="lblSecondSecondDescription" runat="server" CssClass="card-text"></asp:Label>
                    <br /><br />
                         <asp:Button ID="btnview6" runat="server" CssClass="card-text sbutton" OnClick="btnview6_Click" Text="More" EnableViewState="False" CausesValidation="False" />
                   
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
                    <asp:Label ID="lblSecondThirdShopname" runat="server" CssClass="card-text"></asp:Label><br />
                       
                   <br />
                        <asp:Label ID="lblSecondThirdDescription" runat="server" CssClass="card-text"></asp:Label> 
                    <br /><br />
                         <asp:Button ID="btnview7" runat="server" CssClass="card-text sbutton" OnClick="btnview7_Click" Text="More" EnableViewState="False" CausesValidation="False" />
                    
                </div>

            </div>

        </div></asp:Label>

                     
                </asp:Label>

           <%-- အပေါ်မှာဆိူင်နာမည်ပြတာ--%>
            <asp:Label ID="lblshopshop" runat="server" Visible="False">
            <div class="container">
                <div class="row">
                    <div class="col-2"> <asp:Label ID="Shopname" runat="server" Text="Shopname" Font-Bold="True"> </asp:Label></div>
                    <div class="col-2"><asp:Label ID="lblShopname" runat="server"></asp:Label></div>
                </div>
                 <div class="row">
                    <div class="col-2"> <asp:Label ID="txtoo" runat="server" Text="Open" Font-Bold="True"> </asp:Label></div>
                    <div class="col-2"><asp:Label ID="lbloo" runat="server"></asp:Label></div>
                </div>
                 <div class="row">
                    <div class="col-2"> <asp:Label ID="txtcc" runat="server" Text="Close" Font-Bold="True"> </asp:Label></div>
                    <div class="col-2"><asp:Label ID="lblcc" runat="server"></asp:Label></div>
                </div>
                 <div class="row">
                    <div class="col-2"> <asp:Label ID="txtphone" runat="server" Text="Phonenumber" Font-Bold="True"> </asp:Label></div>
                    <div class="col-2"><asp:Label ID="lblphone" runat="server"></asp:Label></div>
                </div>
                 <div class="row">
                    <div class="col-2"> <asp:Label ID="txtaddress" runat="server" Text="Address" Font-Bold="True"> </asp:Label></div>
                    <div class="col-2"><asp:Label ID="lbladdress" runat="server"></asp:Label></div>
                </div>
            </div>
                </asp:Label>
                    <%-- အပေါ်မှာဆိူင်နာမည်ပြတာ--%>
                     
                
             
    <asp:Label ID="Label2" runat="server" CssClass="d-flex mt-5" Visible="false">

                    <asp:Label ID="lblbtnview1" runat="server" Text="view1" >
        <div class="col-4 m-4">
                 <div class="card" style='width: 18rem;box-shadow:0px 0px 10px grey'>
                <asp:Image ID="image3" runat="server" />
                <div class="card-body">
                   
                    <h5 class="card-title">
                        <asp:Label ID="lblex1" runat="server"></asp:Label>
                     </h5>
           
                    
                        <asp:Label ID="lblex2" runat="server" CssClass="card-text"></asp:Label>
                    
                    <br />
                        <asp:Label ID="lblex3" runat="server" CssClass="card-text"></asp:Label>
                    
                    <br />
                        <asp:Label ID="lblex4" runat="server" CssClass="card-text"></asp:Label><br />
                    <br /><br />
                  
                         <asp:Button ID="btnaddtocart1" runat="server" CssClass="card-text sbutton" Text="Add To Cart" EnableViewState="False" CausesValidation="False" OnClick="btnaddtocart1_Click"/>
                    
              </div>

            </div>
            </div></asp:Label>

                 
      <asp:Label ID="lblbtnview2" runat="server" Text="view2">
        <div class="col-4 m-4">
                 <div class="card" style='width: 18rem;box-shadow:0px 0px 10px grey'>
                <asp:Image ID="image4" runat="server" />
                <div class='card-body'>
                    
                    <h5 class="card-title">
                        <asp:Label ID="lblee1" runat="server"></asp:Label>
                     </h5>
           
                   
                        <asp:Label ID="lblee2" runat="server" CssClass="card-text"></asp:Label>
                   <br />
                        <asp:Label ID="lblee3" runat="server" CssClass="card-text"></asp:Label>
                    <br />
                        <asp:Label ID="lblee4" runat="server" CssClass="card-text"></asp:Label><br />
                   <br /><br />
                         <asp:Button ID="btnaddtocart2" runat="server" CssClass="card-text sbutton" Text="Add To Cart" EnableViewState="False" CausesValidation="False" OnClick="btnaddtocart2_Click"/>
                    
              </div>

            </div>
            </div></asp:Label>

               

     <asp:Label ID="lblbtnview3" runat="server" Text="view3">
        <div class="col-4 m-4">
                 <div class="card" style='width: 18rem;box-shadow:0px 0px 10px grey'>
                <asp:Image ID="image6" runat="server" />
                <div class="card-body">
                    
                    <h5 class="card-title">
                        <asp:Label ID="lblss1" runat="server"></asp:Label>
                     </h5>
           
                    
                        <asp:Label ID="lblss2" runat="server" CssClass="card-text"></asp:Label>
                    <br />
                        <asp:Label ID="lblss3" runat="server" CssClass="card-text"></asp:Label>
                    <br />
                        <asp:Label ID="lblss4" runat="server" CssClass="card-text"></asp:Label><br />
                    <br /><br />
                         <asp:Button ID="btnaddtocart3" runat="server" CssClass="card-text sbutton" Text="Add To Cart" EnableViewState="False" CausesValidation="False" OnClick="btnaddtocart3_Click"/>
                    
              </div>

            </div>
            </div></asp:Label>

         <asp:Label ID="lblbtnview4" runat="server" Text="view3">
        <div class="col-4 m-4">
                 <div class="card" style='width: 18rem;box-shadow:0px 0px 10px grey'>
                <asp:Image ID="lblbtnview4Image" runat="server" />
                <div class="card-body">
                    
                    <h5 class="card-title">
                        <asp:Label ID="lblbtnview4Foodname" runat="server"></asp:Label>
                     </h5>
           
                    
                        <asp:Label ID="lblbtnview4Price" runat="server" CssClass="card-text"></asp:Label>
                      <br />
                     <asp:Label ID="lblbtnview4Shopname" runat="server" CssClass="card-text"></asp:Label>
                        
                        <br />
                       <asp:Label ID="lblbtnview4Description" runat="server" CssClass="card-text"></asp:Label>
                        <br /><br />
                         <asp:Button ID="btnaddtocart4" runat="server" CssClass="card-text sbutton" Text="Add To Cart" EnableViewState="False" CausesValidation="False" OnClick="btnaddtocart4_Click"/>
                   
              </div>

            </div>
            </div></asp:Label>

       <%-- view5--%>
         <asp:Label ID="lblbtnview5" runat="server" Text="view3">
        <div class="col-4 m-4">
                 <div class="card" style='width: 18rem;box-shadow:0px 0px 10px grey'>
                <asp:Image ID="lblbtnview5Image" runat="server" />
                <div class="card-body">
                    
                    <h5 class="card-title">
                        <asp:Label ID="lblbtnview5Foodname" runat="server"></asp:Label>
                     </h5>
           
                    
                        <asp:Label ID="lblbtnview5Price" runat="server" CssClass="card-text"></asp:Label>
                      <br />
                     <asp:Label ID="lblbtnview5Shopname" runat="server" CssClass="card-text"></asp:Label>
                        
                        <br />
                       <asp:Label ID="lblbtnview5Description" runat="server" CssClass="card-text"></asp:Label>
                        <br /><br />
                         <asp:Button ID="btnaddtocart5" runat="server" CssClass="card-text sbutton" Text="Add To Cart" EnableViewState="False" CausesValidation="False" OnClick="btnaddtocart5_Click"/>
                   
              </div>

            </div>
            </div></asp:Label>
        <%-- view5--%>

        <%-- view6--%>
         <asp:Label ID="lblbtnview6" runat="server" Text="view3">
        <div class="col-4 m-4">
                 <div class="card" style='width: 18rem;box-shadow:0px 0px 10px grey'>
                <asp:Image ID="lblbtnview6Image" runat="server" />
                <div class="card-body">
                    
                    <h5 class="card-title">
                        <asp:Label ID="lblbtnview6Foodname" runat="server"></asp:Label>
                     </h5>
           
                    
                        <asp:Label ID="lblbtnview6Price" runat="server" CssClass="card-text"></asp:Label>
                      <br />
                    <asp:Label ID="lblbtnview6Shopname" runat="server" CssClass="card-text"></asp:Label>
                       
                        <br />
                         <asp:Label ID="lblbtnview6Description" runat="server" CssClass="card-text"></asp:Label>
                        <br /><br />
                         <asp:Button ID="btnaddtocart6" runat="server" CssClass="card-text sbutton" Text="Add To Cart" EnableViewState="False" CausesValidation="False" OnClick="btnaddtocart6_Click"/>
                   
              </div>

            </div>
            </div></asp:Label>
        <%-- view6--%>

        <%-- view7--%>
        <asp:Label ID="lblbtnview7" runat="server" Text="view3">
        <div class="col-4 m-4">
                 <div class="card" style='width: 18rem;box-shadow:0px 0px 10px grey'>
                <asp:Image ID="lblbtnview7Image" runat="server" />
                <div class="card-body">
                    
                    <h5 class="card-title">
                        <asp:Label ID="lblbtnview7Foodname" runat="server"></asp:Label>
                     </h5>
           
                    
                        <asp:Label ID="lblbtnview7Price" runat="server" CssClass="card-text"></asp:Label>
                      <br />
                     <asp:Label ID="lblbtnview7Shopname" runat="server" CssClass="card-text"></asp:Label>
                        
                        <br />
                       <asp:Label ID="lblbtnview7Description" runat="server" CssClass="card-text"></asp:Label>
                        <br /><br />
                         <asp:Button ID="btnaddtocart7" runat="server" CssClass="card-text sbutton" Text="Add To Cart" EnableViewState="False" CausesValidation="False" OnClick="btnaddtocart7_Click"/>
                   
              </div>

            </div>
            </div></asp:Label>
        <%-- view7--%>

        <%-- view8--%>
         <asp:Label ID="lblbtnview8" runat="server" Text="view3">
        <div class="col-4 m-4">
                 <div class="card" style='width: 18rem;box-shadow:0px 0px 10px grey'>
                <asp:Image ID="lblbtnview8Image" runat="server" />
                <div class="card-body">
                   
                    <h5 class="card-title">
                        <asp:Label ID="lblbtnview8Foodname" runat="server"></asp:Label>
                     </h5>
           
                    
                        <asp:Label ID="lblbtnview8Price" runat="server" CssClass="card-text"></asp:Label>
                      <br />
                     <asp:Label ID="lblbtnview8Shopname" runat="server" CssClass="card-text"></asp:Label>
                        
                        <br />
                       <asp:Label ID="lblbtnview8Description" runat="server" CssClass="card-text"></asp:Label>
                        <br /><br />
                         <asp:Button ID="btnaddtocart8" runat="server" CssClass="card-text sbutton" Text="Add To Cart" EnableViewState="False" CausesValidation="False" OnClick="btnaddtocart8_Click"/>
                   
              </div>

            </div>
            </div></asp:Label>
        <%-- view8--%>

        <%-- view9--%>
        <asp:Label ID="lblbtnview9" runat="server" Text="view3">
        <div class="col-4 m-4">
                 <div class="card" style='width: 18rem;box-shadow:0px 0px 10px grey'>
                <asp:Image ID="lblbtnview9Image" runat="server" />
                <div class="card-body">
                    
                    <h5 class="card-title">
                        <asp:Label ID="lblbtnview9Foodname" runat="server"></asp:Label>
                     </h5>
           
                    
                        <asp:Label ID="lblbtnview9Price" runat="server" CssClass="card-text"></asp:Label>
                      <br />
                    <asp:Label ID="lblbtnview9Shopname" runat="server" CssClass="card-text"></asp:Label>
                        
                        <br />
                        <asp:Label ID="lblbtnview9Description" runat="server" CssClass="card-text"></asp:Label>
                        <br /><br />
                         <asp:Button ID="btnaddtocart9" runat="server" CssClass="card-text sbutton" Text="Add To Cart" EnableViewState="False" CausesValidation="False" OnClick="btnaddtocart9_Click"/>
                   
              </div>

            </div>
            </div></asp:Label>
        <%-- view9--%>

        <%-- view10--%>
         <asp:Label ID="lblbtnview10" runat="server" Text="view3">
        <div class="col-4 m-4">
                 <div class="card" style='width: 18rem;box-shadow:0px 0px 10px grey'>
                <asp:Image ID="lblbtnview10Image" runat="server" />
                <div class="card-body">
                   
                    <h5 class="card-title">
                        <asp:Label ID="lblbtnview10Foodname" runat="server"></asp:Label>
                     </h5>
           
                    
                        <asp:Label ID="lblbtnview10Price" runat="server" CssClass="card-text"></asp:Label>
                      <br />
                     <asp:Label ID="lblbtnview10Shopname" runat="server" CssClass="card-text"></asp:Label>
                        
                        <br />
                       <asp:Label ID="lblbtnview10Description" runat="server" CssClass="card-text"></asp:Label>
                        <br /><br />
                         <asp:Button ID="btnaddtocart10" runat="server" CssClass="card-text sbutton" Text="Add To Cart" EnableViewState="False" CausesValidation="False" OnClick="btnaddtocart10_Click"/>
                   
              </div>

            </div>
            </div></asp:Label>
        <%-- view10--%>
       
    </asp:Label>
     
    <%-- Page load paw tar--%>






    </div>
        
            
    </div>



    

   
</asp:Content>


 
