using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Text.RegularExpressions;


namespace foodservice
{
    public partial class homemaster : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["const"].ConnectionString);

        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            

                int i = 1;
                conn.Open();


                SqlCommand cmd = new SqlCommand("select * from allTable where Id='"+ 1 +"'",conn);
                SqlDataReader rdr=cmd.ExecuteReader();
                if (rdr.Read())
                {
                    image1.ImageUrl = rdr["image"].ToString();
                    lblfoodname1.Text = rdr["Foodname"].ToString();
                    lblprice1.Text = rdr["Price"].ToString();
                    lblshopname1.Text = rdr["Shopname"].ToString();
                    lbldescription1.Text = rdr["Description"].ToString();
                    rdr.Close();
                }
                else
                {
                    lblFirst.Visible = false;
                    rdr.Close();
                }

                SqlCommand amd = new SqlCommand("select * from allTable where Id='" + 2 + "'", conn);
                SqlDataReader rd = amd.ExecuteReader();
                if (rd.Read())
                {
                    image2.ImageUrl = rd["image"].ToString();
                    lblfoodname2.Text = rd["Foodname"].ToString();
                    lblprice2.Text = rd["Price"].ToString();
                    lblshopname2.Text = rd["Shopname"].ToString();
                    lbldescription2.Text = rd["Description"].ToString();
                    rd.Close();
                }
                else
                {
                    lblSecond.Visible = false;
                    rd.Close();
                }


                SqlCommand bmd = new SqlCommand("select * from allTable where Id='" + 3 + "'", conn);
                SqlDataReader bd = bmd.ExecuteReader();
                if (bd.Read())
                {
                    image5.ImageUrl = bd["image"].ToString();
                    lblfoodname3.Text = bd["Foodname"].ToString();
                    lblprice3.Text = bd["Price"].ToString();
                    lblshopname3.Text = bd["Shopname"].ToString();
                    lbldescription3.Text = bd["Description"].ToString();
                    bd.Close();
                }
                else
                {
                    lblThird.Visible = false;
                    bd.Close();
                }

                SqlCommand dmd = new SqlCommand("select * from allTable where Id='" + 4 + "'", conn);
                SqlDataReader dd = dmd.ExecuteReader();
                if (dd.Read())
                {
                    image7.ImageUrl = dd["image"].ToString();
                    lblfoodname4.Text = dd["Foodname"].ToString();
                    lblprice4.Text = dd["Price"].ToString();
                    lblshopname4.Text = dd["Shopname"].ToString();
                    lbldescription4.Text = dd["Description"].ToString();
                    dd.Close();
                }
                else
                {
                    lblFourth.Visible = false;
                    dd.Close();
                }


                SqlCommand fifth = new SqlCommand("select * from allTable where Id='" + 5 + "'", conn);
                SqlDataReader fifthrdr = fifth.ExecuteReader();
                if (fifthrdr.Read())
                {
                    lblSecondFirstImage.ImageUrl = fifthrdr["image"].ToString();
                    lblSecondFirstFoodname.Text = fifthrdr["Foodname"].ToString();
                    lblSecondFirstPrice.Text = fifthrdr["Price"].ToString();
                    lblSecondFirstShopname.Text = fifthrdr["Shopname"].ToString();
                    lblSecondFirstDescription.Text = fifthrdr["Description"].ToString();
                    fifthrdr.Close();
                }
                else
                {
                    lblSecondFirst.Visible = false;
                    fifthrdr.Close();
                }


                SqlCommand sixth = new SqlCommand("select * from allTable where Id='" + 6 + "'", conn);
                SqlDataReader sixthrdr = sixth.ExecuteReader();
                if (sixthrdr.Read())
                {
                    lblSecondSecondImage.ImageUrl = sixthrdr["image"].ToString();
                    lblSecondSecondFoodname.Text = sixthrdr["Foodname"].ToString();
                    lblSecondSecondPrice.Text = sixthrdr["Price"].ToString();
                    lblSecondSecondShopname.Text = sixthrdr["Shopname"].ToString();
                    lblSecondSecondDescription.Text = sixthrdr["Description"].ToString();
                    sixthrdr.Close();
                }
                else
                {
                    lblSecondSecond.Visible = false;
                    sixthrdr.Close();
                }



                SqlCommand seventh = new SqlCommand("select * from allTable where Id='" + 7 + "'", conn);
                SqlDataReader seventhrdr = seventh.ExecuteReader();
                if (seventhrdr.Read())
                {
                    lblSecondThirdImage.ImageUrl = seventhrdr["image"].ToString();
                    lblSecondThirdFoodname.Text = seventhrdr["Foodname"].ToString();
                    lblSecondThirdPrice.Text = seventhrdr["Price"].ToString();
                    lblSecondThirdShopname.Text = seventhrdr["Shopname"].ToString();
                    lblSecondThirdDescription.Text = seventhrdr["Description"].ToString();
                    seventhrdr.Close();
                }
                else
                {
                    lblSecondThird.Visible = false;
                    seventhrdr.Close();
                }

                conn.Close();
            
    
                ////SqlCommand amd = new SqlCommand("select count(Id) from ShTable", conn);
                ////int count = (int)amd.ExecuteScalar();

                //Label2.Text = count.ToString();

                //SqlCommand cmd = new SqlCommand("select * from ShTable", conn);
                //SqlDataReader rdr = cmd.ExecuteReader();
                //while (rdr.Read())
                //{

                //    string id = rdr["Id"].ToString();
                //    int j = Convert.ToInt32(id);
                //    string foodname = rdr["FoodName"].ToString();
                //    if (j == 5)
                //    {


                //        image1.ImageUrl = rdr["image"].ToString();
                //        lblfoodname1.Text = rdr["Foodname"].ToString();
                //        lblprice1.Text = rdr["Price"].ToString();
                //        lblshopname1.Text = rdr["Shopname"].ToString();
                //        lbldescription1.Text = rdr["Description"].ToString();


                //    }
                //    //else
                //    //{
                //    //    lblFirst.Visible = false;
                //    //}
                   
                   
                //    //else
                //    //{
                //    //    lblSecond.Visible = false;
                //    //}

                //    if (j == 7)
                //    {
                        
                //        image5.ImageUrl = rdr["image"].ToString();
                //        lblfoodname3.Text = rdr["Foodname"].ToString();
                //        lblprice3.Text = rdr["Price"].ToString();
                //        lblshopname3.Text = rdr["Shopname"].ToString();
                //        lbldescription3.Text = rdr["Description"].ToString();
                //        //lblSecond.Visible = true;

                //    }
                //    //else
                //    //{
                //    //    lblThird.Visible = false;
                //    //}


                //}
                //rdr.Close();


                //string[] b=new string[count];
                ////for (int i = 0; i <= count; i++)
                ////{
                ////    SqlCommand cmd = new SqlCommand("select * from ShTable where Id='" + i + "'", conn);
                ////    SqlDataReader rdr = cmd.ExecuteReader();
                ////    if(rdr.Read()){
                ////        b[i]=rdr["Foodname"].ToString();
                ////    //Label2.Text += b[i].ToString();
                ////    }
                //    rdr.Close();
                //}
                //Response.Write("<script>alert(b[i])</script>");
                //conn.Close();
       
            
        }


        //protected void btnview1_Click(object sender, EventArgs e)
        //{
        ////    lblhi.Visible = true;
        ////    lblhii.Visible = true;
        //    lblview1.Visible = true;
        //}

























        //protected void btnview1_Click(object sender, EventArgs e)
        //{
        //    lblFirst.Visible = false;
        //    lblSecond.Visible = false;
        //    lblThird.Visible = false;
        //    lblFourth.Visible = false;
        //    Label2.Visible = true;
        //    conn.Open();
        //    string view = lblshopname1.Text;
        //    SqlCommand cmd = new SqlCommand("select * from ShTable where Shopname='" + view + "'", conn);
        //    SqlDataReader rdr = cmd.ExecuteReader();
        //    while (rdr.Read())
        //    {
        //        string id = rdr["Id"].ToString();
        //        int j = Convert.ToInt32(id);
        //        if (j == 5)
        //        {
        //            lblbtnview1.Visible = true;
        //            image3.ImageUrl = rdr["image"].ToString();
        //            lblex1.Text = rdr["Foodname"].ToString();
        //            lblex2.Text = rdr["Price"].ToString();
        //            lblex3.Text = rdr["Shopname"].ToString();
        //            lblex4.Text = rdr["Description"].ToString();
        //        }
        //        if (j == 6)
        //        {
        //            lblbtnview2.Visible = true;
        //            image4.ImageUrl = rdr["image"].ToString();
        //            lblee1.Text = rdr["Foodname"].ToString();
        //            lblee2.Text = rdr["Price"].ToString();
        //            lblee3.Text = rdr["Shopname"].ToString();
        //            lblee4.Text = rdr["Description"].ToString();
        //        }

        //        if (j == 7)
        //        {
        //            lblbtnview3.Visible = true;
        //            image6.ImageUrl = rdr["image"].ToString();
        //            lblss1.Text = rdr["Foodname"].ToString();
        //            lblss2.Text = rdr["Price"].ToString();
        //            lblss3.Text = rdr["Shopname"].ToString();
        //            lblss4.Text = rdr["Description"].ToString();
        //        }
        //    }
        //    rdr.Close();
        //    conn.Close();
        //}


        //btnview1
        protected void btnview1_Click(object sender, EventArgs e)
        {
            conn.Open();

            string view = lblshopname1.Text;

            Session["shopname"] = lblshopname1.Text;
            //lblcc.Text = Session["shopname"].ToString();
            lblshopshop.Visible = true;
            SqlCommand d = new SqlCommand("select * from OpenandcloseTable where Shopname= '" + Session["shopname"] + "'", conn);
            //d.Parameters.AddWithValue("@ss1", Session["shopname"].ToString());
            SqlDataReader r = d.ExecuteReader();
            if (r.Read())
            {
                lblShopname.Text = r["Shopname"].ToString();
                lbloo.Text = r["S"].ToString();
                lblcc.Text = r["E"].ToString();
                lblphone.Text = r["PhNumber"].ToString();
                lbladdress.Text = r["Location"].ToString();
            }
            else
            {


            }
            r.Close();











            SqlCommand cmd = new SqlCommand("select * from allTable where Id='" + 2 + "' and Shopname='" + view + "'", conn);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image3.ImageUrl = rdr["image"].ToString();
                lblex1.Text = rdr["Foodname"].ToString();
                lblex2.Text = rdr["Price"].ToString();
                lblex3.Text = rdr["Shopname"].ToString();
                lblex4.Text = rdr["Description"].ToString();
                rdr.Close();
            }
            else
            {
                lblbtnview1.Visible = false;
                rdr.Close();
            }

            SqlCommand amd = new SqlCommand("select * from allTable where Id='" + 4 + "' and Shopname='" + view + "'", conn);
            SqlDataReader rd = amd.ExecuteReader();

            if (rd.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image4.ImageUrl = rd["image"].ToString();
                lblee1.Text = rd["Foodname"].ToString();
                lblee2.Text = rd["Price"].ToString();
                lblee3.Text = rd["Shopname"].ToString();
                lblee4.Text = rd["Description"].ToString();
                rd.Close();
            }
            else
            {
                lblbtnview2.Visible = false;
                rd.Close();
            }

            SqlCommand dmd = new SqlCommand("select * from allTable where Id='" + 7 + "' and Shopname='" + view + "'", conn);
            SqlDataReader dr = dmd.ExecuteReader();

            if (dr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image6.ImageUrl = dr["image"].ToString();
                lblss1.Text = dr["Foodname"].ToString();
                lblss2.Text = dr["Price"].ToString();
                lblss3.Text = dr["Shopname"].ToString();
                lblss4.Text = dr["Description"].ToString();
                dr.Close();
            }
            else
            {
                lblbtnview3.Visible = false;
                dr.Close();
            }

            SqlCommand fourthdmd = new SqlCommand("select * from allTable where Id='" + 14 + "' and Shopname='" + view + "'", conn);
            SqlDataReader fourthdr = fourthdmd.ExecuteReader();

            if (fourthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview4Image.ImageUrl = fourthdr["image"].ToString();
                lblbtnview4Foodname.Text = fourthdr["Foodname"].ToString();
                lblbtnview4Price.Text = fourthdr["Price"].ToString();
                lblbtnview4Description.Text = fourthdr["Description"].ToString();
                lblbtnview4Shopname.Text = fourthdr["Shopname"].ToString();
                fourthdr.Close();
            }
            else
            {
                lblbtnview4.Visible = false;
                fourthdr.Close();
            }

            //view5
            SqlCommand fifthdmd = new SqlCommand("select * from allTable where Id='" + 2015 + "' and Shopname='" + view + "'", conn);
            SqlDataReader fifthdr = fifthdmd.ExecuteReader();

            if (fifthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview5Image.ImageUrl = fifthdr["image"].ToString();
                lblbtnview5Foodname.Text = fifthdr["Foodname"].ToString();
                lblbtnview5Price.Text = fifthdr["Price"].ToString();
                lblbtnview5Description.Text = fifthdr["Description"].ToString();
                lblbtnview5Shopname.Text = fifthdr["Shopname"].ToString();
                fifthdr.Close();
            }
            else
            {
                lblbtnview5.Visible = false;
                fifthdr.Close();
            }
            //view5

            //view6
            SqlCommand sixthdmd = new SqlCommand("select * from allTable where Id='" + 2016 + "' and Shopname='" + view + "'", conn);
            SqlDataReader sixthdr = sixthdmd.ExecuteReader();

            if (sixthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview6Image.ImageUrl = sixthdr["image"].ToString();
                lblbtnview6Foodname.Text = sixthdr["Foodname"].ToString();
                lblbtnview6Price.Text = sixthdr["Price"].ToString();
                lblbtnview6Description.Text = sixthdr["Description"].ToString();
                lblbtnview6Shopname.Text = sixthdr["Shopname"].ToString();
                sixthdr.Close();
            }
            else
            {
                lblbtnview6.Visible = false;
                sixthdr.Close();
            }
            //view6

            //view7
            SqlCommand seventhdmd = new SqlCommand("select * from allTable where Id='" + 2017 + "' and Shopname='" + view + "'", conn);
            SqlDataReader seventhdr = seventhdmd.ExecuteReader();

            if (seventhdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview7Image.ImageUrl = seventhdr["image"].ToString();
                lblbtnview7Foodname.Text = seventhdr["Foodname"].ToString();
                lblbtnview7Price.Text = seventhdr["Price"].ToString();
                lblbtnview7Description.Text = seventhdr["Description"].ToString();
                lblbtnview7Shopname.Text = seventhdr["Shopname"].ToString();
                seventhdr.Close();
            }
            else
            {
                lblbtnview7.Visible = false;
                seventhdr.Close();
            }
            //view7

            //view8
            SqlCommand eighthdmd = new SqlCommand("select * from allTable where Id='" + 2018 + "' and Shopname='" + view + "'", conn);
            SqlDataReader eighthdr = eighthdmd.ExecuteReader();

            if (eighthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview8Image.ImageUrl = eighthdr["image"].ToString();
                lblbtnview8Foodname.Text = eighthdr["Foodname"].ToString();
                lblbtnview8Price.Text = eighthdr["Price"].ToString();
                lblbtnview8Description.Text = eighthdr["Description"].ToString();
                lblbtnview8Shopname.Text = eighthdr["Shopname"].ToString();
                eighthdr.Close();
            }
            else
            {
                lblbtnview8.Visible = false;
                eighthdr.Close();
            }
            //view8

            //view9
            SqlCommand ninthdmd = new SqlCommand("select * from allTable where Id='" + 3 + "' and Shopname='" + view + "'", conn);
            SqlDataReader ninthdr = ninthdmd.ExecuteReader();

            if (ninthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview9Image.ImageUrl = ninthdr["image"].ToString();
                lblbtnview9Foodname.Text = ninthdr["Foodname"].ToString();
                lblbtnview9Price.Text = ninthdr["Price"].ToString();
                lblbtnview9Description.Text = ninthdr["Description"].ToString();
                lblbtnview9Shopname.Text = ninthdr["Shopname"].ToString();
                ninthdr.Close();
            }
            else
            {
                lblbtnview9.Visible = false;
                ninthdr.Close();
            }
            //view9

            //view10
            SqlCommand tenthdmd = new SqlCommand("select * from allTable where Id='" + 2025 + "' and Shopname='" + view + "'", conn);
            SqlDataReader tenthdr = tenthdmd.ExecuteReader();

            if (tenthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview10Image.ImageUrl = tenthdr["image"].ToString();
                lblbtnview10Foodname.Text = tenthdr["Foodname"].ToString();
                lblbtnview10Price.Text = tenthdr["Price"].ToString();
                lblbtnview10Description.Text = tenthdr["Description"].ToString();
                lblbtnview10Shopname.Text = tenthdr["Shopname"].ToString();
                tenthdr.Close();
            }
            else
            {
                lblbtnview10.Visible = false;
                tenthdr.Close();
            }
            //view10

        }

        //btnview2
        protected void btnview2_Click(object sender, EventArgs e)
        {
            conn.Open();

            string view = lblshopname2.Text;

            Session["shopname"] = lblshopname2.Text;
            //lblcc.Text = Session["shopname"].ToString();
            lblshopshop.Visible = true;
            SqlCommand d = new SqlCommand("select * from OpenandcloseTable where Shopname= '" + Session["shopname"] + "'", conn);
            //d.Parameters.AddWithValue("@ss1", Session["shopname"].ToString());
            SqlDataReader r = d.ExecuteReader();
            if (r.Read())
            {
                lblShopname.Text = r["Shopname"].ToString();
                lbloo.Text = r["S"].ToString();
                lblcc.Text = r["E"].ToString();
                lblphone.Text = r["PhNumber"].ToString();
                lbladdress.Text = r["Location"].ToString();
            }
            else
            {


            }
            r.Close();











            SqlCommand cmd = new SqlCommand("select * from allTable where Id='" + 2 + "' and Shopname='" + view + "'", conn);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image3.ImageUrl = rdr["image"].ToString();
                lblex1.Text = rdr["Foodname"].ToString();
                lblex2.Text = rdr["Price"].ToString();
                lblex3.Text = rdr["Shopname"].ToString();
                lblex4.Text = rdr["Description"].ToString();
                rdr.Close();
            }
            else
            {
                lblbtnview1.Visible = false;
                rdr.Close();
            }

            SqlCommand amd = new SqlCommand("select * from allTable where Id='" + 3 + "' and Shopname='" + view + "'", conn);
            SqlDataReader rd = amd.ExecuteReader();

            if (rd.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image4.ImageUrl = rd["image"].ToString();
                lblee1.Text = rd["Foodname"].ToString();
                lblee2.Text = rd["Price"].ToString();
                lblee3.Text = rd["Shopname"].ToString();
                lblee4.Text = rd["Description"].ToString();
                rd.Close();
            }
            else
            {
                lblbtnview2.Visible = false;
                rd.Close();
            }

            SqlCommand dmd = new SqlCommand("select * from allTable where Id='" + 4 + "' and Shopname='" + view + "'", conn);
            SqlDataReader dr = dmd.ExecuteReader();

            if (dr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image6.ImageUrl = dr["image"].ToString();
                lblss1.Text = dr["Foodname"].ToString();
                lblss2.Text = dr["Price"].ToString();
                lblss3.Text = dr["Shopname"].ToString();
                lblss4.Text = dr["Description"].ToString();
                dr.Close();
            }
            else
            {
                lblbtnview3.Visible = false;
                dr.Close();
            }

            SqlCommand fourthdmd = new SqlCommand("select * from allTable where Id='" + 7 + "' and Shopname='" + view + "'", conn);
            SqlDataReader fourthdr = fourthdmd.ExecuteReader();

            if (fourthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview4Image.ImageUrl = fourthdr["image"].ToString();
                lblbtnview4Foodname.Text = fourthdr["Foodname"].ToString();
                lblbtnview4Price.Text = fourthdr["Price"].ToString();
                lblbtnview4Description.Text = fourthdr["Description"].ToString();
                lblbtnview4Shopname.Text = fourthdr["Shopname"].ToString();
                fourthdr.Close();
            }
            else
            {
                lblbtnview4.Visible = false;
                fourthdr.Close();
            }

            //view5
            SqlCommand fifthdmd = new SqlCommand("select * from allTable where Id='" + 14 + "' and Shopname='" + view + "'", conn);
            SqlDataReader fifthdr = fifthdmd.ExecuteReader();

            if (fifthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview5Image.ImageUrl = fifthdr["image"].ToString();
                lblbtnview5Foodname.Text = fifthdr["Foodname"].ToString();
                lblbtnview5Price.Text = fifthdr["Price"].ToString();
                lblbtnview5Description.Text = fifthdr["Description"].ToString();
                lblbtnview5Shopname.Text = fifthdr["Shopname"].ToString();
                fifthdr.Close();
            }
            else
            {
                lblbtnview5.Visible = false;
                fifthdr.Close();
            }
            //view5

            //view6
            SqlCommand sixthdmd = new SqlCommand("select * from allTable where Id='" + 1015 + "' and Shopname='" + view + "'", conn);
            SqlDataReader sixthdr = sixthdmd.ExecuteReader();

            if (sixthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview6Image.ImageUrl = sixthdr["image"].ToString();
                lblbtnview6Foodname.Text = sixthdr["Foodname"].ToString();
                lblbtnview6Price.Text = sixthdr["Price"].ToString();
                lblbtnview6Description.Text = sixthdr["Description"].ToString();
                lblbtnview6Shopname.Text = sixthdr["Shopname"].ToString();
                sixthdr.Close();
            }
            else
            {
                lblbtnview6.Visible = false;
                sixthdr.Close();
            }
            //view6

            //view7
            SqlCommand seventhdmd = new SqlCommand("select * from allTable where Id='" + 1016 + "' and Shopname='" + view + "'", conn);
            SqlDataReader seventhdr = seventhdmd.ExecuteReader();

            if (seventhdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview7Image.ImageUrl = seventhdr["image"].ToString();
                lblbtnview7Foodname.Text = seventhdr["Foodname"].ToString();
                lblbtnview7Price.Text = seventhdr["Price"].ToString();
                lblbtnview7Description.Text = seventhdr["Description"].ToString();
                lblbtnview7Shopname.Text = seventhdr["Shopname"].ToString();
                seventhdr.Close();
            }
            else
            {
                lblbtnview7.Visible = false;
                seventhdr.Close();
            }
            //view7

            //view8
            SqlCommand eighthdmd = new SqlCommand("select * from allTable where Id='" + 1017 + "' and Shopname='" + view + "'", conn);
            SqlDataReader eighthdr = eighthdmd.ExecuteReader();

            if (eighthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview8Image.ImageUrl = eighthdr["image"].ToString();
                lblbtnview8Foodname.Text = eighthdr["Foodname"].ToString();
                lblbtnview8Price.Text = eighthdr["Price"].ToString();
                lblbtnview8Description.Text = eighthdr["Description"].ToString();
                lblbtnview8Shopname.Text = eighthdr["Shopname"].ToString();
                eighthdr.Close();
            }
            else
            {
                lblbtnview8.Visible = false;
                eighthdr.Close();
            }
            //view8

            //view9
            SqlCommand ninthdmd = new SqlCommand("select * from allTable where Id='" + 1018 + "' and Shopname='" + view + "'", conn);
            SqlDataReader ninthdr = ninthdmd.ExecuteReader();

            if (ninthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview9Image.ImageUrl = ninthdr["image"].ToString();
                lblbtnview9Foodname.Text = ninthdr["Foodname"].ToString();
                lblbtnview9Price.Text = ninthdr["Price"].ToString();
                lblbtnview9Description.Text = ninthdr["Description"].ToString();
                lblbtnview9Shopname.Text = ninthdr["Shopname"].ToString();
                ninthdr.Close();
            }
            else
            {
                lblbtnview9.Visible = false;
                ninthdr.Close();
            }
            //view9

            //view10
            SqlCommand tenthdmd = new SqlCommand("select * from allTable where Id='" + 1025 + "' and Shopname='" + view + "'", conn);
            SqlDataReader tenthdr = tenthdmd.ExecuteReader();

            if (tenthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview10Image.ImageUrl = tenthdr["image"].ToString();
                lblbtnview10Foodname.Text = tenthdr["Foodname"].ToString();
                lblbtnview10Price.Text = tenthdr["Price"].ToString();
                lblbtnview10Description.Text = tenthdr["Description"].ToString();
                lblbtnview10Shopname.Text = tenthdr["Shopname"].ToString();
                tenthdr.Close();
            }
            else
            {
                lblbtnview10.Visible = false;
                tenthdr.Close();
            }
            //view10

        }

        //btnview3
        protected void btnview3_Click(object sender, EventArgs e)
        {
            conn.Open();

            string view = lblshopname3.Text;

            Session["shopname"] = lblshopname3.Text;
            //lblcc.Text = Session["shopname"].ToString();
            lblshopshop.Visible = true;
            SqlCommand d = new SqlCommand("select * from OpenandcloseTable where Shopname= '" + Session["shopname"] + "'", conn);
            //d.Parameters.AddWithValue("@ss1", Session["shopname"].ToString());
            SqlDataReader r = d.ExecuteReader();
            if (r.Read())
            {
                lblShopname.Text = r["Shopname"].ToString();
                lbloo.Text = r["S"].ToString();
                lblcc.Text = r["E"].ToString();
                lblphone.Text = r["PhNumber"].ToString();
                lbladdress.Text = r["Location"].ToString();
            }
            else
            {


            }
            r.Close();











            SqlCommand cmd = new SqlCommand("select * from allTable where Id='" + 1 + "' and Shopname='" + view + "'", conn);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image3.ImageUrl = rdr["image"].ToString();
                lblex1.Text = rdr["Foodname"].ToString();
                lblex2.Text = rdr["Price"].ToString();
                lblex3.Text = rdr["Shopname"].ToString();
                lblex4.Text = rdr["Description"].ToString();
                rdr.Close();
            }
            else
            {
                lblbtnview1.Visible = false;
                rdr.Close();
            }

            SqlCommand amd = new SqlCommand("select * from allTable where Id='" + 2 + "' and Shopname='" + view + "'", conn);
            SqlDataReader rd = amd.ExecuteReader();

            if (rd.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image4.ImageUrl = rd["image"].ToString();
                lblee1.Text = rd["Foodname"].ToString();
                lblee2.Text = rd["Price"].ToString();
                lblee3.Text = rd["Shopname"].ToString();
                lblee4.Text = rd["Description"].ToString();
                rd.Close();
            }
            else
            {
                lblbtnview2.Visible = false;
                rd.Close();
            }

            SqlCommand dmd = new SqlCommand("select * from allTable where Id='" + 3 + "' and Shopname='" + view + "'", conn);
            SqlDataReader dr = dmd.ExecuteReader();

            if (dr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image6.ImageUrl = dr["image"].ToString();
                lblss1.Text = dr["Foodname"].ToString();
                lblss2.Text = dr["Price"].ToString();
                lblss3.Text = dr["Shopname"].ToString();
                lblss4.Text = dr["Description"].ToString();
                dr.Close();
            }
            else
            {
                lblbtnview3.Visible = false;
                dr.Close();
            }

            SqlCommand fourthdmd = new SqlCommand("select * from allTable where Id='" + 4 + "' and Shopname='" + view + "'", conn);
            SqlDataReader fourthdr = fourthdmd.ExecuteReader();

            if (fourthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview4Image.ImageUrl = fourthdr["image"].ToString();
                lblbtnview4Foodname.Text = fourthdr["Foodname"].ToString();
                lblbtnview4Price.Text = fourthdr["Price"].ToString();
                lblbtnview4Description.Text = fourthdr["Description"].ToString();
                lblbtnview4Shopname.Text = fourthdr["Shopname"].ToString();
                fourthdr.Close();
            }
            else
            {
                lblbtnview4.Visible = false;
                fourthdr.Close();
            }

            //view5
            SqlCommand fifthdmd = new SqlCommand("select * from allTable where Id='" + 5 + "' and Shopname='" + view + "'", conn);
            SqlDataReader fifthdr = fifthdmd.ExecuteReader();

            if (fifthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview5Image.ImageUrl = fifthdr["image"].ToString();
                lblbtnview5Foodname.Text = fifthdr["Foodname"].ToString();
                lblbtnview5Price.Text = fifthdr["Price"].ToString();
                lblbtnview5Description.Text = fifthdr["Description"].ToString();
                lblbtnview5Shopname.Text = fifthdr["Shopname"].ToString();
                fifthdr.Close();
            }
            else
            {
                lblbtnview5.Visible = false;
                fifthdr.Close();
            }
            //view5

            //view6
            SqlCommand sixthdmd = new SqlCommand("select * from allTable where Id='" + 6 + "' and Shopname='" + view + "'", conn);
            SqlDataReader sixthdr = sixthdmd.ExecuteReader();

            if (sixthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview6Image.ImageUrl = sixthdr["image"].ToString();
                lblbtnview6Foodname.Text = sixthdr["Foodname"].ToString();
                lblbtnview6Price.Text = sixthdr["Price"].ToString();
                lblbtnview6Description.Text = sixthdr["Description"].ToString();
                lblbtnview6Shopname.Text = sixthdr["Shopname"].ToString();
                sixthdr.Close();
            }
            else
            {
                lblbtnview6.Visible = false;
                sixthdr.Close();
            }
            //view6

            //view7
            SqlCommand seventhdmd = new SqlCommand("select * from allTable where Id='" + 7 + "' and Shopname='" + view + "'", conn);
            SqlDataReader seventhdr = seventhdmd.ExecuteReader();

            if (seventhdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview7Image.ImageUrl = seventhdr["image"].ToString();
                lblbtnview7Foodname.Text = seventhdr["Foodname"].ToString();
                lblbtnview7Price.Text = seventhdr["Price"].ToString();
                lblbtnview7Description.Text = seventhdr["Description"].ToString();
                lblbtnview7Shopname.Text = seventhdr["Shopname"].ToString();
                seventhdr.Close();
            }
            else
            {
                lblbtnview7.Visible = false;
                seventhdr.Close();
            }
            //view7

            //view8
            SqlCommand eighthdmd = new SqlCommand("select * from allTable where Id='" + 8 + "' and Shopname='" + view + "'", conn);
            SqlDataReader eighthdr = eighthdmd.ExecuteReader();

            if (eighthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview8Image.ImageUrl = eighthdr["image"].ToString();
                lblbtnview8Foodname.Text = eighthdr["Foodname"].ToString();
                lblbtnview8Price.Text = eighthdr["Price"].ToString();
                lblbtnview8Description.Text = eighthdr["Description"].ToString();
                lblbtnview8Shopname.Text = eighthdr["Shopname"].ToString();
                eighthdr.Close();
            }
            else
            {
                lblbtnview8.Visible = false;
                eighthdr.Close();
            }
            //view8

            //view9
            SqlCommand ninthdmd = new SqlCommand("select * from allTable where Id='" + 9 + "' and Shopname='" + view + "'", conn);
            SqlDataReader ninthdr = ninthdmd.ExecuteReader();

            if (ninthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview9Image.ImageUrl = ninthdr["image"].ToString();
                lblbtnview9Foodname.Text = ninthdr["Foodname"].ToString();
                lblbtnview9Price.Text = ninthdr["Price"].ToString();
                lblbtnview9Description.Text = ninthdr["Description"].ToString();
                lblbtnview9Shopname.Text = ninthdr["Shopname"].ToString();
                ninthdr.Close();
            }
            else
            {
                lblbtnview9.Visible = false;
                ninthdr.Close();
            }
            //view9

            //view10
            SqlCommand tenthdmd = new SqlCommand("select * from allTable where Id='" + 10 + "' and Shopname='" + view + "'", conn);
            SqlDataReader tenthdr = tenthdmd.ExecuteReader();

            if (tenthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview10Image.ImageUrl = tenthdr["image"].ToString();
                lblbtnview10Foodname.Text = tenthdr["Foodname"].ToString();
                lblbtnview10Price.Text = tenthdr["Price"].ToString();
                lblbtnview10Description.Text = tenthdr["Description"].ToString();
                lblbtnview10Shopname.Text = tenthdr["Shopname"].ToString();
                tenthdr.Close();
            }
            else
            {
                lblbtnview10.Visible = false;
                tenthdr.Close();
            }
            //view10

        }
      

        //btnview4
        protected void btnview4_Click(object sender, EventArgs e)
        {
            conn.Open();

            string view = lblshopname4.Text;

            Session["shopname"] = lblshopname4.Text;
            //lblcc.Text = Session["shopname"].ToString();
            lblshopshop.Visible = true;
            SqlCommand d = new SqlCommand("select * from OpenandcloseTable where Shopname= '" + Session["shopname"] + "'", conn);
            //d.Parameters.AddWithValue("@ss1", Session["shopname"].ToString());
            SqlDataReader r = d.ExecuteReader();
            if(r.Read())
            {
                lblShopname.Text=r["Shopname"].ToString();
                lbloo.Text = r["S"].ToString();
                lblcc.Text = r["E"].ToString();
                lblphone.Text = r["PhNumber"].ToString();
                lbladdress.Text = r["Location"].ToString();
            }
            else
            {
               
               
            }
            r.Close();











            SqlCommand cmd = new SqlCommand("select * from allTable where Id='" + 1 + "' and Shopname='" + view + "'", conn);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;
                
                
                image3.ImageUrl = rdr["image"].ToString();
                lblex1.Text = rdr["Foodname"].ToString();
                lblex2.Text = rdr["Price"].ToString();
                lblex3.Text = rdr["Shopname"].ToString();
                lblex4.Text = rdr["Description"].ToString();
                rdr.Close();
            }
            else
            {
                lblbtnview1.Visible = false;
                rdr.Close();
            }

            SqlCommand amd = new SqlCommand("select * from allTable where Id='" + 2 + "' and Shopname='" + view + "'", conn);
            SqlDataReader rd = amd.ExecuteReader();

            if (rd.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;
                
               
                image4.ImageUrl = rd["image"].ToString();
                lblee1.Text = rd["Foodname"].ToString();
                lblee2.Text = rd["Price"].ToString();
                lblee3.Text = rd["Shopname"].ToString();
                lblee4.Text = rd["Description"].ToString();
                rd.Close();
            }
            else
            {
                lblbtnview2.Visible = false;
                rd.Close();
            }

            SqlCommand dmd = new SqlCommand("select * from allTable where Id='" + 3 + "' and Shopname='" + view + "'", conn);
            SqlDataReader dr = dmd.ExecuteReader();

            if (dr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;
               
                
                image6.ImageUrl = dr["image"].ToString();
                lblss1.Text = dr["Foodname"].ToString();
                lblss2.Text = dr["Price"].ToString();
                lblss3.Text = dr["Shopname"].ToString();
                lblss4.Text = dr["Description"].ToString();
                dr.Close();
            }
            else
            {
                lblbtnview3.Visible = false;
                dr.Close();
            }

            SqlCommand fourthdmd = new SqlCommand("select * from allTable where Id='" + 4 + "' and Shopname='" + view + "'", conn);
            SqlDataReader fourthdr = fourthdmd.ExecuteReader();

            if (fourthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;
                
                lblbtnview4Image.ImageUrl = fourthdr["image"].ToString();
                lblbtnview4Foodname.Text = fourthdr["Foodname"].ToString();
                lblbtnview4Price.Text = fourthdr["Price"].ToString();
                lblbtnview4Description.Text = fourthdr["Description"].ToString();
                lblbtnview4Shopname.Text = fourthdr["Shopname"].ToString();
                fourthdr.Close();
            }
            else
            {
                lblbtnview4.Visible = false;
                fourthdr.Close();
            }

            //view5
            SqlCommand fifthdmd = new SqlCommand("select * from allTable where Id='" + 5 + "' and Shopname='" + view + "'", conn);
            SqlDataReader fifthdr = fifthdmd.ExecuteReader();

            if (fifthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview5Image.ImageUrl = fifthdr["image"].ToString();
                lblbtnview5Foodname.Text = fifthdr["Foodname"].ToString();
                lblbtnview5Price.Text = fifthdr["Price"].ToString();
                lblbtnview5Description.Text = fifthdr["Description"].ToString();
                lblbtnview5Shopname.Text = fifthdr["Shopname"].ToString();
                fifthdr.Close();
            }
            else
            {
                lblbtnview5.Visible = false;
                fifthdr.Close();
            }
            //view5

            //view6
            SqlCommand sixthdmd = new SqlCommand("select * from allTable where Id='" + 6 + "' and Shopname='" + view + "'", conn);
            SqlDataReader sixthdr = sixthdmd.ExecuteReader();

            if (sixthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview6Image.ImageUrl = sixthdr["image"].ToString();
                lblbtnview6Foodname.Text = sixthdr["Foodname"].ToString();
                lblbtnview6Price.Text = sixthdr["Price"].ToString();
                lblbtnview6Description.Text =sixthdr["Description"].ToString();
                lblbtnview6Shopname.Text = sixthdr["Shopname"].ToString();
                sixthdr.Close();
            } 
            else
            {
                lblbtnview6.Visible = false;
                sixthdr.Close();
            }
            //view6

            //view7
            SqlCommand seventhdmd = new SqlCommand("select * from allTable where Id='" + 7 + "' and Shopname='" + view + "'", conn);
            SqlDataReader seventhdr = seventhdmd.ExecuteReader();

            if (seventhdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview7Image.ImageUrl = seventhdr["image"].ToString();
                lblbtnview7Foodname.Text = seventhdr["Foodname"].ToString();
                lblbtnview7Price.Text = seventhdr["Price"].ToString();
                lblbtnview7Description.Text = seventhdr["Description"].ToString();
                lblbtnview7Shopname.Text = seventhdr["Shopname"].ToString();
                seventhdr.Close();
            }
            else
            {
                lblbtnview7.Visible = false;
                seventhdr.Close();
            }
            //view7

            //view8
            SqlCommand eighthdmd = new SqlCommand("select * from allTable where Id='" + 8 + "' and Shopname='" + view + "'", conn);
            SqlDataReader eighthdr = eighthdmd.ExecuteReader();

            if (eighthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview8Image.ImageUrl = eighthdr["image"].ToString();
                lblbtnview8Foodname.Text = eighthdr["Foodname"].ToString();
                lblbtnview8Price.Text = eighthdr["Price"].ToString();
                lblbtnview8Description.Text =eighthdr["Description"].ToString();
                lblbtnview8Shopname.Text = eighthdr["Shopname"].ToString();
                eighthdr.Close();
            } 
            else
            {
                lblbtnview8.Visible = false;
                eighthdr.Close();
            }
            //view8

            //view9
            SqlCommand ninthdmd = new SqlCommand("select * from allTable where Id='" + 9 + "' and Shopname='" + view + "'", conn);
            SqlDataReader ninthdr = ninthdmd.ExecuteReader();

            if (ninthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview9Image.ImageUrl = ninthdr["image"].ToString();
                lblbtnview9Foodname.Text = ninthdr["Foodname"].ToString();
                lblbtnview9Price.Text = ninthdr["Price"].ToString();
                lblbtnview9Description.Text = ninthdr["Description"].ToString();
                lblbtnview9Shopname.Text = ninthdr["Shopname"].ToString();
                ninthdr.Close();
            }
            else
            {
                lblbtnview9.Visible = false;
                ninthdr.Close();
            }
            //view9

            //view10
            SqlCommand tenthdmd = new SqlCommand("select * from allTable where Id='" + 10 + "' and Shopname='" + view + "'", conn);
            SqlDataReader tenthdr = tenthdmd.ExecuteReader();

            if (tenthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview10Image.ImageUrl = tenthdr["image"].ToString();
                lblbtnview10Foodname.Text = tenthdr["Foodname"].ToString();
                lblbtnview10Price.Text = tenthdr["Price"].ToString();
                lblbtnview10Description.Text = tenthdr["Description"].ToString();
                lblbtnview10Shopname.Text = tenthdr["Shopname"].ToString();
                tenthdr.Close();
            }
            else
            {
                lblbtnview10.Visible = false;
                tenthdr.Close();
            }
            //view10

        }

        //btnview5
        protected void btnview5_Click(object sender, EventArgs e)
        {
            conn.Open();

            string view = lblSecondFirstShopname.Text;

            Session["shopname"] = lblSecondFirstShopname.Text;
            //lblcc.Text = Session["shopname"].ToString();
            lblshopshop.Visible = true;
            SqlCommand d = new SqlCommand("select * from OpenandcloseTable where Shopname= '" + Session["shopname"] + "'", conn);
            //d.Parameters.AddWithValue("@ss1", Session["shopname"].ToString());
            SqlDataReader r = d.ExecuteReader();
            if (r.Read())
            {
                lblShopname.Text = r["Shopname"].ToString();
                lbloo.Text = r["S"].ToString();
                lblcc.Text = r["E"].ToString();
                lblphone.Text = r["PhNumber"].ToString();
                lbladdress.Text = r["Location"].ToString();
            }
            else
            {


            }
            r.Close();











            SqlCommand cmd = new SqlCommand("select * from allTable where Id='" + 1 + "' and Shopname='" + view + "'", conn);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image3.ImageUrl = rdr["image"].ToString();
                lblex1.Text = rdr["Foodname"].ToString();
                lblex2.Text = rdr["Price"].ToString();
                lblex3.Text = rdr["Shopname"].ToString();
                lblex4.Text = rdr["Description"].ToString();
                rdr.Close();
            }
            else
            {
                lblbtnview1.Visible = false;
                rdr.Close();
            }

            SqlCommand amd = new SqlCommand("select * from allTable where Id='" + 2 + "' and Shopname='" + view + "'", conn);
            SqlDataReader rd = amd.ExecuteReader();

            if (rd.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image4.ImageUrl = rd["image"].ToString();
                lblee1.Text = rd["Foodname"].ToString();
                lblee2.Text = rd["Price"].ToString();
                lblee3.Text = rd["Shopname"].ToString();
                lblee4.Text = rd["Description"].ToString();
                rd.Close();
            }
            else
            {
                lblbtnview2.Visible = false;
                rd.Close();
            }

            SqlCommand dmd = new SqlCommand("select * from allTable where Id='" + 3 + "' and Shopname='" + view + "'", conn);
            SqlDataReader dr = dmd.ExecuteReader();

            if (dr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image6.ImageUrl = dr["image"].ToString();
                lblss1.Text = dr["Foodname"].ToString();
                lblss2.Text = dr["Price"].ToString();
                lblss3.Text = dr["Shopname"].ToString();
                lblss4.Text = dr["Description"].ToString();
                dr.Close();
            }
            else
            {
                lblbtnview3.Visible = false;
                dr.Close();
            }

            SqlCommand fourthdmd = new SqlCommand("select * from allTable where Id='" + 4 + "' and Shopname='" + view + "'", conn);
            SqlDataReader fourthdr = fourthdmd.ExecuteReader();

            if (fourthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview4Image.ImageUrl = fourthdr["image"].ToString();
                lblbtnview4Foodname.Text = fourthdr["Foodname"].ToString();
                lblbtnview4Price.Text = fourthdr["Price"].ToString();
                lblbtnview4Description.Text = fourthdr["Description"].ToString();
                lblbtnview4Shopname.Text = fourthdr["Shopname"].ToString();
                fourthdr.Close();
            }
            else
            {
                lblbtnview4.Visible = false;
                fourthdr.Close();
            }

            //view5
            SqlCommand fifthdmd = new SqlCommand("select * from allTable where Id='" + 5 + "' and Shopname='" + view + "'", conn);
            SqlDataReader fifthdr = fifthdmd.ExecuteReader();

            if (fifthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview5Image.ImageUrl = fifthdr["image"].ToString();
                lblbtnview5Foodname.Text = fifthdr["Foodname"].ToString();
                lblbtnview5Price.Text = fifthdr["Price"].ToString();
                lblbtnview5Description.Text = fifthdr["Description"].ToString();
                lblbtnview5Shopname.Text = fifthdr["Shopname"].ToString();
                fifthdr.Close();
            }
            else
            {
                lblbtnview5.Visible = false;
                fifthdr.Close();
            }
            //view5

            //view6
            SqlCommand sixthdmd = new SqlCommand("select * from allTable where Id='" + 6 + "' and Shopname='" + view + "'", conn);
            SqlDataReader sixthdr = sixthdmd.ExecuteReader();

            if (sixthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview6Image.ImageUrl = sixthdr["image"].ToString();
                lblbtnview6Foodname.Text = sixthdr["Foodname"].ToString();
                lblbtnview6Price.Text = sixthdr["Price"].ToString();
                lblbtnview6Description.Text = sixthdr["Description"].ToString();
                lblbtnview6Shopname.Text = sixthdr["Shopname"].ToString();
                sixthdr.Close();
            }
            else
            {
                lblbtnview6.Visible = false;
                sixthdr.Close();
            }
            //view6

            //view7
            SqlCommand seventhdmd = new SqlCommand("select * from allTable where Id='" + 7 + "' and Shopname='" + view + "'", conn);
            SqlDataReader seventhdr = seventhdmd.ExecuteReader();

            if (seventhdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview7Image.ImageUrl = seventhdr["image"].ToString();
                lblbtnview7Foodname.Text = seventhdr["Foodname"].ToString();
                lblbtnview7Price.Text = seventhdr["Price"].ToString();
                lblbtnview7Description.Text = seventhdr["Description"].ToString();
                lblbtnview7Shopname.Text = seventhdr["Shopname"].ToString();
                seventhdr.Close();
            }
            else
            {
                lblbtnview7.Visible = false;
                seventhdr.Close();
            }
            //view7

            //view8
            SqlCommand eighthdmd = new SqlCommand("select * from allTable where Id='" + 8 + "' and Shopname='" + view + "'", conn);
            SqlDataReader eighthdr = eighthdmd.ExecuteReader();

            if (eighthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview8Image.ImageUrl = eighthdr["image"].ToString();
                lblbtnview8Foodname.Text = eighthdr["Foodname"].ToString();
                lblbtnview8Price.Text = eighthdr["Price"].ToString();
                lblbtnview8Description.Text = eighthdr["Description"].ToString();
                lblbtnview8Shopname.Text = eighthdr["Shopname"].ToString();
                eighthdr.Close();
            }
            else
            {
                lblbtnview8.Visible = false;
                eighthdr.Close();
            }
            //view8

            //view9
            SqlCommand ninthdmd = new SqlCommand("select * from allTable where Id='" + 9 + "' and Shopname='" + view + "'", conn);
            SqlDataReader ninthdr = ninthdmd.ExecuteReader();

            if (ninthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview9Image.ImageUrl = ninthdr["image"].ToString();
                lblbtnview9Foodname.Text = ninthdr["Foodname"].ToString();
                lblbtnview9Price.Text = ninthdr["Price"].ToString();
                lblbtnview9Description.Text = ninthdr["Description"].ToString();
                lblbtnview9Shopname.Text = ninthdr["Shopname"].ToString();
                ninthdr.Close();
            }
            else
            {
                lblbtnview9.Visible = false;
                ninthdr.Close();
            }
            //view9

            //view10
            SqlCommand tenthdmd = new SqlCommand("select * from allTable where Id='" + 10 + "' and Shopname='" + view + "'", conn);
            SqlDataReader tenthdr = tenthdmd.ExecuteReader();

            if (tenthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview10Image.ImageUrl = tenthdr["image"].ToString();
                lblbtnview10Foodname.Text = tenthdr["Foodname"].ToString();
                lblbtnview10Price.Text = tenthdr["Price"].ToString();
                lblbtnview10Description.Text = tenthdr["Description"].ToString();
                lblbtnview10Shopname.Text = tenthdr["Shopname"].ToString();
                tenthdr.Close();
            }
            else
            {
                lblbtnview10.Visible = false;
                tenthdr.Close();
            }
            //view10

        }

        //btnview6
        protected void btnview6_Click(object sender, EventArgs e)
        {
            conn.Open();

            string view = lblSecondSecondShopname.Text;

            Session["shopname"] = lblSecondSecondShopname.Text;
            //lblcc.Text = Session["shopname"].ToString();
            lblshopshop.Visible = true;
            SqlCommand d = new SqlCommand("select * from OpenandcloseTable where Shopname= '" + Session["shopname"] + "'", conn);
            //d.Parameters.AddWithValue("@ss1", Session["shopname"].ToString());
            SqlDataReader r = d.ExecuteReader();
            if (r.Read())
            {
                lblShopname.Text = r["Shopname"].ToString();
                lbloo.Text = r["S"].ToString();
                lblcc.Text = r["E"].ToString();
                lblphone.Text = r["PhNumber"].ToString();
                lbladdress.Text = r["Location"].ToString();
            }
            else
            {


            }
            r.Close();











            SqlCommand cmd = new SqlCommand("select * from allTable where Id='" + 1 + "' and Shopname='" + view + "'", conn);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image3.ImageUrl = rdr["image"].ToString();
                lblex1.Text = rdr["Foodname"].ToString();
                lblex2.Text = rdr["Price"].ToString();
                lblex3.Text = rdr["Shopname"].ToString();
                lblex4.Text = rdr["Description"].ToString();
                rdr.Close();
            }
            else
            {
                lblbtnview1.Visible = false;
                rdr.Close();
            }

            SqlCommand amd = new SqlCommand("select * from allTable where Id='" + 2 + "' and Shopname='" + view + "'", conn);
            SqlDataReader rd = amd.ExecuteReader();

            if (rd.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image4.ImageUrl = rd["image"].ToString();
                lblee1.Text = rd["Foodname"].ToString();
                lblee2.Text = rd["Price"].ToString();
                lblee3.Text = rd["Shopname"].ToString();
                lblee4.Text = rd["Description"].ToString();
                rd.Close();
            }
            else
            {
                lblbtnview2.Visible = false;
                rd.Close();
            }

            SqlCommand dmd = new SqlCommand("select * from allTable where Id='" + 3 + "' and Shopname='" + view + "'", conn);
            SqlDataReader dr = dmd.ExecuteReader();

            if (dr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image6.ImageUrl = dr["image"].ToString();
                lblss1.Text = dr["Foodname"].ToString();
                lblss2.Text = dr["Price"].ToString();
                lblss3.Text = dr["Shopname"].ToString();
                lblss4.Text = dr["Description"].ToString();
                dr.Close();
            }
            else
            {
                lblbtnview3.Visible = false;
                dr.Close();
            }

            SqlCommand fourthdmd = new SqlCommand("select * from allTable where Id='" + 4 + "' and Shopname='" + view + "'", conn);
            SqlDataReader fourthdr = fourthdmd.ExecuteReader();

            if (fourthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview4Image.ImageUrl = fourthdr["image"].ToString();
                lblbtnview4Foodname.Text = fourthdr["Foodname"].ToString();
                lblbtnview4Price.Text = fourthdr["Price"].ToString();
                lblbtnview4Description.Text = fourthdr["Description"].ToString();
                lblbtnview4Shopname.Text = fourthdr["Shopname"].ToString();
                fourthdr.Close();
            }
            else
            {
                lblbtnview4.Visible = false;
                fourthdr.Close();
            }

            //view5
            SqlCommand fifthdmd = new SqlCommand("select * from allTable where Id='" + 5 + "' and Shopname='" + view + "'", conn);
            SqlDataReader fifthdr = fifthdmd.ExecuteReader();

            if (fifthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview5Image.ImageUrl = fifthdr["image"].ToString();
                lblbtnview5Foodname.Text = fifthdr["Foodname"].ToString();
                lblbtnview5Price.Text = fifthdr["Price"].ToString();
                lblbtnview5Description.Text = fifthdr["Description"].ToString();
                lblbtnview5Shopname.Text = fifthdr["Shopname"].ToString();
                fifthdr.Close();
            }
            else
            {
                lblbtnview5.Visible = false;
                fifthdr.Close();
            }
            //view5

            //view6
            SqlCommand sixthdmd = new SqlCommand("select * from allTable where Id='" + 6 + "' and Shopname='" + view + "'", conn);
            SqlDataReader sixthdr = sixthdmd.ExecuteReader();

            if (sixthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview6Image.ImageUrl = sixthdr["image"].ToString();
                lblbtnview6Foodname.Text = sixthdr["Foodname"].ToString();
                lblbtnview6Price.Text = sixthdr["Price"].ToString();
                lblbtnview6Description.Text = sixthdr["Description"].ToString();
                lblbtnview6Shopname.Text = sixthdr["Shopname"].ToString();
                sixthdr.Close();
            }
            else
            {
                lblbtnview6.Visible = false;
                sixthdr.Close();
            }
            //view6

            //view7
            SqlCommand seventhdmd = new SqlCommand("select * from allTable where Id='" + 7 + "' and Shopname='" + view + "'", conn);
            SqlDataReader seventhdr = seventhdmd.ExecuteReader();

            if (seventhdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview7Image.ImageUrl = seventhdr["image"].ToString();
                lblbtnview7Foodname.Text = seventhdr["Foodname"].ToString();
                lblbtnview7Price.Text = seventhdr["Price"].ToString();
                lblbtnview7Description.Text = seventhdr["Description"].ToString();
                lblbtnview7Shopname.Text = seventhdr["Shopname"].ToString();
                seventhdr.Close();
            }
            else
            {
                lblbtnview7.Visible = false;
                seventhdr.Close();
            }
            //view7

            //view8
            SqlCommand eighthdmd = new SqlCommand("select * from allTable where Id='" + 8 + "' and Shopname='" + view + "'", conn);
            SqlDataReader eighthdr = eighthdmd.ExecuteReader();

            if (eighthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview8Image.ImageUrl = eighthdr["image"].ToString();
                lblbtnview8Foodname.Text = eighthdr["Foodname"].ToString();
                lblbtnview8Price.Text = eighthdr["Price"].ToString();
                lblbtnview8Description.Text = eighthdr["Description"].ToString();
                lblbtnview8Shopname.Text = eighthdr["Shopname"].ToString();
                eighthdr.Close();
            }
            else
            {
                lblbtnview8.Visible = false;
                eighthdr.Close();
            }
            //view8

            //view9
            SqlCommand ninthdmd = new SqlCommand("select * from allTable where Id='" + 9 + "' and Shopname='" + view + "'", conn);
            SqlDataReader ninthdr = ninthdmd.ExecuteReader();

            if (ninthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview9Image.ImageUrl = ninthdr["image"].ToString();
                lblbtnview9Foodname.Text = ninthdr["Foodname"].ToString();
                lblbtnview9Price.Text = ninthdr["Price"].ToString();
                lblbtnview9Description.Text = ninthdr["Description"].ToString();
                lblbtnview9Shopname.Text = ninthdr["Shopname"].ToString();
                ninthdr.Close();
            }
            else
            {
                lblbtnview9.Visible = false;
                ninthdr.Close();
            }
            //view9

            //view10
            SqlCommand tenthdmd = new SqlCommand("select * from allTable where Id='" + 10 + "' and Shopname='" + view + "'", conn);
            SqlDataReader tenthdr = tenthdmd.ExecuteReader();

            if (tenthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview10Image.ImageUrl = tenthdr["image"].ToString();
                lblbtnview10Foodname.Text = tenthdr["Foodname"].ToString();
                lblbtnview10Price.Text = tenthdr["Price"].ToString();
                lblbtnview10Description.Text = tenthdr["Description"].ToString();
                lblbtnview10Shopname.Text = tenthdr["Shopname"].ToString();
                tenthdr.Close();
            }
            else
            {
                lblbtnview10.Visible = false;
                tenthdr.Close();
            }
            //view10

        }

        //btnview7
        protected void btnview7_Click(object sender, EventArgs e)
        {
            conn.Open();

            string view = lblSecondThirdShopname.Text;

            Session["shopname"] = lblSecondThirdShopname.Text;
            //lblcc.Text = Session["shopname"].ToString();
            lblshopshop.Visible = true;
            SqlCommand d = new SqlCommand("select * from OpenandcloseTable where Shopname= '" + Session["shopname"] + "'", conn);
            //d.Parameters.AddWithValue("@ss1", Session["shopname"].ToString());
            SqlDataReader r = d.ExecuteReader();
            if (r.Read())
            {
                lblShopname.Text = r["Shopname"].ToString();
                lbloo.Text = r["S"].ToString();
                lblcc.Text = r["E"].ToString();
                lblphone.Text = r["PhNumber"].ToString();
                lbladdress.Text = r["Location"].ToString();
            }
            else
            {


            }
            r.Close();











            SqlCommand cmd = new SqlCommand("select * from allTable where Id='" + 1 + "' and Shopname='" + view + "'", conn);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image3.ImageUrl = rdr["image"].ToString();
                lblex1.Text = rdr["Foodname"].ToString();
                lblex2.Text = rdr["Price"].ToString();
                lblex3.Text = rdr["Shopname"].ToString();
                lblex4.Text = rdr["Description"].ToString();
                rdr.Close();
            }
            else
            {
                lblbtnview1.Visible = false;
                rdr.Close();
            }

            SqlCommand amd = new SqlCommand("select * from allTable where Id='" + 2 + "' and Shopname='" + view + "'", conn);
            SqlDataReader rd = amd.ExecuteReader();

            if (rd.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image4.ImageUrl = rd["image"].ToString();
                lblee1.Text = rd["Foodname"].ToString();
                lblee2.Text = rd["Price"].ToString();
                lblee3.Text = rd["Shopname"].ToString();
                lblee4.Text = rd["Description"].ToString();
                rd.Close();
            }
            else
            {
                lblbtnview2.Visible = false;
                rd.Close();
            }

            SqlCommand dmd = new SqlCommand("select * from allTable where Id='" + 3 + "' and Shopname='" + view + "'", conn);
            SqlDataReader dr = dmd.ExecuteReader();

            if (dr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image6.ImageUrl = dr["image"].ToString();
                lblss1.Text = dr["Foodname"].ToString();
                lblss2.Text = dr["Price"].ToString();
                lblss3.Text = dr["Shopname"].ToString();
                lblss4.Text = dr["Description"].ToString();
                dr.Close();
            }
            else
            {
                lblbtnview3.Visible = false;
                dr.Close();
            }

            SqlCommand fourthdmd = new SqlCommand("select * from allTable where Id='" + 4 + "' and Shopname='" + view + "'", conn);
            SqlDataReader fourthdr = fourthdmd.ExecuteReader();

            if (fourthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview4Image.ImageUrl = fourthdr["image"].ToString();
                lblbtnview4Foodname.Text = fourthdr["Foodname"].ToString();
                lblbtnview4Price.Text = fourthdr["Price"].ToString();
                lblbtnview4Description.Text = fourthdr["Description"].ToString();
                lblbtnview4Shopname.Text = fourthdr["Shopname"].ToString();
                fourthdr.Close();
            }
            else
            {
                lblbtnview4.Visible = false;
                fourthdr.Close();
            }

            //view5
            SqlCommand fifthdmd = new SqlCommand("select * from allTable where Id='" + 5 + "' and Shopname='" + view + "'", conn);
            SqlDataReader fifthdr = fifthdmd.ExecuteReader();

            if (fifthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview5Image.ImageUrl = fifthdr["image"].ToString();
                lblbtnview5Foodname.Text = fifthdr["Foodname"].ToString();
                lblbtnview5Price.Text = fifthdr["Price"].ToString();
                lblbtnview5Description.Text = fifthdr["Description"].ToString();
                lblbtnview5Shopname.Text = fifthdr["Shopname"].ToString();
                fifthdr.Close();
            }
            else
            {
                lblbtnview5.Visible = false;
                fifthdr.Close();
            }
            //view5

            //view6
            SqlCommand sixthdmd = new SqlCommand("select * from allTable where Id='" + 6 + "' and Shopname='" + view + "'", conn);
            SqlDataReader sixthdr = sixthdmd.ExecuteReader();

            if (sixthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview6Image.ImageUrl = sixthdr["image"].ToString();
                lblbtnview6Foodname.Text = sixthdr["Foodname"].ToString();
                lblbtnview6Price.Text = sixthdr["Price"].ToString();
                lblbtnview6Description.Text = sixthdr["Description"].ToString();
                lblbtnview6Shopname.Text = sixthdr["Shopname"].ToString();
                sixthdr.Close();
            }
            else
            {
                lblbtnview6.Visible = false;
                sixthdr.Close();
            }
            //view6

            //view7
            SqlCommand seventhdmd = new SqlCommand("select * from allTable where Id='" + 7 + "' and Shopname='" + view + "'", conn);
            SqlDataReader seventhdr = seventhdmd.ExecuteReader();

            if (seventhdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview7Image.ImageUrl = seventhdr["image"].ToString();
                lblbtnview7Foodname.Text = seventhdr["Foodname"].ToString();
                lblbtnview7Price.Text = seventhdr["Price"].ToString();
                lblbtnview7Description.Text = seventhdr["Description"].ToString();
                lblbtnview7Shopname.Text = seventhdr["Shopname"].ToString();
                seventhdr.Close();
            }
            else
            {
                lblbtnview7.Visible = false;
                seventhdr.Close();
            }
            //view7

            //view8
            SqlCommand eighthdmd = new SqlCommand("select * from allTable where Id='" + 8 + "' and Shopname='" + view + "'", conn);
            SqlDataReader eighthdr = eighthdmd.ExecuteReader();

            if (eighthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview8Image.ImageUrl = eighthdr["image"].ToString();
                lblbtnview8Foodname.Text = eighthdr["Foodname"].ToString();
                lblbtnview8Price.Text = eighthdr["Price"].ToString();
                lblbtnview8Description.Text = eighthdr["Description"].ToString();
                lblbtnview8Shopname.Text = eighthdr["Shopname"].ToString();
                eighthdr.Close();
            }
            else
            {
                lblbtnview8.Visible = false;
                eighthdr.Close();
            }
            //view8

            //view9
            SqlCommand ninthdmd = new SqlCommand("select * from allTable where Id='" + 9 + "' and Shopname='" + view + "'", conn);
            SqlDataReader ninthdr = ninthdmd.ExecuteReader();

            if (ninthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview9Image.ImageUrl = ninthdr["image"].ToString();
                lblbtnview9Foodname.Text = ninthdr["Foodname"].ToString();
                lblbtnview9Price.Text = ninthdr["Price"].ToString();
                lblbtnview9Description.Text = ninthdr["Description"].ToString();
                lblbtnview9Shopname.Text = ninthdr["Shopname"].ToString();
                ninthdr.Close();
            }
            else
            {
                lblbtnview9.Visible = false;
                ninthdr.Close();
            }
            //view9

            //view10
            SqlCommand tenthdmd = new SqlCommand("select * from allTable where Id='" + 10 + "' and Shopname='" + view + "'", conn);
            SqlDataReader tenthdr = tenthdmd.ExecuteReader();

            if (tenthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview10Image.ImageUrl = tenthdr["image"].ToString();
                lblbtnview10Foodname.Text = tenthdr["Foodname"].ToString();
                lblbtnview10Price.Text = tenthdr["Price"].ToString();
                lblbtnview10Description.Text = tenthdr["Description"].ToString();
                lblbtnview10Shopname.Text = tenthdr["Shopname"].ToString();
                tenthdr.Close();
            }
            else
            {
                lblbtnview10.Visible = false;
                tenthdr.Close();
            }
            //view10

        }





        //Addtocart4
        protected void btnaddtocart1_Click(object sender, EventArgs e)
        {

            conn.Open();

            
            Session["shopnamea"] = lblex3.Text;
            
            if (Session["email"] != null)
            {
                SqlCommand already = new SqlCommand("select * from CartTable where Email=@a and Foodname=@b and Shopname=@c", conn);
                already.Parameters.AddWithValue("@a", Session["email"]);
                already.Parameters.AddWithValue("@b", lblex1.Text);
                already.Parameters.AddWithValue("@c", lblex3.Text);
                SqlDataReader alreadyrdr = already.ExecuteReader();
                if (alreadyrdr.Read())
                {

                    Response.Redirect("AddToCart.aspx");
                    Response.Write("<script>alert('You are already order.If you want order again,please wait order confirm');</script>");
                    alreadyrdr.Close();
                    
                }
                else
                {
                    alreadyrdr.Close();
                    SqlCommand cmd = new SqlCommand("insert into CartTable(Foodname,Email,Price,Typeoffood,image,Description,Shopname) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7)", conn);
                    cmd.Parameters.AddWithValue("@a1", lblex1.Text);

                    cmd.Parameters.AddWithValue("@a2", Session["email"]);
                    cmd.Parameters.AddWithValue("@a3", lblex2.Text);
                    cmd.Parameters.AddWithValue("@a4", "fruit");
                    cmd.Parameters.AddWithValue("@a5", image3.ImageUrl);

                    cmd.Parameters.AddWithValue("@a6", lblex4.Text);
                    cmd.Parameters.AddWithValue("@a7", lblex3.Text);

                    cmd.ExecuteNonQuery();
                    
                }
                
                conn.Close();
            }
            else
            {
                Response.Write("<script>alert('Please Login');</script>");
            }
        }
        //Addtocart4

        //Addtocart4
        protected void btnaddtocart2_Click(object sender, EventArgs e)
        {
            Session["shopnamea"] = lblee3.Text;
           
            conn.Open();

            
            if (Session["email"] != null)
            {
                SqlCommand already = new SqlCommand("select * from CartTable where Email=@a and Foodname=@b and Shopname=@c", conn);
                already.Parameters.AddWithValue("@a", Session["email"]);
                already.Parameters.AddWithValue("@b", lblee1.Text);
                already.Parameters.AddWithValue("@c", lblee3.Text);
                SqlDataReader alreadyrdr = already.ExecuteReader();
                if (alreadyrdr.Read())
                {

                    Response.Redirect("AddToCart.aspx");
                    Response.Write("<script>alert('You are already order.If you want order again,please wait order confirm');</script>");
                    alreadyrdr.Close();
                    
                }
                else
                {
                    alreadyrdr.Close();
                    SqlCommand cmd = new SqlCommand("insert into CartTable(Foodname,Email,Price,Typeoffood,image,Description,Shopname) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7)", conn);
                    cmd.Parameters.AddWithValue("@a1", lblee1.Text);

                    cmd.Parameters.AddWithValue("@a2", Session["email"]);
                    cmd.Parameters.AddWithValue("@a3", lblee2.Text);
                    cmd.Parameters.AddWithValue("@a4", "fruit");
                    cmd.Parameters.AddWithValue("@a5", image4.ImageUrl);

                    cmd.Parameters.AddWithValue("@a6", lblee4.Text);
                    cmd.Parameters.AddWithValue("@a7", lblee3.Text);

                    cmd.ExecuteNonQuery();
                    
                }
                
                conn.Close();
            }
            else
            {
                Response.Write("<script>alert('Please Login');</script>");
            }
        }
        //Addtocart4

        //Addtocart4
        protected void btnaddtocart3_Click(object sender, EventArgs e)
        {
           
            Session["shopnamea"] = lblss3.Text;
           
            conn.Open();

           
            if (Session["email"] != null)
            {
                SqlCommand already = new SqlCommand("select * from CartTable where Email=@a and Foodname=@b and Shopname=@c", conn);
                already.Parameters.AddWithValue("@a", Session["email"]);
                already.Parameters.AddWithValue("@b", lblss1.Text);
                already.Parameters.AddWithValue("@c", lblss3.Text);

                SqlDataReader alreadyrdr = already.ExecuteReader();
                if (alreadyrdr.Read())
                {

                    Response.Redirect("AddToCart.aspx");
                    Response.Write("<script>alert('You are already order.If you want order again,please wait order confirm');</script>");
                    alreadyrdr.Close();
                    
                }
                else
                {
                    alreadyrdr.Close();
                    SqlCommand cmd = new SqlCommand("insert into CartTable(Foodname,Email,Price,Typeoffood,image,Description,Shopname) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7)", conn);
                    cmd.Parameters.AddWithValue("@a1", lblss1.Text);

                    cmd.Parameters.AddWithValue("@a2", Session["email"]);
                    cmd.Parameters.AddWithValue("@a3", lblss2.Text);
                    cmd.Parameters.AddWithValue("@a4", "fruit");
                    cmd.Parameters.AddWithValue("@a5", image6.ImageUrl);

                    cmd.Parameters.AddWithValue("@a6", lblss4.Text);
                    cmd.Parameters.AddWithValue("@a7", lblss3.Text);

                    cmd.ExecuteNonQuery();
                    
                }
                
                conn.Close();
            }
            else
            {
                Response.Write("<script>alert('Please Login');</script>");
            }
        }
        //Addtocart4

        //Addtocart4
        protected void btnaddtocart4_Click(object sender, EventArgs e)
        {
           
            Session["shopnamea"] = lblbtnview4Shopname.Text;
            
            conn.Open();

           
            if (Session["email"] != null)
            {
                SqlCommand already = new SqlCommand("select * from CartTable where Email=@a and Foodname=@b and Shopname=@c", conn);
                already.Parameters.AddWithValue("@a",Session["email"]);
                already.Parameters.AddWithValue("@b", lblbtnview4Foodname.Text);
                already.Parameters.AddWithValue("@c", lblbtnview4Shopname.Text);

                SqlDataReader alreadyrdr = already.ExecuteReader();
                if (alreadyrdr.Read())
                {
                    
                    Response.Redirect("AddToCart.aspx");
                    Response.Write("<script>alert('You are already order.If you want order again,please wait order confirm');</script>");
                    alreadyrdr.Close();
                   
                }
                else
                {
                    alreadyrdr.Close();
                    SqlCommand cmd = new SqlCommand("insert into CartTable(Foodname,Email,Price,Typeoffood,image,Description,Shopname) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7)", conn);
                    cmd.Parameters.AddWithValue("@a1", lblbtnview4Foodname.Text);

                    cmd.Parameters.AddWithValue("@a2", Session["email"]);
                    cmd.Parameters.AddWithValue("@a3", lblbtnview4Price.Text);
                    cmd.Parameters.AddWithValue("@a4", "fruit");
                    cmd.Parameters.AddWithValue("@a5", lblbtnview4Image.ImageUrl);

                    cmd.Parameters.AddWithValue("@a6", lblbtnview4Description.Text);
                    cmd.Parameters.AddWithValue("@a7", lblbtnview4Shopname.Text);

                    cmd.ExecuteNonQuery();
                    
                   
                }
               
                conn.Close();
            }
            else
            {
                Response.Write("<script>alert('Please Login');</script>");
            }
        }
        //Addtocart4

        //Addtocart5
        protected void btnaddtocart5_Click(object sender, EventArgs e)
        {
            
            Session["shopnamea"] = lblbtnview5Shopname.Text;

            
            conn.Open();

            
            if (Session["email"] != null)
            {
                SqlCommand already = new SqlCommand("select * from CartTable where Email=@a and Foodname=@b and Shopname=@c", conn);
                already.Parameters.AddWithValue("@a",Session["email"]);
                already.Parameters.AddWithValue("@b", lblbtnview5Foodname.Text);
                already.Parameters.AddWithValue("@c", lblbtnview5Shopname.Text);

                SqlDataReader alreadyrdr = already.ExecuteReader();
                if (alreadyrdr.Read())
                {

                    Response.Redirect("AddToCart.aspx");
                    Response.Write("<script>alert('You are already order.If you want order again,please wait order confirm');</script>");
                    alreadyrdr.Close();
                   
                }
                else
                {
                    alreadyrdr.Close();
                    SqlCommand cmd = new SqlCommand("insert into CartTable(Foodname,Email,Price,Typeoffood,image,Description,Shopname) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7)", conn);
                    cmd.Parameters.AddWithValue("@a1", lblbtnview5Foodname.Text);

                    cmd.Parameters.AddWithValue("@a2", Session["email"]);
                    cmd.Parameters.AddWithValue("@a3", lblbtnview5Price.Text);
                    cmd.Parameters.AddWithValue("@a4", "fruit");
                    cmd.Parameters.AddWithValue("@a5", lblbtnview5Image.ImageUrl);

                    cmd.Parameters.AddWithValue("@a6", lblbtnview5Description.Text);
                    cmd.Parameters.AddWithValue("@a7", lblbtnview5Shopname.Text);

                    cmd.ExecuteNonQuery();
                    
                }
                
                conn.Close();
            }
            else
            {
                Response.Write("<script>alert('Please Login');</script>");
            }
        }
        //Addtocart5

        //Addtocart6
        protected void btnaddtocart6_Click(object sender, EventArgs e)
        {
            

            Session["shopnamea"] = lblbtnview6Shopname.Text;
           
            conn.Open();
            

            if (Session["email"] != null)
            {

                SqlCommand already = new SqlCommand("select * from CartTable where Email=@a and Foodname=@b and Shopname=@c", conn);
                already.Parameters.AddWithValue("@a",Session["email"]);
                already.Parameters.AddWithValue("@b", lblbtnview6Foodname.Text);
                already.Parameters.AddWithValue("@c", lblbtnview6Shopname.Text);

                SqlDataReader alreadyrdr = already.ExecuteReader();
                if (alreadyrdr.Read())
                {

                    Response.Redirect("AddToCart.aspx");
                    Response.Write("<script>alert('You are already order.If you want order again,please wait order confirm');</script>");

                    alreadyrdr.Close();
                }
                else
                {
                    alreadyrdr.Close();
                    SqlCommand cmd = new SqlCommand("insert into CartTable(Foodname,Email,Price,Typeoffood,image,Description,Shopname) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7)", conn);
                    cmd.Parameters.AddWithValue("@a1", lblbtnview6Foodname.Text);

                    cmd.Parameters.AddWithValue("@a2", Session["email"]);
                    cmd.Parameters.AddWithValue("@a3", lblbtnview6Price.Text);
                    cmd.Parameters.AddWithValue("@a4", "fruit");
                    cmd.Parameters.AddWithValue("@a5", lblbtnview6Image.ImageUrl);

                    cmd.Parameters.AddWithValue("@a6", lblbtnview6Description.Text);
                    cmd.Parameters.AddWithValue("@a7", lblbtnview6Shopname.Text);

                    cmd.ExecuteNonQuery();
                    
                }
                
                conn.Close();
            }
            else
            {
                Response.Write("<script>alert('Please Login');</script>");
            }
        }
        //Addtocart6

        //Addtocart7
        protected void btnaddtocart7_Click(object sender, EventArgs e)
        {
           
            Session["shopnamea"] = lblbtnview7Shopname.Text;
            
            conn.Open();

            
            if (Session["email"] != null)
            {
                SqlCommand already = new SqlCommand("select * from CartTable where Email=@a and Foodname=@b and Shopname=@c", conn);
                already.Parameters.AddWithValue("@a",Session["email"]);
                already.Parameters.AddWithValue("@b", lblbtnview7Foodname.Text);
                already.Parameters.AddWithValue("@c", lblbtnview7Shopname.Text);

                SqlDataReader alreadyrdr = already.ExecuteReader();
                if (alreadyrdr.Read())
                {

                    Response.Redirect("AddToCart.aspx");
                    Response.Write("<script>alert('You are already order.If you want order again,please wait order confirm');</script>");
                    alreadyrdr.Close();
                    
                }
                else
                {
                    alreadyrdr.Close();
                    SqlCommand cmd = new SqlCommand("insert into CartTable(Foodname,Email,Price,Typeoffood,image,Description,Shopname) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7)", conn);
                    cmd.Parameters.AddWithValue("@a1", lblbtnview7Foodname.Text);

                    cmd.Parameters.AddWithValue("@a2", Session["email"]);
                    cmd.Parameters.AddWithValue("@a3", lblbtnview7Price.Text);
                    cmd.Parameters.AddWithValue("@a4", "fruit");
                    cmd.Parameters.AddWithValue("@a5", lblbtnview7Image.ImageUrl);

                    cmd.Parameters.AddWithValue("@a6", lblbtnview7Description.Text);
                    cmd.Parameters.AddWithValue("@a7", lblbtnview7Shopname.Text);

                    cmd.ExecuteNonQuery();
                    
                    
                }
                
                conn.Close();
            }
            else
            {
                Response.Write("<script>alert('Please Login');</script>");
            }
        }
        //Addtocart7

        //Addtocart8
        protected void btnaddtocart8_Click(object sender, EventArgs e)
        {
            
            Session["shopnamea"] = lblbtnview8Shopname.Text;

            
            conn.Open();

            
            if (Session["email"] != null)
            {
                SqlCommand already = new SqlCommand("select * from CartTable where Email=@a and Foodname=@b and Shopname=@c", conn);
                already.Parameters.AddWithValue("@a",Session["email"]);
                already.Parameters.AddWithValue("@b", lblbtnview8Foodname.Text);
                already.Parameters.AddWithValue("@c", lblbtnview8Shopname.Text);

                SqlDataReader alreadyrdr = already.ExecuteReader();
                if (alreadyrdr.Read())
                {

                    Response.Redirect("AddToCart.aspx");
                    Response.Write("<script>alert('You are already order.If you want order again,please wait order confirm');</script>");
                    alreadyrdr.Close();
                    
                }
                else
                {
                    alreadyrdr.Close();
                    SqlCommand cmd = new SqlCommand("insert into CartTable(Foodname,Email,Price,Typeoffood,image,Description,Shopname) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7)", conn);
                    cmd.Parameters.AddWithValue("@a1", lblbtnview8Foodname.Text);

                    cmd.Parameters.AddWithValue("@a2", Session["email"]);
                    cmd.Parameters.AddWithValue("@a3", lblbtnview8Price.Text);
                    cmd.Parameters.AddWithValue("@a4", "fruit");
                    cmd.Parameters.AddWithValue("@a5", lblbtnview8Image.ImageUrl);

                    cmd.Parameters.AddWithValue("@a6", lblbtnview8Description.Text);
                    cmd.Parameters.AddWithValue("@a7", lblbtnview8Shopname.Text);

                    cmd.ExecuteNonQuery();
                   
                }
                
                conn.Close();
            }
            else
            {
                Response.Write("<script>alert('Please Login');</script>");
            }
        }
        //Addtocart8

        //Addtocart9
        protected void btnaddtocart9_Click(object sender, EventArgs e)
        {
            
            Session["shopnamea"] = lblbtnview9Shopname.Text;
            
            conn.Open();

           
            if (Session["email"] != null)
            {
                SqlCommand already = new SqlCommand("select * from CartTable where Email=@a and Foodname=@b and Shopname=@c", conn);
                already.Parameters.AddWithValue("@a",Session["email"]);
                already.Parameters.AddWithValue("@b", lblbtnview9Foodname.Text);
                already.Parameters.AddWithValue("@c", lblbtnview9Shopname.Text);

                SqlDataReader alreadyrdr = already.ExecuteReader();
                if (alreadyrdr.Read())
                {

                    Response.Redirect("AddToCart.aspx");
                    Response.Write("<script>alert('You are already order.If you want order again,please wait order confirm');</script>");
                    alreadyrdr.Close();
                    
                }
                else
                {
                    alreadyrdr.Close();
                    SqlCommand cmd = new SqlCommand("insert into CartTable(Foodname,Email,Price,Typeoffood,image,Description,Shopname) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7)", conn);
                    cmd.Parameters.AddWithValue("@a1", lblbtnview9Foodname.Text);

                    cmd.Parameters.AddWithValue("@a2", Session["email"]);
                    cmd.Parameters.AddWithValue("@a3", lblbtnview9Price.Text);
                    cmd.Parameters.AddWithValue("@a4", "fruit");
                    cmd.Parameters.AddWithValue("@a5", lblbtnview9Image.ImageUrl);

                    cmd.Parameters.AddWithValue("@a6", lblbtnview9Description.Text);
                    cmd.Parameters.AddWithValue("@a7", lblbtnview9Shopname.Text);

                    cmd.ExecuteNonQuery();
                   
                }
                
                conn.Close();
            }
            else
            {
                Response.Write("<script>alert('Please Login');</script>");
            }
        }
        //Addtocart9

        //Addtocart10
        protected void btnaddtocart10_Click(object sender, EventArgs e)
        {
            
            Session["shopnamea"] = lblbtnview10Shopname.Text;
            conn.Open();

           
            if (Session["email"] != null)
            {
                SqlCommand already = new SqlCommand("select * from CartTable where Email=@a and Foodname=@b and Shopname=@c", conn);
                already.Parameters.AddWithValue("@a",Session["email"]);
                already.Parameters.AddWithValue("@b", lblbtnview10Foodname.Text);
                already.Parameters.AddWithValue("@c", lblbtnview10Shopname.Text);

                SqlDataReader alreadyrdr = already.ExecuteReader();
                if (alreadyrdr.Read())
                {

                    Response.Redirect("AddToCart.aspx");
                    Response.Write("<script>alert('You are already order.If you want order again,please wait order confirm');</script>");
                    alreadyrdr.Close();
                    
                }
                else
                {
                    alreadyrdr.Close();
                    SqlCommand cmd = new SqlCommand("insert into CartTable(Foodname,Email,Price,Typeoffood,image,Description,Shopname) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7)", conn);
                    cmd.Parameters.AddWithValue("@a1", lblbtnview10Foodname.Text);

                    cmd.Parameters.AddWithValue("@a2", Session["email"]);
                    cmd.Parameters.AddWithValue("@a3", lblbtnview10Price.Text);
                    cmd.Parameters.AddWithValue("@a4", "fruit");
                    cmd.Parameters.AddWithValue("@a5", lblbtnview10Image.ImageUrl);

                    cmd.Parameters.AddWithValue("@a6", lblbtnview10Description.Text);
                    cmd.Parameters.AddWithValue("@a7", lblbtnview10Shopname.Text);

                    cmd.ExecuteNonQuery();
                    
                }
                
                conn.Close();
            }
            else
            {
                Response.Write("<script>alert('Please Login');</script>");
            }
        }
        //Addtocart10

        protected void btnkorean_Click(object sender, EventArgs e)
        {

            conn.Open();
           string a=lblkorean.Text;
           SqlCommand cmd = new SqlCommand("select * from allTable where Id='" + 1 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
           cmd.Parameters.AddWithValue("@foodname","Korean Food");
            SqlDataReader rdr = cmd.ExecuteReader();

           if (rdr.Read())
           {
               lblFirst.Visible = false;
               lblSecond.Visible = false;
               lblThird.Visible = false;
               lblFourth.Visible = false;
               lblSecondFirst.Visible = false;
               lblSecondSecond.Visible = false;
               lblSecondThird.Visible = false;
               Label2.Visible = true;


               image3.ImageUrl = rdr["image"].ToString();
               lblex1.Text = rdr["Foodname"].ToString();
               lblex2.Text = rdr["Price"].ToString();
               lblex3.Text = rdr["Shopname"].ToString();
               lblex4.Text = rdr["Description"].ToString();
               rdr.Close();
           }
           else
           {

               lblbtnview1.Visible = false;
               rdr.Close();
           }


           SqlCommand amd = new SqlCommand("select * from allTable where Id='" + 2 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
           amd.Parameters.AddWithValue("@foodname", "Korean Food");
           SqlDataReader rd = amd.ExecuteReader();

           if (rd.Read())
           {
               lblFirst.Visible = false;
               lblSecond.Visible = false;
               lblThird.Visible = false;
               lblFourth.Visible = false;
               lblSecondFirst.Visible = false;
               lblSecondSecond.Visible = false;
               lblSecondThird.Visible = false;
               Label2.Visible = true;


               image4.ImageUrl = rd["image"].ToString();
               lblee1.Text = rd["Foodname"].ToString();
               lblee2.Text = rd["Price"].ToString();
               lblee3.Text = rd["Shopname"].ToString();
               lblee4.Text = rd["Description"].ToString();
               rd.Close();
           }
           else
           {
               lblbtnview2.Visible = false;
               rd.Close();
           }

           SqlCommand dmd = new SqlCommand("select * from allTable where Id='" + 3 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
           dmd.Parameters.AddWithValue("@foodname", "Korean Food");
           SqlDataReader dr = dmd.ExecuteReader();

           if (dr.Read())
           {
               lblFirst.Visible = false;
               lblSecond.Visible = false;
               lblThird.Visible = false;
               lblFourth.Visible = false;
               lblSecondFirst.Visible = false;
               lblSecondSecond.Visible = false;
               lblSecondThird.Visible = false;
               Label2.Visible = true;


               image6.ImageUrl = dr["image"].ToString();
               lblss1.Text = dr["Foodname"].ToString();
               lblss2.Text = dr["Price"].ToString();
               lblss3.Text = dr["Shopname"].ToString();
               lblss4.Text = dr["Description"].ToString();
               dr.Close();
           }
           else
           {
               lblbtnview3.Visible = false;
               dr.Close();
           }

           SqlCommand fourthdmd = new SqlCommand("select * from allTable where Id='" + 4 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
           fourthdmd.Parameters.AddWithValue("@foodname", "Korean Food");
           SqlDataReader fourthdr = fourthdmd.ExecuteReader();

           if (fourthdr.Read())
           {
               lblFirst.Visible = false;
               lblSecond.Visible = false;
               lblThird.Visible = false;
               lblFourth.Visible = false;
               lblSecondFirst.Visible = false;
               lblSecondSecond.Visible = false;
               lblSecondThird.Visible = false;
               Label2.Visible = true;

               lblbtnview4Image.ImageUrl = fourthdr["image"].ToString();
               lblbtnview4Foodname.Text = fourthdr["Foodname"].ToString();
               lblbtnview4Price.Text = fourthdr["Price"].ToString();
               lblbtnview4Description.Text = fourthdr["Description"].ToString();
               lblbtnview4Shopname.Text = fourthdr["Shopname"].ToString();
               fourthdr.Close();
           }
           else
           {
               lblbtnview4.Visible = false;
               fourthdr.Close();
           }

           //view5
           SqlCommand fifthdmd = new SqlCommand("select * from allTable where Id='" + 5 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
           fifthdmd.Parameters.AddWithValue("@foodname", "Korean Food");
           SqlDataReader fifthdr = fifthdmd.ExecuteReader();

           if (fifthdr.Read())
           {
               lblFirst.Visible = false;
               lblSecond.Visible = false;
               lblThird.Visible = false;
               lblFourth.Visible = false;
               lblSecondFirst.Visible = false;
               lblSecondSecond.Visible = false;
               lblSecondThird.Visible = false;
               Label2.Visible = true;

               lblbtnview5Image.ImageUrl = fifthdr["image"].ToString();
               lblbtnview5Foodname.Text = fifthdr["Foodname"].ToString();
               lblbtnview5Price.Text = fifthdr["Price"].ToString();
               lblbtnview5Description.Text = fifthdr["Description"].ToString();
               lblbtnview5Shopname.Text = fifthdr["Shopname"].ToString();
               fifthdr.Close();
           }
           else
           {
               lblbtnview5.Visible = false;
               fifthdr.Close();
           }
           //view5

           //view6
           SqlCommand sixthdmd = new SqlCommand("select * from allTable where Id='" + 6 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
           sixthdmd.Parameters.AddWithValue("@foodname", "Korean Food");
           SqlDataReader sixthdr = sixthdmd.ExecuteReader();

           if (sixthdr.Read())
           {
               lblFirst.Visible = false;
               lblSecond.Visible = false;
               lblThird.Visible = false;
               lblFourth.Visible = false;
               lblSecondFirst.Visible = false;
               lblSecondSecond.Visible = false;
               lblSecondThird.Visible = false;
               Label2.Visible = true;

               lblbtnview6Image.ImageUrl = sixthdr["image"].ToString();
               lblbtnview6Foodname.Text = sixthdr["Foodname"].ToString();
               lblbtnview6Price.Text = sixthdr["Price"].ToString();
               lblbtnview6Description.Text = sixthdr["Description"].ToString();
               lblbtnview6Shopname.Text = sixthdr["Shopname"].ToString();
               sixthdr.Close();
           }
           else
           {
               lblbtnview6.Visible = false;
               sixthdr.Close();
           }
           //view6

           //view7
           SqlCommand seventhdmd = new SqlCommand("select * from allTable where Id='" + 7 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
           seventhdmd.Parameters.AddWithValue("@foodname", "Korean Food");
           SqlDataReader seventhdr = seventhdmd.ExecuteReader();

           if (seventhdr.Read())
           {
               lblFirst.Visible = false;
               lblSecond.Visible = false;
               lblThird.Visible = false;
               lblFourth.Visible = false;
               lblSecondFirst.Visible = false;
               lblSecondSecond.Visible = false;
               lblSecondThird.Visible = false;
               Label2.Visible = true;

               lblbtnview7Image.ImageUrl = seventhdr["image"].ToString();
               lblbtnview7Foodname.Text = seventhdr["Foodname"].ToString();
               lblbtnview7Price.Text = seventhdr["Price"].ToString();
               lblbtnview7Description.Text = seventhdr["Description"].ToString();
               lblbtnview7Shopname.Text = seventhdr["Shopname"].ToString();
               seventhdr.Close();
           }
           else
           {
               lblbtnview7.Visible = false;
               seventhdr.Close();
           }
           //view7

           //view8
           SqlCommand eighthdmd = new SqlCommand("select * from allTable where Id='" + 8 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
           eighthdmd.Parameters.AddWithValue("@foodname", "Korean Food");
           SqlDataReader eighthdr = eighthdmd.ExecuteReader();

           if (eighthdr.Read())
           {
               lblFirst.Visible = false;
               lblSecond.Visible = false;
               lblThird.Visible = false;
               lblFourth.Visible = false;
               lblSecondFirst.Visible = false;
               lblSecondSecond.Visible = false;
               lblSecondThird.Visible = false;
               Label2.Visible = true;

               lblbtnview8Image.ImageUrl = eighthdr["image"].ToString();
               lblbtnview8Foodname.Text = eighthdr["Foodname"].ToString();
               lblbtnview8Price.Text = eighthdr["Price"].ToString();
               lblbtnview8Description.Text = eighthdr["Description"].ToString();
               lblbtnview8Shopname.Text = eighthdr["Shopname"].ToString();
               eighthdr.Close();
           }
           else
           {
               lblbtnview8.Visible = false;
               eighthdr.Close();
           }
           //view8

           //view9
           SqlCommand ninthdmd = new SqlCommand("select * from allTable where Id='" + 9 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
           ninthdmd.Parameters.AddWithValue("@foodname", "Korean Food");
           SqlDataReader ninthdr = ninthdmd.ExecuteReader();

           if (ninthdr.Read())
           {
               lblFirst.Visible = false;
               lblSecond.Visible = false;
               lblThird.Visible = false;
               lblFourth.Visible = false;
               lblSecondFirst.Visible = false;
               lblSecondSecond.Visible = false;
               lblSecondThird.Visible = false;
               Label2.Visible = true;

               lblbtnview9Image.ImageUrl = ninthdr["image"].ToString();
               lblbtnview9Foodname.Text = ninthdr["Foodname"].ToString();
               lblbtnview9Price.Text = ninthdr["Price"].ToString();
               lblbtnview9Description.Text = ninthdr["Description"].ToString();
               lblbtnview9Shopname.Text = ninthdr["Shopname"].ToString();
               ninthdr.Close();
           }
           else
           {
               lblbtnview9.Visible = false;
               ninthdr.Close();
           }
           //view9

           //view10
           SqlCommand tenthdmd = new SqlCommand("select * from allTable where Id='" + 10 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
           tenthdmd.Parameters.AddWithValue("@foodname", "Korean Food");
           SqlDataReader tenthdr = tenthdmd.ExecuteReader();

           if (tenthdr.Read())
           {
               lblFirst.Visible = false;
               lblSecond.Visible = false;
               lblThird.Visible = false;
               lblFourth.Visible = false;
               lblSecondFirst.Visible = false;
               lblSecondSecond.Visible = false;
               lblSecondThird.Visible = false;
               Label2.Visible = true;

               lblbtnview10Image.ImageUrl = tenthdr["image"].ToString();
               lblbtnview10Foodname.Text = tenthdr["Foodname"].ToString();
               lblbtnview10Price.Text = tenthdr["Price"].ToString();
               lblbtnview10Description.Text = tenthdr["Description"].ToString();
               lblbtnview10Shopname.Text = tenthdr["Shopname"].ToString();
               tenthdr.Close();
           }
           else
           {
               lblbtnview10.Visible = false;
               tenthdr.Close();
           }
            //view10


        }

        protected void btnshan_Click(object sender, EventArgs e)
        {

            conn.Open();
            string a = lblkorean.Text;
            SqlCommand cmd = new SqlCommand("select * from allTable where Id='" + 1 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            cmd.Parameters.AddWithValue("@foodname", "shan food");
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image3.ImageUrl = rdr["image"].ToString();
                lblex1.Text = rdr["Foodname"].ToString();
                lblex2.Text = rdr["Price"].ToString();
                lblex3.Text = rdr["Shopname"].ToString();
                lblex4.Text = rdr["Description"].ToString();
                rdr.Close();
            }
            else
            {
                lblbtnview1.Visible = false;
                rdr.Close();
            }


            SqlCommand amd = new SqlCommand("select * from allTable where Id='" + 2 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            amd.Parameters.AddWithValue("@foodname", "shan food");
            SqlDataReader rd = amd.ExecuteReader();

            if (rd.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image4.ImageUrl = rd["image"].ToString();
                lblee1.Text = rd["Foodname"].ToString();
                lblee2.Text = rd["Price"].ToString();
                lblee3.Text = rd["Shopname"].ToString();
                lblee4.Text = rd["Description"].ToString();
                rd.Close();
            }
            else
            {
                lblbtnview2.Visible = false;
                rd.Close();
            }

            SqlCommand dmd = new SqlCommand("select * from allTable where Id='" + 3 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            dmd.Parameters.AddWithValue("@foodname", "shan food");
            SqlDataReader dr = dmd.ExecuteReader();

            if (dr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image6.ImageUrl = dr["image"].ToString();
                lblss1.Text = dr["Foodname"].ToString();
                lblss2.Text = dr["Price"].ToString();
                lblss3.Text = dr["Shopname"].ToString();
                lblss4.Text = dr["Description"].ToString();
                dr.Close();
            }
            else
            {
                lblbtnview3.Visible = false;
                dr.Close();
            }

            SqlCommand fourthdmd = new SqlCommand("select * from allTable where Id='" + 4 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            fourthdmd.Parameters.AddWithValue("@foodname", "shan food");
            SqlDataReader fourthdr = fourthdmd.ExecuteReader();

            if (fourthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview4Image.ImageUrl = fourthdr["image"].ToString();
                lblbtnview4Foodname.Text = fourthdr["Foodname"].ToString();
                lblbtnview4Price.Text = fourthdr["Price"].ToString();
                lblbtnview4Description.Text = fourthdr["Description"].ToString();
                lblbtnview4Shopname.Text = fourthdr["Shopname"].ToString();
                fourthdr.Close();
            }
            else
            {
                lblbtnview4.Visible = false;
                fourthdr.Close();
            }

            //view5
            SqlCommand fifthdmd = new SqlCommand("select * from allTable where Id='" + 5 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            fifthdmd.Parameters.AddWithValue("@foodname", "shan food");
            SqlDataReader fifthdr = fifthdmd.ExecuteReader();

            if (fifthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview5Image.ImageUrl = fifthdr["image"].ToString();
                lblbtnview5Foodname.Text = fifthdr["Foodname"].ToString();
                lblbtnview5Price.Text = fifthdr["Price"].ToString();
                lblbtnview5Description.Text = fifthdr["Description"].ToString();
                lblbtnview5Shopname.Text = fifthdr["Shopname"].ToString();
                fifthdr.Close();
            }
            else
            {
                lblbtnview5.Visible = false;
                fifthdr.Close();
            }
            //view5

            //view6
            SqlCommand sixthdmd = new SqlCommand("select * from allTable where Id='" + 6 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            sixthdmd.Parameters.AddWithValue("@foodname", "shan food");
            SqlDataReader sixthdr = sixthdmd.ExecuteReader();

            if (sixthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview6Image.ImageUrl = sixthdr["image"].ToString();
                lblbtnview6Foodname.Text = sixthdr["Foodname"].ToString();
                lblbtnview6Price.Text = sixthdr["Price"].ToString();
                lblbtnview6Description.Text = sixthdr["Description"].ToString();
                lblbtnview6Shopname.Text = sixthdr["Shopname"].ToString();
                sixthdr.Close();
            }
            else
            {
                lblbtnview6.Visible = false;
                sixthdr.Close();
            }
            //view6

            //view7
            SqlCommand seventhdmd = new SqlCommand("select * from allTable where Id='" + 7 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            seventhdmd.Parameters.AddWithValue("@foodname", "shan food");
            SqlDataReader seventhdr = seventhdmd.ExecuteReader();

            if (seventhdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview7Image.ImageUrl = seventhdr["image"].ToString();
                lblbtnview7Foodname.Text = seventhdr["Foodname"].ToString();
                lblbtnview7Price.Text = seventhdr["Price"].ToString();
                lblbtnview7Description.Text = seventhdr["Description"].ToString();
                lblbtnview7Shopname.Text = seventhdr["Shopname"].ToString();
                seventhdr.Close();
            }
            else
            {
                lblbtnview7.Visible = false;
                seventhdr.Close();
            }
            //view7

            //view8
            SqlCommand eighthdmd = new SqlCommand("select * from allTable where Id='" + 8 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            eighthdmd.Parameters.AddWithValue("@foodname", "shan food");
            SqlDataReader eighthdr = eighthdmd.ExecuteReader();

            if (eighthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview8Image.ImageUrl = eighthdr["image"].ToString();
                lblbtnview8Foodname.Text = eighthdr["Foodname"].ToString();
                lblbtnview8Price.Text = eighthdr["Price"].ToString();
                lblbtnview8Description.Text = eighthdr["Description"].ToString();
                lblbtnview8Shopname.Text = eighthdr["Shopname"].ToString();
                eighthdr.Close();
            }
            else
            {
                lblbtnview8.Visible = false;
                eighthdr.Close();
            }
            //view8

            //view9
            SqlCommand ninthdmd = new SqlCommand("select * from allTable where Id='" + 9 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            ninthdmd.Parameters.AddWithValue("@foodname", "shan food");
            SqlDataReader ninthdr = ninthdmd.ExecuteReader();

            if (ninthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview9Image.ImageUrl = ninthdr["image"].ToString();
                lblbtnview9Foodname.Text = ninthdr["Foodname"].ToString();
                lblbtnview9Price.Text = ninthdr["Price"].ToString();
                lblbtnview9Description.Text = ninthdr["Description"].ToString();
                lblbtnview9Shopname.Text = ninthdr["Shopname"].ToString();
                ninthdr.Close();
            }
            else
            {
                lblbtnview9.Visible = false;
                ninthdr.Close();
            }
            //view9

            //view10
            SqlCommand tenthdmd = new SqlCommand("select * from allTable where Id='" + 10 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            tenthdmd.Parameters.AddWithValue("@foodname", "shan food");
            SqlDataReader tenthdr = tenthdmd.ExecuteReader();

            if (tenthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview10Image.ImageUrl = tenthdr["image"].ToString();
                lblbtnview10Foodname.Text = tenthdr["Foodname"].ToString();
                lblbtnview10Price.Text = tenthdr["Price"].ToString();
                lblbtnview10Description.Text = tenthdr["Description"].ToString();
                lblbtnview10Shopname.Text = tenthdr["Shopname"].ToString();
                tenthdr.Close();
            }
            else
            {
                lblbtnview10.Visible = false;
                tenthdr.Close();
            }
            //view10


        }

        protected void btnthai_Click(object sender, EventArgs e)
        {

            conn.Open();
            string a = lblkorean.Text;
            SqlCommand cmd = new SqlCommand("select * from allTable where Id='" + 1 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            cmd.Parameters.AddWithValue("@foodname", "thai food");
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image3.ImageUrl = rdr["image"].ToString();
                lblex1.Text = rdr["Foodname"].ToString();
                lblex2.Text = rdr["Price"].ToString();
                lblex3.Text = rdr["Shopname"].ToString();
                lblex4.Text = rdr["Description"].ToString();
                rdr.Close();
            }
            else
            {
                lblbtnview1.Visible = false;
                rdr.Close();
            }


            SqlCommand amd = new SqlCommand("select * from allTable where Id='" + 2 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            amd.Parameters.AddWithValue("@foodname", "thai food");
            SqlDataReader rd = amd.ExecuteReader();

            if (rd.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image4.ImageUrl = rd["image"].ToString();
                lblee1.Text = rd["Foodname"].ToString();
                lblee2.Text = rd["Price"].ToString();
                lblee3.Text = rd["Shopname"].ToString();
                lblee4.Text = rd["Description"].ToString();
                rd.Close();
            }
            else
            {
                lblbtnview2.Visible = false;
                rd.Close();
            }

            SqlCommand dmd = new SqlCommand("select * from allTable where Id='" + 3 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            dmd.Parameters.AddWithValue("@foodname", "thai food");
            SqlDataReader dr = dmd.ExecuteReader();

            if (dr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image6.ImageUrl = dr["image"].ToString();
                lblss1.Text = dr["Foodname"].ToString();
                lblss2.Text = dr["Price"].ToString();
                lblss3.Text = dr["Shopname"].ToString();
                lblss4.Text = dr["Description"].ToString();
                dr.Close();
            }
            else
            {
                lblbtnview3.Visible = false;
                dr.Close();
            }

            SqlCommand fourthdmd = new SqlCommand("select * from allTable where Id='" + 4 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            fourthdmd.Parameters.AddWithValue("@foodname", "thai food");
            SqlDataReader fourthdr = fourthdmd.ExecuteReader();

            if (fourthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview4Image.ImageUrl = fourthdr["image"].ToString();
                lblbtnview4Foodname.Text = fourthdr["Foodname"].ToString();
                lblbtnview4Price.Text = fourthdr["Price"].ToString();
                lblbtnview4Description.Text = fourthdr["Description"].ToString();
                lblbtnview4Shopname.Text = fourthdr["Shopname"].ToString();
                fourthdr.Close();
            }
            else
            {
                lblbtnview4.Visible = false;
                fourthdr.Close();
            }

            //view5
            SqlCommand fifthdmd = new SqlCommand("select * from allTable where Id='" + 5 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            fifthdmd.Parameters.AddWithValue("@foodname", "thai food");
            SqlDataReader fifthdr = fifthdmd.ExecuteReader();

            if (fifthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview5Image.ImageUrl = fifthdr["image"].ToString();
                lblbtnview5Foodname.Text = fifthdr["Foodname"].ToString();
                lblbtnview5Price.Text = fifthdr["Price"].ToString();
                lblbtnview5Description.Text = fifthdr["Description"].ToString();
                lblbtnview5Shopname.Text = fifthdr["Shopname"].ToString();
                fifthdr.Close();
            }
            else
            {
                lblbtnview5.Visible = false;
                fifthdr.Close();
            }
            //view5

            //view6
            SqlCommand sixthdmd = new SqlCommand("select * from allTable where Id='" + 6 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            sixthdmd.Parameters.AddWithValue("@foodname", "thai food");
            SqlDataReader sixthdr = sixthdmd.ExecuteReader();

            if (sixthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview6Image.ImageUrl = sixthdr["image"].ToString();
                lblbtnview6Foodname.Text = sixthdr["Foodname"].ToString();
                lblbtnview6Price.Text = sixthdr["Price"].ToString();
                lblbtnview6Description.Text = sixthdr["Description"].ToString();
                lblbtnview6Shopname.Text = sixthdr["Shopname"].ToString();
                sixthdr.Close();
            }
            else
            {
                lblbtnview6.Visible = false;
                sixthdr.Close();
            }
            //view6

            //view7
            SqlCommand seventhdmd = new SqlCommand("select * from allTable where Id='" + 7 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            seventhdmd.Parameters.AddWithValue("@foodname", "thai food");
            SqlDataReader seventhdr = seventhdmd.ExecuteReader();

            if (seventhdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview7Image.ImageUrl = seventhdr["image"].ToString();
                lblbtnview7Foodname.Text = seventhdr["Foodname"].ToString();
                lblbtnview7Price.Text = seventhdr["Price"].ToString();
                lblbtnview7Description.Text = seventhdr["Description"].ToString();
                lblbtnview7Shopname.Text = seventhdr["Shopname"].ToString();
                seventhdr.Close();
            }
            else
            {
                lblbtnview7.Visible = false;
                seventhdr.Close();
            }
            //view7

            //view8
            SqlCommand eighthdmd = new SqlCommand("select * from allTable where Id='" + 8 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            eighthdmd.Parameters.AddWithValue("@foodname", "thai food");
            SqlDataReader eighthdr = eighthdmd.ExecuteReader();

            if (eighthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview8Image.ImageUrl = eighthdr["image"].ToString();
                lblbtnview8Foodname.Text = eighthdr["Foodname"].ToString();
                lblbtnview8Price.Text = eighthdr["Price"].ToString();
                lblbtnview8Description.Text = eighthdr["Description"].ToString();
                lblbtnview8Shopname.Text = eighthdr["Shopname"].ToString();
                eighthdr.Close();
            }
            else
            {
                lblbtnview8.Visible = false;
                eighthdr.Close();
            }
            //view8

            //view9
            SqlCommand ninthdmd = new SqlCommand("select * from allTable where Id='" + 9 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            ninthdmd.Parameters.AddWithValue("@foodname", "thai food");
            SqlDataReader ninthdr = ninthdmd.ExecuteReader();

            if (ninthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview9Image.ImageUrl = ninthdr["image"].ToString();
                lblbtnview9Foodname.Text = ninthdr["Foodname"].ToString();
                lblbtnview9Price.Text = ninthdr["Price"].ToString();
                lblbtnview9Description.Text = ninthdr["Description"].ToString();
                lblbtnview9Shopname.Text = ninthdr["Shopname"].ToString();
                ninthdr.Close();
            }
            else
            {
                lblbtnview9.Visible = false;
                ninthdr.Close();
            }
            //view9

            //view10
            SqlCommand tenthdmd = new SqlCommand("select * from allTable where Id='" + 10 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            tenthdmd.Parameters.AddWithValue("@foodname", "thai food");
            SqlDataReader tenthdr = tenthdmd.ExecuteReader();

            if (tenthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview10Image.ImageUrl = tenthdr["image"].ToString();
                lblbtnview10Foodname.Text = tenthdr["Foodname"].ToString();
                lblbtnview10Price.Text = tenthdr["Price"].ToString();
                lblbtnview10Description.Text = tenthdr["Description"].ToString();
                lblbtnview10Shopname.Text = tenthdr["Shopname"].ToString();
                tenthdr.Close();
            }
            else
            {
                lblbtnview10.Visible = false;
                tenthdr.Close();
            }
            //view10


        }

        protected void btnjuice_Click(object sender, EventArgs e)
        {

            conn.Open();
            string a = lblkorean.Text;
            SqlCommand cmd = new SqlCommand("select * from allTable where Id='" + 1 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            cmd.Parameters.AddWithValue("@foodname", "juice");
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image3.ImageUrl = rdr["image"].ToString();
                lblex1.Text = rdr["Foodname"].ToString();
                lblex2.Text = rdr["Price"].ToString();
                lblex3.Text = rdr["Shopname"].ToString();
                lblex4.Text = rdr["Description"].ToString();
                rdr.Close();
            }
            else
            {
                lblbtnview1.Visible = false;
                rdr.Close();
            }


            SqlCommand amd = new SqlCommand("select * from allTable where Id='" + 2 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            amd.Parameters.AddWithValue("@foodname", "juice");
            SqlDataReader rd = amd.ExecuteReader();

            if (rd.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image4.ImageUrl = rd["image"].ToString();
                lblee1.Text = rd["Foodname"].ToString();
                lblee2.Text = rd["Price"].ToString();
                lblee3.Text = rd["Shopname"].ToString();
                lblee4.Text = rd["Description"].ToString();
                rd.Close();
            }
            else
            {
                lblbtnview2.Visible = false;
                rd.Close();
            }

            SqlCommand dmd = new SqlCommand("select * from allTable where Id='" + 3 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            dmd.Parameters.AddWithValue("@foodname", "juice");
            SqlDataReader dr = dmd.ExecuteReader();

            if (dr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image6.ImageUrl = dr["image"].ToString();
                lblss1.Text = dr["Foodname"].ToString();
                lblss2.Text = dr["Price"].ToString();
                lblss3.Text = dr["Shopname"].ToString();
                lblss4.Text = dr["Description"].ToString();
                dr.Close();
            }
            else
            {
                lblbtnview3.Visible = false;
                dr.Close();
            }

            SqlCommand fourthdmd = new SqlCommand("select * from allTable where Id='" + 4 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            fourthdmd.Parameters.AddWithValue("@foodname", "juice");
            SqlDataReader fourthdr = fourthdmd.ExecuteReader();

            if (fourthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview4Image.ImageUrl = fourthdr["image"].ToString();
                lblbtnview4Foodname.Text = fourthdr["Foodname"].ToString();
                lblbtnview4Price.Text = fourthdr["Price"].ToString();
                lblbtnview4Description.Text = fourthdr["Description"].ToString();
                lblbtnview4Shopname.Text = fourthdr["Shopname"].ToString();
                fourthdr.Close();
            }
            else
            {
                lblbtnview4.Visible = false;
                fourthdr.Close();
            }

            //view5
            SqlCommand fifthdmd = new SqlCommand("select * from allTable where Id='" + 5 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            fifthdmd.Parameters.AddWithValue("@foodname", "juice");
            SqlDataReader fifthdr = fifthdmd.ExecuteReader();

            if (fifthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview5Image.ImageUrl = fifthdr["image"].ToString();
                lblbtnview5Foodname.Text = fifthdr["Foodname"].ToString();
                lblbtnview5Price.Text = fifthdr["Price"].ToString();
                lblbtnview5Description.Text = fifthdr["Description"].ToString();
                lblbtnview5Shopname.Text = fifthdr["Shopname"].ToString();
                fifthdr.Close();
            }
            else
            {
                lblbtnview5.Visible = false;
                fifthdr.Close();
            }
            //view5

            //view6
            SqlCommand sixthdmd = new SqlCommand("select * from allTable where Id='" + 6 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            sixthdmd.Parameters.AddWithValue("@foodname", "juice");
            SqlDataReader sixthdr = sixthdmd.ExecuteReader();

            if (sixthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview6Image.ImageUrl = sixthdr["image"].ToString();
                lblbtnview6Foodname.Text = sixthdr["Foodname"].ToString();
                lblbtnview6Price.Text = sixthdr["Price"].ToString();
                lblbtnview6Description.Text = sixthdr["Description"].ToString();
                lblbtnview6Shopname.Text = sixthdr["Shopname"].ToString();
                sixthdr.Close();
            }
            else
            {
                lblbtnview6.Visible = false;
                sixthdr.Close();
            }
            //view6

            //view7
            SqlCommand seventhdmd = new SqlCommand("select * from allTable where Id='" + 7 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            seventhdmd.Parameters.AddWithValue("@foodname", "juice");
            SqlDataReader seventhdr = seventhdmd.ExecuteReader();

            if (seventhdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview7Image.ImageUrl = seventhdr["image"].ToString();
                lblbtnview7Foodname.Text = seventhdr["Foodname"].ToString();
                lblbtnview7Price.Text = seventhdr["Price"].ToString();
                lblbtnview7Description.Text = seventhdr["Description"].ToString();
                lblbtnview7Shopname.Text = seventhdr["Shopname"].ToString();
                seventhdr.Close();
            }
            else
            {
                lblbtnview7.Visible = false;
                seventhdr.Close();
            }
            //view7

            //view8
            SqlCommand eighthdmd = new SqlCommand("select * from allTable where Id='" + 8 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            eighthdmd.Parameters.AddWithValue("@foodname", "juice");
            SqlDataReader eighthdr = eighthdmd.ExecuteReader();

            if (eighthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview8Image.ImageUrl = eighthdr["image"].ToString();
                lblbtnview8Foodname.Text = eighthdr["Foodname"].ToString();
                lblbtnview8Price.Text = eighthdr["Price"].ToString();
                lblbtnview8Description.Text = eighthdr["Description"].ToString();
                lblbtnview8Shopname.Text = eighthdr["Shopname"].ToString();
                eighthdr.Close();
            }
            else
            {
                lblbtnview8.Visible = false;
                eighthdr.Close();
            }
            //view8

            //view9
            SqlCommand ninthdmd = new SqlCommand("select * from allTable where Id='" + 9 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            ninthdmd.Parameters.AddWithValue("@foodname", "juice");
            SqlDataReader ninthdr = ninthdmd.ExecuteReader();

            if (ninthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview9Image.ImageUrl = ninthdr["image"].ToString();
                lblbtnview9Foodname.Text = ninthdr["Foodname"].ToString();
                lblbtnview9Price.Text = ninthdr["Price"].ToString();
                lblbtnview9Description.Text = ninthdr["Description"].ToString();
                lblbtnview9Shopname.Text = ninthdr["Shopname"].ToString();
                ninthdr.Close();
            }
            else
            {
                lblbtnview9.Visible = false;
                ninthdr.Close();
            }
            //view9

            //view10
            SqlCommand tenthdmd = new SqlCommand("select * from allTable where Id='" + 10 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            tenthdmd.Parameters.AddWithValue("@foodname", "juice");
            SqlDataReader tenthdr = tenthdmd.ExecuteReader();

            if (tenthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview10Image.ImageUrl = tenthdr["image"].ToString();
                lblbtnview10Foodname.Text = tenthdr["Foodname"].ToString();
                lblbtnview10Price.Text = tenthdr["Price"].ToString();
                lblbtnview10Description.Text = tenthdr["Description"].ToString();
                lblbtnview10Shopname.Text = tenthdr["Shopname"].ToString();
                tenthdr.Close();
            }
            else
            {
                lblbtnview10.Visible = false;
                tenthdr.Close();
            }
            //view10


        }

        protected void btnsalad_Click(object sender, EventArgs e)
        {

            conn.Open();
            string a = lblkorean.Text;
            SqlCommand cmd = new SqlCommand("select * from allTable where Id='" + 1 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            cmd.Parameters.AddWithValue("@foodname", "salad");
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image3.ImageUrl = rdr["image"].ToString();
                lblex1.Text = rdr["Foodname"].ToString();
                lblex2.Text = rdr["Price"].ToString();
                lblex3.Text = rdr["Shopname"].ToString();
                lblex4.Text = rdr["Description"].ToString();
                rdr.Close();
            }
            else
            {
                lblbtnview1.Visible = false;
                rdr.Close();
            }


            SqlCommand amd = new SqlCommand("select * from allTable where Id='" + 2 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            amd.Parameters.AddWithValue("@foodname", "salad");
            SqlDataReader rd = amd.ExecuteReader();

            if (rd.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image4.ImageUrl = rd["image"].ToString();
                lblee1.Text = rd["Foodname"].ToString();
                lblee2.Text = rd["Price"].ToString();
                lblee3.Text = rd["Shopname"].ToString();
                lblee4.Text = rd["Description"].ToString();
                rd.Close();
            }
            else
            {
                lblbtnview2.Visible = false;
                rd.Close();
            }

            SqlCommand dmd = new SqlCommand("select * from allTable where Id='" + 3 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            dmd.Parameters.AddWithValue("@foodname", "salad");
            SqlDataReader dr = dmd.ExecuteReader();

            if (dr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image6.ImageUrl = dr["image"].ToString();
                lblss1.Text = dr["Foodname"].ToString();
                lblss2.Text = dr["Price"].ToString();
                lblss3.Text = dr["Shopname"].ToString();
                lblss4.Text = dr["Description"].ToString();
                dr.Close();
            }
            else
            {
                lblbtnview3.Visible = false;
                dr.Close();
            }

            SqlCommand fourthdmd = new SqlCommand("select * from allTable where Id='" + 4 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            fourthdmd.Parameters.AddWithValue("@foodname", "salad");
            SqlDataReader fourthdr = fourthdmd.ExecuteReader();

            if (fourthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview4Image.ImageUrl = fourthdr["image"].ToString();
                lblbtnview4Foodname.Text = fourthdr["Foodname"].ToString();
                lblbtnview4Price.Text = fourthdr["Price"].ToString();
                lblbtnview4Description.Text = fourthdr["Description"].ToString();
                lblbtnview4Shopname.Text = fourthdr["Shopname"].ToString();
                fourthdr.Close();
            }
            else
            {
                lblbtnview4.Visible = false;
                fourthdr.Close();
            }

            //view5
            SqlCommand fifthdmd = new SqlCommand("select * from allTable where Id='" + 5 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            fifthdmd.Parameters.AddWithValue("@foodname", "salad");
            SqlDataReader fifthdr = fifthdmd.ExecuteReader();

            if (fifthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview5Image.ImageUrl = fifthdr["image"].ToString();
                lblbtnview5Foodname.Text = fifthdr["Foodname"].ToString();
                lblbtnview5Price.Text = fifthdr["Price"].ToString();
                lblbtnview5Description.Text = fifthdr["Description"].ToString();
                lblbtnview5Shopname.Text = fifthdr["Shopname"].ToString();
                fifthdr.Close();
            }
            else
            {
                lblbtnview5.Visible = false;
                fifthdr.Close();
            }
            //view5

            //view6
            SqlCommand sixthdmd = new SqlCommand("select * from allTable where Id='" + 6 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            sixthdmd.Parameters.AddWithValue("@foodname", "salad");
            SqlDataReader sixthdr = sixthdmd.ExecuteReader();

            if (sixthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview6Image.ImageUrl = sixthdr["image"].ToString();
                lblbtnview6Foodname.Text = sixthdr["Foodname"].ToString();
                lblbtnview6Price.Text = sixthdr["Price"].ToString();
                lblbtnview6Description.Text = sixthdr["Description"].ToString();
                lblbtnview6Shopname.Text = sixthdr["Shopname"].ToString();
                sixthdr.Close();
            }
            else
            {
                lblbtnview6.Visible = false;
                sixthdr.Close();
            }
            //view6

            //view7
            SqlCommand seventhdmd = new SqlCommand("select * from allTable where Id='" + 7 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            seventhdmd.Parameters.AddWithValue("@foodname", "salad");
            SqlDataReader seventhdr = seventhdmd.ExecuteReader();

            if (seventhdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview7Image.ImageUrl = seventhdr["image"].ToString();
                lblbtnview7Foodname.Text = seventhdr["Foodname"].ToString();
                lblbtnview7Price.Text = seventhdr["Price"].ToString();
                lblbtnview7Description.Text = seventhdr["Description"].ToString();
                lblbtnview7Shopname.Text = seventhdr["Shopname"].ToString();
                seventhdr.Close();
            }
            else
            {
                lblbtnview7.Visible = false;
                seventhdr.Close();
            }
            //view7

            //view8
            SqlCommand eighthdmd = new SqlCommand("select * from allTable where Id='" + 8 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            eighthdmd.Parameters.AddWithValue("@foodname", "salad");
            SqlDataReader eighthdr = eighthdmd.ExecuteReader();

            if (eighthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview8Image.ImageUrl = eighthdr["image"].ToString();
                lblbtnview8Foodname.Text = eighthdr["Foodname"].ToString();
                lblbtnview8Price.Text = eighthdr["Price"].ToString();
                lblbtnview8Description.Text = eighthdr["Description"].ToString();
                lblbtnview8Shopname.Text = eighthdr["Shopname"].ToString();
                eighthdr.Close();
            }
            else
            {
                lblbtnview8.Visible = false;
                eighthdr.Close();
            }
            //view8

            //view9
            SqlCommand ninthdmd = new SqlCommand("select * from allTable where Id='" + 9 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            ninthdmd.Parameters.AddWithValue("@foodname", "salad");
            SqlDataReader ninthdr = ninthdmd.ExecuteReader();

            if (ninthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview9Image.ImageUrl = ninthdr["image"].ToString();
                lblbtnview9Foodname.Text = ninthdr["Foodname"].ToString();
                lblbtnview9Price.Text = ninthdr["Price"].ToString();
                lblbtnview9Description.Text = ninthdr["Description"].ToString();
                lblbtnview9Shopname.Text = ninthdr["Shopname"].ToString();
                ninthdr.Close();
            }
            else
            {
                lblbtnview9.Visible = false;
                ninthdr.Close();
            }
            //view9

            //view10
            SqlCommand tenthdmd = new SqlCommand("select * from allTable where Id='" + 10 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            tenthdmd.Parameters.AddWithValue("@foodname", "salad");
            SqlDataReader tenthdr = tenthdmd.ExecuteReader();

            if (tenthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview10Image.ImageUrl = tenthdr["image"].ToString();
                lblbtnview10Foodname.Text = tenthdr["Foodname"].ToString();
                lblbtnview10Price.Text = tenthdr["Price"].ToString();
                lblbtnview10Description.Text = tenthdr["Description"].ToString();
                lblbtnview10Shopname.Text = tenthdr["Shopname"].ToString();
                tenthdr.Close();
            }
            else
            {
                lblbtnview10.Visible = false;
                tenthdr.Close();
            }
            //view10


        }

        protected void btnother_Click(object sender, EventArgs e)
        {

            conn.Open();
            string a = lblkorean.Text;
            SqlCommand cmd = new SqlCommand("select * from allTable where Id='" + 1 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            cmd.Parameters.AddWithValue("@foodname", "other");
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image3.ImageUrl = rdr["image"].ToString();
                lblex1.Text = rdr["Foodname"].ToString();
                lblex2.Text = rdr["Price"].ToString();
                lblex3.Text = rdr["Shopname"].ToString();
                lblex4.Text = rdr["Description"].ToString();
                rdr.Close();
            }
            else
            {
                lblbtnview1.Visible = false;
                rdr.Close();
            }


            SqlCommand amd = new SqlCommand("select * from allTable where Id='" + 2 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            amd.Parameters.AddWithValue("@foodname", "other");
            SqlDataReader rd = amd.ExecuteReader();

            if (rd.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image4.ImageUrl = rd["image"].ToString();
                lblee1.Text = rd["Foodname"].ToString();
                lblee2.Text = rd["Price"].ToString();
                lblee3.Text = rd["Shopname"].ToString();
                lblee4.Text = rd["Description"].ToString();
                rd.Close();
            }
            else
            {
                lblbtnview2.Visible = false;
                rd.Close();
            }

            SqlCommand dmd = new SqlCommand("select * from allTable where Id='" + 3 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            dmd.Parameters.AddWithValue("@foodname", "other");
            SqlDataReader dr = dmd.ExecuteReader();

            if (dr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;


                image6.ImageUrl = dr["image"].ToString();
                lblss1.Text = dr["Foodname"].ToString();
                lblss2.Text = dr["Price"].ToString();
                lblss3.Text = dr["Shopname"].ToString();
                lblss4.Text = dr["Description"].ToString();
                dr.Close();
            }
            else
            {
                lblbtnview3.Visible = false;
                dr.Close();
            }

            SqlCommand fourthdmd = new SqlCommand("select * from allTable where Id='" + 4 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            fourthdmd.Parameters.AddWithValue("@foodname", "other");
            SqlDataReader fourthdr = fourthdmd.ExecuteReader();

            if (fourthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview4Image.ImageUrl = fourthdr["image"].ToString();
                lblbtnview4Foodname.Text = fourthdr["Foodname"].ToString();
                lblbtnview4Price.Text = fourthdr["Price"].ToString();
                lblbtnview4Description.Text = fourthdr["Description"].ToString();
                lblbtnview4Shopname.Text = fourthdr["Shopname"].ToString();
                fourthdr.Close();
            }
            else
            {
                lblbtnview4.Visible = false;
                fourthdr.Close();
            }

            //view5
            SqlCommand fifthdmd = new SqlCommand("select * from allTable where Id='" + 5 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            fifthdmd.Parameters.AddWithValue("@foodname", "other");
            SqlDataReader fifthdr = fifthdmd.ExecuteReader();

            if (fifthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview5Image.ImageUrl = fifthdr["image"].ToString();
                lblbtnview5Foodname.Text = fifthdr["Foodname"].ToString();
                lblbtnview5Price.Text = fifthdr["Price"].ToString();
                lblbtnview5Description.Text = fifthdr["Description"].ToString();
                lblbtnview5Shopname.Text = fifthdr["Shopname"].ToString();
                fifthdr.Close();
            }
            else
            {
                lblbtnview5.Visible = false;
                fifthdr.Close();
            }
            //view5

            //view6
            SqlCommand sixthdmd = new SqlCommand("select * from allTable where Id='" + 6 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            sixthdmd.Parameters.AddWithValue("@foodname", "other");
            SqlDataReader sixthdr = sixthdmd.ExecuteReader();

            if (sixthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview6Image.ImageUrl = sixthdr["image"].ToString();
                lblbtnview6Foodname.Text = sixthdr["Foodname"].ToString();
                lblbtnview6Price.Text = sixthdr["Price"].ToString();
                lblbtnview6Description.Text = sixthdr["Description"].ToString();
                lblbtnview6Shopname.Text = sixthdr["Shopname"].ToString();
                sixthdr.Close();
            }
            else
            {
                lblbtnview6.Visible = false;
                sixthdr.Close();
            }
            //view6

            //view7
            SqlCommand seventhdmd = new SqlCommand("select * from allTable where Id='" + 7 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            seventhdmd.Parameters.AddWithValue("@foodname", "other");
            SqlDataReader seventhdr = seventhdmd.ExecuteReader();

            if (seventhdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview7Image.ImageUrl = seventhdr["image"].ToString();
                lblbtnview7Foodname.Text = seventhdr["Foodname"].ToString();
                lblbtnview7Price.Text = seventhdr["Price"].ToString();
                lblbtnview7Description.Text = seventhdr["Description"].ToString();
                lblbtnview7Shopname.Text = seventhdr["Shopname"].ToString();
                seventhdr.Close();
            }
            else
            {
                lblbtnview7.Visible = false;
                seventhdr.Close();
            }
            //view7

            //view8
            SqlCommand eighthdmd = new SqlCommand("select * from allTable where Id='" + 8 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            eighthdmd.Parameters.AddWithValue("@foodname", "other");
            SqlDataReader eighthdr = eighthdmd.ExecuteReader();

            if (eighthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview8Image.ImageUrl = eighthdr["image"].ToString();
                lblbtnview8Foodname.Text = eighthdr["Foodname"].ToString();
                lblbtnview8Price.Text = eighthdr["Price"].ToString();
                lblbtnview8Description.Text = eighthdr["Description"].ToString();
                lblbtnview8Shopname.Text = eighthdr["Shopname"].ToString();
                eighthdr.Close();
            }
            else
            {
                lblbtnview8.Visible = false;
                eighthdr.Close();
            }
            //view8

            //view9
            SqlCommand ninthdmd = new SqlCommand("select * from allTable where Id='" + 9 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            ninthdmd.Parameters.AddWithValue("@foodname", "other");
            SqlDataReader ninthdr = ninthdmd.ExecuteReader();

            if (ninthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview9Image.ImageUrl = ninthdr["image"].ToString();
                lblbtnview9Foodname.Text = ninthdr["Foodname"].ToString();
                lblbtnview9Price.Text = ninthdr["Price"].ToString();
                lblbtnview9Description.Text = ninthdr["Description"].ToString();
                lblbtnview9Shopname.Text = ninthdr["Shopname"].ToString();
                ninthdr.Close();
            }
            else
            {
                lblbtnview9.Visible = false;
                ninthdr.Close();
            }
            //view9

            //view10
            SqlCommand tenthdmd = new SqlCommand("select * from allTable where Id='" + 10 + "' and (Typeoffood like '%'+@foodname+'%')", conn);
            tenthdmd.Parameters.AddWithValue("@foodname", "other");
            SqlDataReader tenthdr = tenthdmd.ExecuteReader();

            if (tenthdr.Read())
            {
                lblFirst.Visible = false;
                lblSecond.Visible = false;
                lblThird.Visible = false;
                lblFourth.Visible = false;
                lblSecondFirst.Visible = false;
                lblSecondSecond.Visible = false;
                lblSecondThird.Visible = false;
                Label2.Visible = true;

                lblbtnview10Image.ImageUrl = tenthdr["image"].ToString();
                lblbtnview10Foodname.Text = tenthdr["Foodname"].ToString();
                lblbtnview10Price.Text = tenthdr["Price"].ToString();
                lblbtnview10Description.Text = tenthdr["Description"].ToString();
                lblbtnview10Shopname.Text = tenthdr["Shopname"].ToString();
                tenthdr.Close();
            }
            else
            {
                lblbtnview10.Visible = false;
                tenthdr.Close();
            }
            //view10


        }
        
       
    }
}

            

    

    














        
    
