using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace foodservice
{
    public partial class AddToCart : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["const"].ConnectionString);

        static int i = 1;
        static int pp;
        static int p;

        static int isecond = 1;
        static int ppsecond;
        static int psecond;

        static int ithird = 1;
        static int ppthird;
        static int pthird;

        static int ifourth = 1;
        static int ppfourth;
        static int pfourth;

        static int ififth = 1;
        static int ppfifth;
        static int pfifth;

        static int isixth = 1;
        static int ppsixth;
        static int psixth;

        static int iseventh = 1;
        static int ppseventh;
        static int pseventh;

        static int ieighth = 1;
        static int ppeighth;
        static int peighth;

        static int ininth = 1;
        static int ppninth;
        static int pninth;

        static int itenth = 1;
        static int pptenth;
        static int ptenth;

        string cart1shopname;
        string cart2shopname;
        string cart3shopname;
        string cart4shopname;
        string cart5shopname;
        string cart6shopname;
        string cart7shopname;
        string cart8shopname;
        string cart9shopname;
        string cart10shopname;
        protected void Page_Load(object sender, EventArgs e)
        {

            



            //Label4.Text = Session["shopnamea"].ToString();
            //Label5.Text = Session["shopnameb"].ToString();
            //Label6.Text = Session["shopnamec"].ToString();
            //Label7.Text = Session["shopnamed"].ToString();
            //Label8.Text = Session["shopnamee"].ToString();
            //Label9.Text = Session["shopnamef"].ToString();
            //Label10.Text = Session["shopnameg"].ToString();
            //Label11.Text = Session["shopnameh"].ToString();
            //Label12.Text = Session["shopnamei"].ToString();
            //Label13.Text = Session["shopnamej"].ToString();
            conn.Open();

            SqlCommand yes = new SqlCommand("select * from userNotiTable where Receive='Yes' and Email='" + Session["email"] + "'", conn);
            SqlDataReader yesdr = yes.ExecuteReader();
            if (yesdr.Read())
            {
                lblyes.Visible = true;
                lblyes.Text = yesdr["message"].ToString();
            }
            yesdr.Close();

            SqlCommand no = new SqlCommand("select * from userNotiTable where Receive='No' and Email='" + Session["email"] + "'", conn);
            SqlDataReader nodr = no.ExecuteReader();
            if (nodr.Read())
            {
                lblno.Visible = true;
                lblno.Text = nodr["message"].ToString();
            }
            nodr.Close();

            


            SqlCommand amd = new SqlCommand("select count(Id) from CartTable where Email='" + Session["email"] + "'", conn);
            int count = (int)amd.ExecuteScalar();
            Session["cartcount"] = count.ToString();


            //No1
            SqlCommand cmd = new SqlCommand("select * from CartTable where Id='"+13+"' and Email='"+Session["email"]+"'",conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                

                p = Convert.ToInt32(rdr["Price"]);
                pp = p * i;
                Cart1Image.ImageUrl = rdr["image"].ToString();
                Cart1Name.Text = rdr["Foodname"].ToString();
                Cart1Price.Text = pp.ToString();
                Cart1Total.Text = i.ToString();
                cart1shopname = rdr["Shopname"].ToString();
                rdr.Close();

                
            }

            else
            {
                Cart1.Visible = false;
                rdr.Close();
            }

            //No2

            SqlCommand cmdsecond = new SqlCommand("select * from CartTable where Id='" + 14 + "' and Email='" + Session["email"] + "'", conn);
            SqlDataReader rdrsecond = cmdsecond.ExecuteReader();
            if (rdrsecond.Read())
            {
               
                psecond = Convert.ToInt32(rdrsecond["Price"]);
                ppsecond = psecond * isecond;
                Cart2Image.ImageUrl = rdrsecond["image"].ToString();
                Cart2Name.Text = rdrsecond["Foodname"].ToString();
                Cart2Price.Text = ppsecond.ToString();
                Cart2Total.Text = isecond.ToString();
                cart2shopname = rdrsecond["Shopname"].ToString();
                rdrsecond.Close();

                //SqlCommand yes = new SqlCommand("select * from userNotiTable where Receive='Yes' and Email='" + Session["email"] + "'", conn);
                //SqlDataReader yesdr = yes.ExecuteReader();
                //if (yesdr.Read())
                //{
                //    Label1.Visible = true;
                //    Label1.Text = yesdr["message"].ToString();
                //}
                //yesdr.Close();

                //SqlCommand no = new SqlCommand("select * from userNotiTable where Receive='No' and Email='" + Session["email"] + "'", conn);
                //SqlDataReader nodr = no.ExecuteReader();
                //if (nodr.Read())
                //{
                //    Label8.Visible = true;
                //    Label8.Text = nodr["message"].ToString();
                //}
                //nodr.Close();

            }

            else
            {
                Cart2.Visible = false;
                rdrsecond.Close();
            }

            //N03
                SqlCommand cmdthird = new SqlCommand("select * from CartTable where Id='" + 15 + "' and Email='" + Session["email"] + "'", conn);
                SqlDataReader rdrthird = cmdthird.ExecuteReader();
            if (rdrthird.Read())
            {
                

                pthird = Convert.ToInt32(rdrthird["Price"]);
                ppthird = pthird * ithird;
                Cart3Image.ImageUrl = rdrthird["image"].ToString();
                Cart3Name.Text = rdrthird["Foodname"].ToString();
                Cart3Price.Text = ppthird.ToString();
                Cart3Total.Text = ithird.ToString();
                cart3shopname = rdrthird["Shopname"].ToString();
                rdrthird.Close();

                //SqlCommand yes = new SqlCommand("select * from userNotiTable where Receive='Yes' and Email='" + Session["email"] + "'", conn);
                //SqlDataReader yesdr = yes.ExecuteReader();
                //if (yesdr.Read())
                //{
                //    Label4.Visible = true;
                //    Label4.Text = yesdr["message"].ToString();
                //}
                //yesdr.Close();

                //SqlCommand no = new SqlCommand("select * from userNotiTable where Receive='No' and Email='" + Session["email"] + "'", conn);
                //SqlDataReader nodr = no.ExecuteReader();
                //if (nodr.Read())
                //{
                //    Label9.Visible = true;
                //    Label9.Text = nodr["message"].ToString();
                //}
                //nodr.Close();
            }



            else
            {
                Cart3.Visible = false;
                rdrthird.Close();
            }



            //N04
            SqlCommand cmdfourth = new SqlCommand("select * from CartTable where Id='" + 16 + "' and Email='" + Session["email"] + "'", conn);
            SqlDataReader rdrfourth = cmdfourth.ExecuteReader();
            if (rdrfourth.Read())
            {
                
                pfourth = Convert.ToInt32(rdrfourth["Price"]);
                ppfourth = pfourth * ifourth;
                Cart4Image.ImageUrl = rdrfourth["image"].ToString();
                Cart4Name.Text = rdrfourth["Foodname"].ToString();
                Cart4Price.Text = ppfourth.ToString();
                Cart4Total.Text = ifourth.ToString();
                cart4shopname = rdrfourth["Shopname"].ToString();
                rdrfourth.Close();

                //SqlCommand yes = new SqlCommand("select * from userNotiTable where Receive='Yes' and Email='" + Session["email"] + "'", conn);
                //SqlDataReader yesdr = yes.ExecuteReader();
                //if (yesdr.Read())
                //{
                //    Label5.Visible = true;
                //    Label5.Text = yesdr["message"].ToString();
                //}
                //yesdr.Close();

                //SqlCommand no = new SqlCommand("select * from userNotiTable where Receive='No' and Email='" + Session["email"] + "'", conn);
                //SqlDataReader nodr = no.ExecuteReader();
                //if (nodr.Read())
                //{
                //    Label10.Visible = true;
                //    Label10.Text = nodr["message"].ToString();
                //}
                //nodr.Close();
            }



            else
            {
                Cart4.Visible = false;
                rdrfourth.Close();
            }

            //No5
            SqlCommand cmdfifth = new SqlCommand("select * from CartTable where Id='" + 17 + "' and Email='" + Session["email"] + "'", conn);
            SqlDataReader rdrfifth = cmdfifth.ExecuteReader();
            if (rdrfifth.Read())
            {
                
                pfifth = Convert.ToInt32(rdrfifth["Price"]);
                ppfifth = pfifth * ififth;
                Cart5Image.ImageUrl = rdrfifth["image"].ToString();
                Cart5Name.Text = rdrfifth["Foodname"].ToString();
                Cart5Price.Text = ppfifth.ToString();
                Cart5Total.Text = ififth.ToString();
                cart5shopname = rdrfifth["Shopname"].ToString();
                rdrfifth.Close();

                //SqlCommand yes = new SqlCommand("select * from userNotiTable where Receive='Yes' and Email='" + Session["email"] + "'", conn);
                //SqlDataReader yesdr = yes.ExecuteReader();
                //if (yesdr.Read())
                //{
                //    Label6.Visible = true;
                //    Label6.Text = yesdr["message"].ToString();
                //}
                //yesdr.Close();

                //SqlCommand no = new SqlCommand("select * from userNotiTable where Receive='No' and Email='" + Session["email"] + "'", conn);
                //SqlDataReader nodr = no.ExecuteReader();
                //if (nodr.Read())
                //{
                //    Label11.Visible = true;
                //    Label11.Text = nodr["message"].ToString();
                //}
                //nodr.Close();
            }



            else
            {
                Cart5.Visible = false;
                rdrfifth.Close();
            }

            //No6
            SqlCommand cmdsixth = new SqlCommand("select * from CartTable where Id='" + 18 + "' and Email='" + Session["email"] + "'", conn);
            SqlDataReader rdrsixth = cmdsixth.ExecuteReader();
            if (rdrsixth.Read())
            {
               
                psixth = Convert.ToInt32(rdrsixth["Price"]);
                ppsixth = psixth * isixth;
                Cart6Image.ImageUrl = rdrsixth["image"].ToString();
                Cart6Name.Text = rdrsixth["Foodname"].ToString();
                Cart6Price.Text = ppsixth.ToString();
                Cart6Total.Text = isixth.ToString();
                cart6shopname = rdrsixth["Shopname"].ToString();
                rdrsixth.Close();

                //SqlCommand yes = new SqlCommand("select * from userNotiTable where Receive='Yes' and Email='" + Session["email"] + "'", conn);
                //SqlDataReader yesdr = yes.ExecuteReader();
                //if (yesdr.Read())
                //{
                //    Label7.Visible = true;
                //    Label7.Text = yesdr["message"].ToString();
                //}
                //yesdr.Close();

                //SqlCommand no = new SqlCommand("select * from userNotiTable where Receive='No' and Email='" + Session["email"] + "'", conn);
                //SqlDataReader nodr = no.ExecuteReader();
                //if (nodr.Read())
                //{
                //    Label12.Visible = true;
                //    Label12.Text = nodr["message"].ToString();
                //}
                //nodr.Close();
            }



            else
            {
                Cart6.Visible = false;
                rdrsixth.Close();
            }


            //No7
            SqlCommand cmdseventh = new SqlCommand("select * from CartTable where Id='" + 19 + "' and Email='" + Session["email"] + "'", conn);
            SqlDataReader rdrseventh = cmdseventh.ExecuteReader();
            if (rdrseventh.Read())
            {
                

                pseventh = Convert.ToInt32(rdrseventh["Price"]);
                ppseventh = pseventh * iseventh;
                Cart7Image.ImageUrl = rdrseventh["image"].ToString();
                Cart7Name.Text = rdrseventh["Foodname"].ToString();
                Cart7Price.Text = ppseventh.ToString();
                Cart7Total.Text = iseventh.ToString();
                cart7shopname = rdrseventh["Shopname"].ToString();
                rdrseventh.Close();

                //SqlCommand yes = new SqlCommand("select * from userNotiTable where Receive='Yes' and Email='" + Session["email"] + "'", conn);
                //SqlDataReader yesdr = yes.ExecuteReader();
                //if (yesdr.Read())
                //{
                //    Label13.Visible = true;
                //    Label13.Text = yesdr["message"].ToString();
                //}
                //yesdr.Close();

                //SqlCommand no = new SqlCommand("select * from userNotiTable where Receive='No' and Email='" + Session["email"] + "'", conn);
                //SqlDataReader nodr = no.ExecuteReader();
                //if (nodr.Read())
                //{
                //    Label14.Visible = true;
                //    Label14.Text = nodr["message"].ToString();
                //}
                //nodr.Close();

            }



            else
            {
                Cart7.Visible = false;
                rdrseventh.Close();
            }

            //No8
            SqlCommand cmdeighth = new SqlCommand("select * from CartTable where Id='" + 20 + "' and Email='" + Session["email"] + "'", conn);
            SqlDataReader rdreighth = cmdeighth.ExecuteReader();
            if (rdreighth.Read())
            {
                

                peighth = Convert.ToInt32(rdreighth["Price"]);
                ppeighth = peighth * ieighth;
                Cart8Image.ImageUrl = rdreighth["image"].ToString();
                Cart8Name.Text = rdreighth["Foodname"].ToString();
                Cart8Price.Text = ppeighth.ToString();
                Cart8Total.Text = ieighth.ToString();
                cart8shopname = rdreighth["Shopname"].ToString();
                rdreighth.Close();

                //SqlCommand yes = new SqlCommand("select * from userNotiTable where Receive='Yes' and Email='" + Session["email"] + "'", conn);
                //SqlDataReader yesdr = yes.ExecuteReader();
                //if (yesdr.Read())
                //{
                //    Label15.Visible = true;
                //    Label15.Text = yesdr["message"].ToString();
                //}
                //yesdr.Close();

                //SqlCommand no = new SqlCommand("select * from userNotiTable where Receive='No' and Email='" + Session["email"] + "'", conn);
                //SqlDataReader nodr = no.ExecuteReader();
                //if (nodr.Read())
                //{
                //    Label16.Visible = true;
                //    Label16.Text = nodr["message"].ToString();
                //}
                //nodr.Close();
            }



            else
            {
                Cart8.Visible = false;
                rdreighth.Close();
            }


            //No9
            SqlCommand cmdninth = new SqlCommand("select * from CartTable where Id='" + 21 + "' and Email='" + Session["email"] + "'", conn);
            SqlDataReader rdrninth = cmdninth.ExecuteReader();
            if (rdrninth.Read())
            {
                

                pninth = Convert.ToInt32(rdrninth["Price"]);
                ppninth = pninth * ininth;
                Cart9Image.ImageUrl = rdrninth["image"].ToString();
                Cart9Name.Text = rdrninth["Foodname"].ToString();
                Cart9Price.Text = ppninth.ToString();
                Cart9Total.Text = ininth.ToString();
                cart9shopname = rdrninth["Shopname"].ToString();
                rdrninth.Close();

                //SqlCommand yes = new SqlCommand("select * from userNotiTable where Receive='Yes' and Email='" + Session["email"] + "'", conn);
                //SqlDataReader yesdr = yes.ExecuteReader();
                //if (yesdr.Read())
                //{
                //    Label17.Visible = true;
                //    Label17.Text = yesdr["message"].ToString();
                //}
                //yesdr.Close();

                //SqlCommand no = new SqlCommand("select * from userNotiTable where Receive='No' and Email='" + Session["email"] + "'", conn);
                //SqlDataReader nodr = no.ExecuteReader();
                //if (nodr.Read())
                //{
                //    Label18.Visible = true;
                //    Label18.Text = nodr["message"].ToString();
                //}
                //nodr.Close();
            }



            else
            {
                Cart9.Visible = false;
                rdrninth.Close();
            }


            //No10
            SqlCommand cmdtenth = new SqlCommand("select * from CartTable where Id='" + 22 + "' and Email='" + Session["email"] + "'", conn);
            SqlDataReader rdrtenth = cmdtenth.ExecuteReader();
            if (rdrtenth.Read())
            {
                

                ptenth = Convert.ToInt32(rdrtenth["Price"]);
                pptenth = pthird * ithird;
                Cart10Image.ImageUrl = rdrtenth["image"].ToString();
                Cart10Name.Text = rdrtenth["Foodname"].ToString();
                Cart10Price.Text = pptenth.ToString();
                Cart10Total.Text = itenth.ToString();
                cart10shopname = rdrtenth["Shopname"].ToString();
                rdrtenth.Close();

                //SqlCommand yes = new SqlCommand("select * from userNotiTable where Receive='Yes' and Email='" + Session["email"] + "'", conn);
                //SqlDataReader yesdr = yes.ExecuteReader();
                //if (yesdr.Read())
                //{
                //    Label19.Visible = true;
                //    Label19.Text = yesdr["message"].ToString();
                //}
                //yesdr.Close();

                //SqlCommand no = new SqlCommand("select * from userNotiTable where Receive='No' and Email='" + Session["email"] + "'", conn);
                //SqlDataReader nodr = no.ExecuteReader();
                //if (nodr.Read())
                //{
                //    Label20.Visible = true;
                //    Label20.Text = nodr["message"].ToString();
                //}
                //nodr.Close();
            }



            else
            {
                Cart10.Visible = false;
                rdrtenth.Close();
            }

            //No10

            //string total11 = Cart1Total.Text;
            //int total1 = Convert.ToInt32(total11);

            //string total22 = Cart2Total.Text;
            //int total2 = Convert.ToInt32(total22);

            //string total33 = Cart3Total.Text;
            //int total3 = Convert.ToInt32(total33);

            //string total44 = Cart4Total.Text;
            //int total4 = Convert.ToInt32(total44);

            //string total55 = Cart5Total.Text;
            //int total5 = Convert.ToInt32(total55);

            //string total66 = Cart6Total.Text;
            //int total6 = Convert.ToInt32(total66);

            //string total77 = Cart7Total.Text;
            //int total7 = Convert.ToInt32(total77);

            //string total88 = Cart8Total.Text;
            //int total8 = Convert.ToInt32(total88);

            //string total99 = Cart9Total.Text;
            //int total9 = Convert.ToInt32(total99);

            //string total100 = Cart10Total.Text;
            //int total10 = Convert.ToInt32(total100);

            //int tt = total1 + total2 + total3 + total4 + total5 + total6 + total7 + total8 + total9 + total10;
            //lblTo.Text = tt.ToString();
            conn.Close();
        }

        //No1

        protected void Cart1Minus_Click(object sender, EventArgs e)
        {
            i=i-1;
            
            Cart1Total.Text = i.ToString();
            pp = p * i;
            Cart1Price.Text = pp.ToString();
           
            
        }
        protected void Cart1Plus_Click(object sender, EventArgs e)
        {
            i=i+1;
            
            Cart1Total.Text = i.ToString();
            pp = p * i;
            Cart1Price.Text = pp.ToString();
            
        }

        //No2
        protected void Cart2Minus_Click(object sender, EventArgs e)
        {
            isecond = isecond - 1;

            Cart2Total.Text = isecond.ToString();
            ppsecond = psecond * isecond;
            Cart2Price.Text = ppsecond.ToString();


        }
        protected void Cart2Plus_Click(object sender, EventArgs e)
        {
            isecond = isecond + 1;

            Cart2Total.Text = isecond.ToString();
            ppsecond = psecond * isecond;
            Cart2Price.Text = ppsecond.ToString();

        }

        //No3
        protected void Cart3Minus_Click(object sender, EventArgs e)
        {
            ithird = ithird - 1;

            Cart3Total.Text = ithird.ToString();
            ppthird = pthird * ithird;
            Cart3Price.Text = ppthird.ToString();


        }
        protected void Cart3Plus_Click(object sender, EventArgs e)
        {
            ithird = ithird + 1;

            Cart3Total.Text = ithird.ToString();
            ppthird = pthird * ithird;
            Cart3Price.Text = ppthird.ToString();

        }


        //No4
        protected void Cart4Minus_Click(object sender, EventArgs e)
        {
            ifourth = ifourth - 1;

            Cart4Total.Text = ifourth.ToString();
            ppfourth = pfourth * ifourth;
            Cart4Price.Text = ppfourth.ToString();


        }
        protected void Cart4Plus_Click(object sender, EventArgs e)
        {
            ifourth = ifourth + 1;

            Cart4Total.Text = ifourth.ToString();
            ppfourth = pfourth * ifourth;
            Cart4Price.Text = ppfourth.ToString();

        }


        //No5
        protected void Cart5Minus_Click(object sender, EventArgs e)
        {
            ififth = ififth - 1;

            Cart5Total.Text = ififth.ToString();
            ppfifth = pfifth * ififth;
            Cart5Price.Text = ppfifth.ToString();


        }
        protected void Cart5Plus_Click(object sender, EventArgs e)
        {
            ififth = ififth + 1;

            Cart5Total.Text = ififth.ToString();
            ppfifth = pfifth * ififth;
            Cart5Price.Text = ppfifth.ToString();

        }


        //No6
        protected void Cart6Minus_Click(object sender, EventArgs e)
        {
            isixth = isixth - 1;

            Cart6Total.Text = isixth.ToString();
            ppsixth = psixth * isixth;
            Cart6Price.Text = ppsixth.ToString();


        }
        protected void Cart6Plus_Click(object sender, EventArgs e)
        {
            isixth = isixth + 1;

            Cart6Total.Text = isixth.ToString();
            ppsixth = psixth * isixth;
            Cart6Price.Text = ppsixth.ToString();

        }


        //No7
        protected void Cart7Minus_Click(object sender, EventArgs e)
        {
            iseventh = iseventh - 1;

            Cart7Total.Text = iseventh.ToString();
            ppseventh = pseventh * iseventh;
            Cart7Price.Text = ppseventh.ToString();


        }
        protected void Cart7Plus_Click(object sender, EventArgs e)
        {
            iseventh = iseventh + 1;

            Cart7Total.Text = iseventh.ToString();
            ppseventh = pseventh * iseventh;
            Cart7Price.Text = ppseventh.ToString();

        }


        //No8
        protected void Cart8Minus_Click(object sender, EventArgs e)
        {
            ieighth = ieighth - 1;

            Cart8Total.Text = ieighth.ToString();
            ppeighth = peighth * ieighth;
            Cart8Price.Text = ppeighth.ToString();


        }
        protected void Cart8Plus_Click(object sender, EventArgs e)
        {
            ieighth = ieighth + 1;

            Cart8Total.Text = ieighth.ToString();
            ppeighth = peighth * ieighth;
            Cart8Price.Text = ppeighth.ToString();

        }


        //No9
        protected void Cart9Minus_Click(object sender, EventArgs e)
        {
            ininth = ininth - 1;

            Cart9Total.Text = ininth.ToString();
            ppninth = pninth * ininth;
            Cart9Price.Text = ppninth.ToString();


        }
        protected void Cart9Plus_Click(object sender, EventArgs e)
        {
            ininth = ininth + 1;

            Cart9Total.Text = ininth.ToString();
            ppninth = pninth * ininth;
            Cart9Price.Text = ppninth.ToString();

        }


        //No10
        protected void Cart10Minus_Click(object sender, EventArgs e)
        {
            itenth = itenth - 1;

            Cart10Total.Text = itenth.ToString();
            pptenth = ptenth * itenth;
            Cart10Price.Text = pptenth.ToString();


        }
        protected void Cart10Plus_Click(object sender, EventArgs e)
        {
            itenth = itenth + 1;

            Cart10Total.Text = itenth.ToString();
            pptenth = ptenth * itenth;
            Cart10Price.Text = pptenth.ToString();

        }

        protected void UserOrder_Click(object sender, EventArgs e)

        {
            conn.Open();
          
            string d1 = DateTime.Now.ToShortDateString();
            string t1 = DateTime.Now.ToLongTimeString();

            //no1
            if (Cart1.Visible == true)
            {
                int qty1 = Convert.ToInt32(Cart1Total.Text);
                int totalPrice1 = Convert.ToInt32(Cart1Price.Text);
                SqlCommand cmd = new SqlCommand("insert into orderTempTable(email,FoodName,Qty,Total,Shopname,Location,PhNumber,Date,Time,Receive) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)",conn);
                cmd.Parameters.AddWithValue("@a1",Session["email"].ToString());
                cmd.Parameters.AddWithValue("@a2",Cart1Name.Text);
                cmd.Parameters.AddWithValue("@a3",qty1);
                cmd.Parameters.AddWithValue("@a4",totalPrice1);
                cmd.Parameters.AddWithValue("@a5", cart1shopname);
                cmd.Parameters.AddWithValue("@a6", Location.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@a7", ph.Text);
                cmd.Parameters.AddWithValue("@a8", d1);
                cmd.Parameters.AddWithValue("@a9", t1);
                cmd.Parameters.AddWithValue("@a10", "No");
                cmd.ExecuteNonQuery();


                SqlCommand amd = new SqlCommand("insert into ShopkeeperrequestTable(userEmail,FoodName,Qty,TotalPrice,Shopname,ULocation,UPhNumber,Date,Time,Receive) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)", conn);
                amd.Parameters.AddWithValue("@a1", Session["email"].ToString());
                amd.Parameters.AddWithValue("@a2", Cart1Name.Text);
                amd.Parameters.AddWithValue("@a3", qty1);
                amd.Parameters.AddWithValue("@a4", totalPrice1);
                amd.Parameters.AddWithValue("@a5", cart1shopname);
                amd.Parameters.AddWithValue("@a6", Location.SelectedItem.ToString());
                amd.Parameters.AddWithValue("@a7", ph.Text);
                amd.Parameters.AddWithValue("@a8", d1);
                amd.Parameters.AddWithValue("@a9", t1);
                amd.Parameters.AddWithValue("@a10", "No");
                amd.ExecuteNonQuery();
                
            }

            //no2 
            if (Cart2.Visible == true)
            {
                int qty2 = Convert.ToInt32(Cart2Total.Text);
                int totalPrice2 = Convert.ToInt32(Cart2Price.Text);
                SqlCommand cmd2 = new SqlCommand("insert into orderTempTable(email,FoodName,Qty,Total,Shopname,Location,PhNumber,Date,Time,Receive) values(@b1,@b2,@b3,@b4,@b5,@b6,@b7,@b8,@b9,@b10)", conn);
                cmd2.Parameters.AddWithValue("@b1", Session["email"].ToString());
                cmd2.Parameters.AddWithValue("@b2", Cart2Name.Text);
                cmd2.Parameters.AddWithValue("@b3", qty2);
                cmd2.Parameters.AddWithValue("@b4", totalPrice2);
                cmd2.Parameters.AddWithValue("@b5", cart2shopname);
                cmd2.Parameters.AddWithValue("@b6", Location.SelectedItem.ToString());
                cmd2.Parameters.AddWithValue("@b7", ph.Text);
                cmd2.Parameters.AddWithValue("@b8", d1);
                cmd2.Parameters.AddWithValue("@b9", t1);
                cmd2.Parameters.AddWithValue("@b10", "No");
                cmd2.ExecuteNonQuery();

                SqlCommand amd = new SqlCommand("insert into ShopkeeperrequestTable(userEmail,FoodName,Qty,TotalPrice,Shopname,ULocation,UPhNumber,Date,Time,Receive) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)", conn);
                amd.Parameters.AddWithValue("@a1", Session["email"].ToString());
                amd.Parameters.AddWithValue("@a2", Cart2Name.Text);
                amd.Parameters.AddWithValue("@a3", qty2);
                amd.Parameters.AddWithValue("@a4", totalPrice2);
                amd.Parameters.AddWithValue("@a5", cart2shopname);
                amd.Parameters.AddWithValue("@a6", Location.SelectedItem.ToString());
                amd.Parameters.AddWithValue("@a7", ph.Text);
                amd.Parameters.AddWithValue("@a8", d1);
                amd.Parameters.AddWithValue("@a9", t1);
                amd.Parameters.AddWithValue("@a10", "No");
                amd.ExecuteNonQuery();
                
            }

            //no3
            if (Cart3.Visible == true)
            {
                int qty3 = Convert.ToInt32(Cart3Total.Text);
                int totalPrice3 = Convert.ToInt32(Cart3Price.Text);
                SqlCommand cmd3 = new SqlCommand("insert into orderTempTable(email,FoodName,Qty,Total,Shopname,Location,PhNumber,Date,Time,Receive) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)", conn);
                cmd3.Parameters.AddWithValue("@a1", Session["email"].ToString());
                cmd3.Parameters.AddWithValue("@a2", Cart3Name.Text);
                cmd3.Parameters.AddWithValue("@a3", qty3);
                cmd3.Parameters.AddWithValue("@a4", totalPrice3);
                cmd3.Parameters.AddWithValue("@a5", cart3shopname);
                cmd3.Parameters.AddWithValue("@a6", Location.SelectedItem.ToString());
                cmd3.Parameters.AddWithValue("@a7", ph.Text);
                cmd3.Parameters.AddWithValue("@a8", d1);
                cmd3.Parameters.AddWithValue("@a9", t1);
                cmd3.Parameters.AddWithValue("@a10", "No");


                cmd3.ExecuteNonQuery();

                SqlCommand amd = new SqlCommand("insert into ShopkeeperrequestTable(userEmail,FoodName,Qty,TotalPrice,Shopname,ULocation,UPhNumber,Date,Time,Receive) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)", conn);
                amd.Parameters.AddWithValue("@a1", Session["email"].ToString());
                amd.Parameters.AddWithValue("@a2", Cart3Name.Text);
                amd.Parameters.AddWithValue("@a3", qty3);
                amd.Parameters.AddWithValue("@a4", totalPrice3);
                amd.Parameters.AddWithValue("@a5", cart3shopname);
                amd.Parameters.AddWithValue("@a6", Location.SelectedItem.ToString());
                amd.Parameters.AddWithValue("@a7", ph.Text);
                amd.Parameters.AddWithValue("@a8", d1);
                amd.Parameters.AddWithValue("@a9", t1);
                amd.Parameters.AddWithValue("@a10", "No");
                amd.ExecuteNonQuery();
                
            }

            ////no4
            if (Cart4.Visible == true)
            {
                int qty4 = Convert.ToInt32(Cart4Total.Text);
                int totalPrice4 = Convert.ToInt32(Cart4Price.Text);
                SqlCommand cmd4 = new SqlCommand("insert into orderTempTable(email,FoodName,Qty,Total,Shopname,Location,PhNumber,Date,Time,Receive) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)", conn);
                cmd4.Parameters.AddWithValue("@a1", Session["email"].ToString());
                cmd4.Parameters.AddWithValue("@a2", Cart4Name.Text);
                cmd4.Parameters.AddWithValue("@a3", qty4);
                cmd4.Parameters.AddWithValue("@a4", totalPrice4);
                cmd4.Parameters.AddWithValue("@a5", cart4shopname);
                cmd4.Parameters.AddWithValue("@a6", Location.SelectedItem.ToString());
                cmd4.Parameters.AddWithValue("@a7", ph.Text);
                cmd4.Parameters.AddWithValue("@a8", d1);
                cmd4.Parameters.AddWithValue("@a9", t1);
                cmd4.Parameters.AddWithValue("@a10", "No");
                cmd4.ExecuteNonQuery();

                SqlCommand amd = new SqlCommand("insert into ShopkeeperrequestTable(userEmail,FoodName,Qty,TotalPrice,Shopname,ULocation,UPhNumber,Date,Time,Receive) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)", conn);
                amd.Parameters.AddWithValue("@a1", Session["email"].ToString());
                amd.Parameters.AddWithValue("@a2", Cart4Name.Text);
                amd.Parameters.AddWithValue("@a3", qty4);
                amd.Parameters.AddWithValue("@a4", totalPrice4);
                amd.Parameters.AddWithValue("@a5", cart4shopname);
                amd.Parameters.AddWithValue("@a6", Location.SelectedItem.ToString());
                amd.Parameters.AddWithValue("@a7", ph.Text);
                amd.Parameters.AddWithValue("@a8", d1);
                amd.Parameters.AddWithValue("@a9", t1);
                amd.Parameters.AddWithValue("@a10", "No");
                amd.ExecuteNonQuery();
                
            }


            ////no5
            if (Cart5.Visible == true)
            {
                int qty5 = Convert.ToInt32(Cart5Total.Text);
                int totalPrice5 = Convert.ToInt32(Cart5Price.Text);
                SqlCommand cmd5 = new SqlCommand("insert into orderTempTable(email,FoodName,Qty,Total,Shopname,Location,PhNumber,Date,Time,Receive) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)", conn);
                cmd5.Parameters.AddWithValue("@a1", Session["email"].ToString());
                cmd5.Parameters.AddWithValue("@a2", Cart5Name.Text);
                cmd5.Parameters.AddWithValue("@a3", qty5);
                cmd5.Parameters.AddWithValue("@a4", totalPrice5);
                cmd5.Parameters.AddWithValue("@a5", cart5shopname);
                cmd5.Parameters.AddWithValue("@a6", Location.SelectedItem.ToString());
                cmd5.Parameters.AddWithValue("@a7", ph.Text);
                cmd5.Parameters.AddWithValue("@a8", d1);
                cmd5.Parameters.AddWithValue("@a9", t1);
                cmd5.Parameters.AddWithValue("@a10", "No");
                cmd5.ExecuteNonQuery();

                SqlCommand amd = new SqlCommand("insert into ShopkeeperrequestTable(userEmail,FoodName,Qty,TotalPrice,Shopname,ULocation,UPhNumber,Date,Time,Receive) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)", conn);
                amd.Parameters.AddWithValue("@a1", Session["email"].ToString());
                amd.Parameters.AddWithValue("@a2", Cart5Name.Text);
                amd.Parameters.AddWithValue("@a3", qty5);
                amd.Parameters.AddWithValue("@a4", totalPrice5);
                amd.Parameters.AddWithValue("@a5", cart5shopname);
                amd.Parameters.AddWithValue("@a6", Location.SelectedItem.ToString());
                amd.Parameters.AddWithValue("@a7", ph.Text);
                amd.Parameters.AddWithValue("@a8", d1);
                amd.Parameters.AddWithValue("@a9", t1);
                amd.Parameters.AddWithValue("@a10", "No");
                amd.ExecuteNonQuery();
               
            }

            ////no6
            if (Cart6.Visible == true)
            {
                int qty6 = Convert.ToInt32(Cart6Total.Text);
                int totalPrice6 = Convert.ToInt32(Cart6Price.Text);
                SqlCommand cmd6 = new SqlCommand("insert into orderTempTable(email,FoodName,Qty,Total,Shopname,Location,PhNumber,Date,Time,Receive) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)", conn);
                cmd6.Parameters.AddWithValue("@a1", Session["email"].ToString());
                cmd6.Parameters.AddWithValue("@a2", Cart6Name.Text);
                cmd6.Parameters.AddWithValue("@a3", qty6);
                cmd6.Parameters.AddWithValue("@a4", totalPrice6);
                cmd6.Parameters.AddWithValue("@a5", cart6shopname);
                cmd6.Parameters.AddWithValue("@a6", Location.SelectedItem.ToString());
                cmd6.Parameters.AddWithValue("@a7", ph.Text);
                cmd6.Parameters.AddWithValue("@a8", d1);
                cmd6.Parameters.AddWithValue("@a9", t1);
                cmd6.Parameters.AddWithValue("@a10", "No");
                cmd6.ExecuteNonQuery();

                SqlCommand amd = new SqlCommand("insert into ShopkeeperrequestTable(userEmail,FoodName,Qty,TotalPrice,Shopname,ULocation,UPhNumber,Date,Time,Receive) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)", conn);
                amd.Parameters.AddWithValue("@a1", Session["email"].ToString());
                amd.Parameters.AddWithValue("@a2", Cart6Name.Text);
                amd.Parameters.AddWithValue("@a3", qty6);
                amd.Parameters.AddWithValue("@a4", totalPrice6);
                amd.Parameters.AddWithValue("@a5", cart6shopname);
                amd.Parameters.AddWithValue("@a6", Location.SelectedItem.ToString());
                amd.Parameters.AddWithValue("@a7", ph.Text);
                amd.Parameters.AddWithValue("@a8", d1);
                amd.Parameters.AddWithValue("@a9", t1);
                amd.Parameters.AddWithValue("@a10", "No");
                amd.ExecuteNonQuery();
               
            }


            //no7
            if (Cart7.Visible == true)
            {
                int qty7 = Convert.ToInt32(Cart7Total.Text);
                int totalPrice7 = Convert.ToInt32(Cart7Price.Text);
                SqlCommand cmd7 = new SqlCommand("insert into orderTempTable(email,FoodName,Qty,Total,Shopname,Location,PhNumber,Date,Time,Receive) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)", conn);
                cmd7.Parameters.AddWithValue("@a1", Session["email"].ToString());
                cmd7.Parameters.AddWithValue("@a2", Cart7Name.Text);
                cmd7.Parameters.AddWithValue("@a3", qty7);
                cmd7.Parameters.AddWithValue("@a4", totalPrice7);
                cmd7.Parameters.AddWithValue("@a5", cart7shopname);
                cmd7.Parameters.AddWithValue("@a6", Location.SelectedItem.ToString());
                cmd7.Parameters.AddWithValue("@a7", ph.Text);
                cmd7.Parameters.AddWithValue("@a8", d1);
                cmd7.Parameters.AddWithValue("@a9", t1);
                cmd7.Parameters.AddWithValue("@a10", "No");
                cmd7.ExecuteNonQuery();

                SqlCommand amd = new SqlCommand("insert into ShopkeeperrequestTable(userEmail,FoodName,Qty,TotalPrice,Shopname,ULocation,UPhNumber,Date,Time,Receive) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)", conn);
                amd.Parameters.AddWithValue("@a1", Session["email"].ToString());
                amd.Parameters.AddWithValue("@a2", Cart7Name.Text);
                amd.Parameters.AddWithValue("@a3", qty7);
                amd.Parameters.AddWithValue("@a4", totalPrice7);
                amd.Parameters.AddWithValue("@a5", cart7shopname);
                amd.Parameters.AddWithValue("@a6", Location.SelectedItem.ToString());
                amd.Parameters.AddWithValue("@a7", ph.Text);
                amd.Parameters.AddWithValue("@a8", d1);
                amd.Parameters.AddWithValue("@a9", t1);
                amd.Parameters.AddWithValue("@a10", "No");
                amd.ExecuteNonQuery();
                
            }

            


            //no8
            if (Cart8.Visible == true)
            {
                int qty8 = Convert.ToInt32(Cart8Total.Text);
                int totalPrice8 = Convert.ToInt32(Cart8Price.Text);
                SqlCommand cmd8 = new SqlCommand("insert into orderTempTable(email,FoodName,Qty,Total,Shopname,Location,PhNumber,Date,Time,Receive) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)", conn);
                cmd8.Parameters.AddWithValue("@a1", Session["email"].ToString());
                cmd8.Parameters.AddWithValue("@a2", Cart8Name.Text);
                cmd8.Parameters.AddWithValue("@a3", qty8);
                cmd8.Parameters.AddWithValue("@a4", totalPrice8);
                cmd8.Parameters.AddWithValue("@a5", cart8shopname);
                cmd8.Parameters.AddWithValue("@a6", Location.SelectedItem.ToString());
                cmd8.Parameters.AddWithValue("@a7", ph.Text);
                cmd8.Parameters.AddWithValue("@a8", d1);
                cmd8.Parameters.AddWithValue("@a9", t1);
                cmd8.Parameters.AddWithValue("@a10", "No");
                cmd8.ExecuteNonQuery();


                SqlCommand amd = new SqlCommand("insert into ShopkeeperrequestTable(userEmail,FoodName,Qty,TotalPrice,Shopname,ULocation,UPhNumber,Date,Time,Receive) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)", conn);
                amd.Parameters.AddWithValue("@a1", Session["email"].ToString());
                amd.Parameters.AddWithValue("@a2", Cart8Name.Text);
                amd.Parameters.AddWithValue("@a3", qty8);
                amd.Parameters.AddWithValue("@a4", totalPrice8);
                amd.Parameters.AddWithValue("@a5", cart8shopname);
                amd.Parameters.AddWithValue("@a6", Location.SelectedItem.ToString());
                amd.Parameters.AddWithValue("@a7", ph.Text);
                amd.Parameters.AddWithValue("@a8", d1);
                amd.Parameters.AddWithValue("@a9", t1);
                amd.Parameters.AddWithValue("@a10", "No");
                amd.ExecuteNonQuery();
                
            }
           
            ////no9
            if (Cart9.Visible == true)
            {
                int qty9 = Convert.ToInt32(Cart9Total.Text);
                int totalPrice9 = Convert.ToInt32(Cart9Price.Text);
                SqlCommand cmd9 = new SqlCommand("insert into orderTempTable(email,FoodName,Qty,Total,Shopname,Location,PhNumber,Date,Time,Receive) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)", conn);
                cmd9.Parameters.AddWithValue("@a1", Session["email"].ToString());
                cmd9.Parameters.AddWithValue("@a2", Cart9Name.Text);
                cmd9.Parameters.AddWithValue("@a3", qty9);
                cmd9.Parameters.AddWithValue("@a4", totalPrice9);
                cmd9.Parameters.AddWithValue("@a5", cart9shopname);
                cmd9.Parameters.AddWithValue("@a6", Location.SelectedItem.ToString());
                cmd9.Parameters.AddWithValue("@a7", ph.Text);
                cmd9.Parameters.AddWithValue("@a8", d1);
                cmd9.Parameters.AddWithValue("@a9", t1);
                cmd9.Parameters.AddWithValue("@a10", "No");
                cmd9.ExecuteNonQuery();

                SqlCommand amd = new SqlCommand("insert into ShopkeeperrequestTable(userEmail,FoodName,Qty,TotalPrice,Shopname,ULocation,UPhNumber,Date,Time,Receive) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)", conn);
                amd.Parameters.AddWithValue("@a1", Session["email"].ToString());
                amd.Parameters.AddWithValue("@a2", Cart9Name.Text);
                amd.Parameters.AddWithValue("@a3", qty9);
                amd.Parameters.AddWithValue("@a4", totalPrice9);
                amd.Parameters.AddWithValue("@a5", cart9shopname);
                amd.Parameters.AddWithValue("@a6", Location.SelectedItem.ToString());
                amd.Parameters.AddWithValue("@a7", ph.Text);
                amd.Parameters.AddWithValue("@a8", d1);
                amd.Parameters.AddWithValue("@a9", t1);
                amd.Parameters.AddWithValue("@a10", "No");
                amd.ExecuteNonQuery();
                
            }


            ////no10
            if (Cart10.Visible == true)
            {
                int qty10 = Convert.ToInt32(Cart10Total.Text);
                int totalPrice10 = Convert.ToInt32(Cart10Price.Text);
                SqlCommand cmd10 = new SqlCommand("insert into orderTempTable(email,FoodName,Qty,Total,Shopname,Location,PhNumber,Date,Time,Receive) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)", conn);
                cmd10.Parameters.AddWithValue("@a1", Session["email"].ToString());
                cmd10.Parameters.AddWithValue("@a2", Cart10Name.Text);
                cmd10.Parameters.AddWithValue("@a3", qty10);
                cmd10.Parameters.AddWithValue("@a4", totalPrice10);
                cmd10.Parameters.AddWithValue("@a5", cart10shopname);
                cmd10.Parameters.AddWithValue("@a6", Location.SelectedItem.ToString());
                cmd10.Parameters.AddWithValue("@a7", ph.Text);
                cmd10.Parameters.AddWithValue("@a8", d1);
                cmd10.Parameters.AddWithValue("@a9", t1);
                cmd10.Parameters.AddWithValue("@a10", "No");
                cmd10.ExecuteNonQuery();

                SqlCommand amd = new SqlCommand("insert into ShopkeeperrequestTable(userEmail,FoodName,Qty,TotalPrice,Shopname,ULocation,UPhNumber,Date,Time,Receive) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)", conn);
                amd.Parameters.AddWithValue("@a1", Session["email"].ToString());
                amd.Parameters.AddWithValue("@a2", Cart10Name.Text);
                amd.Parameters.AddWithValue("@a3", qty10);
                amd.Parameters.AddWithValue("@a4", totalPrice10);
                amd.Parameters.AddWithValue("@a5", cart10shopname);
                amd.Parameters.AddWithValue("@a6", Location.SelectedItem.ToString());
                amd.Parameters.AddWithValue("@a7", ph.Text);
                amd.Parameters.AddWithValue("@a8", d1);
                amd.Parameters.AddWithValue("@a9", t1);
                amd.Parameters.AddWithValue("@a10", "No");
                amd.ExecuteNonQuery();
               
            }


           




            conn.Close();
        }

    }
}