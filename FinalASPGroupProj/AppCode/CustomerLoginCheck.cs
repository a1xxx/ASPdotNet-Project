//created by Mike Rabatich Jan 2017
//checks to see if the customer login data was valid

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;


namespace FinalASPGroupProj.AppCode
{
    public partial class CustomerLoginCheck :System.Web.UI.Page
    {

        public static bool checkcustlogin(int CustomerID, string pass)
        {
            //by default returns not logged in logged value
            bool logged = true;

            //create connection            
            SqlConnection connection = TravelExpertsDB.GetConnection();

            // prepare the statement
            string PassString = "select CustomerID, CustPassword from Customers " +
                                 "where CustomerID = @CustomerID";

            //SqlCommand object that executes a select statement, page 641 Murach's C# 2015
          
            SqlCommand selectCommand = new SqlCommand(PassString, connection);
            selectCommand.Parameters.AddWithValue("@CustomerID", CustomerID);
            try
            {
                // open the connection
                connection.Open();

                // execute the query
                SqlDataReader reader = selectCommand.ExecuteReader();

                // process if Technician exists
                while (reader.Read())
                {

                    //define values of individual instance
                    Customer cust1 = new Customer();
                    cust1.CustPassword = (string)reader["CustPassword"];
                    cust1.CustomerID = (int)reader["CustomerID"];
                    if (cust1.CustPassword.Trim() == pass)
                    {
                        //loggedin = true;
                      //  Application["CustID"] = CustomerID;
                        logged = true;
                        return logged;

                    }
                    else
                    {
                        logged = false;
                        return logged;
                    }

                   
                }
                
            }

            catch (Exception ex)
            {
                throw ex;
               
            }

            finally
            {

                connection.Close();
            }
            return logged;


        }
    }
}