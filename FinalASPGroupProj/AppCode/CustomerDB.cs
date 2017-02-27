//created by Mike Rabatich Jan 2017
//gets values for customers from travel experts db

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace FinalASPGroupProj.AppCode
{
    public class CustomerDB
   {
        public static bool Registercustomer(Customer cst) // returns generated customer id
        {
            bool reg = false;
            SqlConnection connection = TravelExpertsDB.GetConnection();

            // prepare the statement
            string insertString = "insert into Customers " +
                                  "(CustFirstName, CustLastName, CustPassword, CustAddress, CustCity, CustProv, CustPostal, Custcountry, CustHomePhone, CustBusPhone, CustEmail, CustAbout ) " +
                                  "values(@CustFirstName, @CustLastName, @CustPassword, @CustAddress, @CustCity, @CustProv, @CustPostal, @Custcountry, @CustHomePhone, @CustBusPhone, @CustEmail, @CustAbout )";
            SqlCommand insertCommand = new SqlCommand(insertString, connection);
            // insertCommand.Parameters.AddWithValue("@PackageId", pkg.PackageId);
      
            insertCommand.Parameters.AddWithValue("@CustFirstName", cst.CustFirstName);
            insertCommand.Parameters.AddWithValue("@CustLastName", cst.CustLastName);
            insertCommand.Parameters.AddWithValue("@CustPassword", cst.CustPassword);
          //  insertCommand.Parameters.AddWithValue("@CustGender", cst.CustGender);
            insertCommand.Parameters.AddWithValue("@CustAddress", cst.CustAddress);
         //   insertCommand.Parameters.AddWithValue("@custAddress1", cst.custAddress1);
            insertCommand.Parameters.AddWithValue("@CustCity", cst.CustCity);
            insertCommand.Parameters.AddWithValue("@CustProv", cst.CustProv);
            insertCommand.Parameters.AddWithValue("@CustPostal", cst.CustPostal);
            insertCommand.Parameters.AddWithValue("@Custcountry", cst.Custcountry);
            insertCommand.Parameters.AddWithValue("@CustBusPhone", cst.CustBusPhone);
            insertCommand.Parameters.AddWithValue("@CustHomePhone", cst.CustHomePhone);
            insertCommand.Parameters.AddWithValue("@CustEmail", cst.CustEmail);
            insertCommand.Parameters.AddWithValue("@CustAbout", cst.CustAbout);
          


            try
            {
                // open connection
                connection.Open();

                // execute the statement
                int i = insertCommand.ExecuteNonQuery();
                if (i == 1) // one record inserted
                {
                    // retrieve customer id from the added record
                    //    string selectString = "select @PackageId " +
                    //                           "from packages";
                    //    SqlCommand selectCommand = new SqlCommand(selectString, connection);
                    //    PackageId = Convert.ToInt32(selectCommand.ExecuteScalar()); // (int) does not work!!!
                }
                reg = true;

            }
            catch (Exception ex)
            {
                throw ex; // pass the buck
            }
            finally
            {
                connection.Close();
            }



            return reg;
        }

       
       
        public static Customer getCustomer(int CustomerID)
        {

            // reference to new (null) order object
            Customer cust = new Customer();

            //create connection to Northwinds database
           SqlConnection connection = TravelExpertsDB.GetConnection();

            // create select command that pulls specific values from Orders table for 1 Order
            string selectQuery = "select * " +
                                 "from Customers " +
                                 "where CustomerID = @CustomerID";

            //Represents a stored procedure to execute against a SQL Server database
            //info from website:   msdn.microsoft.com/en-us/library/system.data.sqlclient.sqlcommand(v=vs.110).aspx
            SqlCommand selectCommand = new SqlCommand(selectQuery, connection);

            //use the store procedure to select the order using the parameter OrderID passed from the main form
            selectCommand.Parameters.AddWithValue("@CustomerID", CustomerID);

            try
            {
                // open connection
                connection.Open();

                //DataReader provides a way of reading a forward-only stream of rows from a SQL Server database
                //Info from msdn.microsoft.com/en-us/library/system.data.sqlclient.sqldatareader(v=vs.110).aspx
                SqlDataReader reader = selectCommand.ExecuteReader();


                //this if statements processes one row at a time
                if (reader.Read())
                {

                    //each row is a new object during importing
                    //    cst = new Customer();
                   // Customer cust;
                    //define the OrderID and CustomerID of thew new object by using the reader
                    cust.CustomerID = CustomerID;
        

                   
                    cust.CustFirstName = (string)reader["CustFirstName"];
                    cust.CustLastName = (string) reader["CustLastName"];
                    cust.CustPassword = (string) reader["CustPassword"];
                    //public string CustGender { get; set; }
                     cust.CustAddress = (string) reader["CustAddress"];
            // public string custAddress1 { get; set; }
                    cust.CustCity = (string) reader["CustCity"];
                    cust.CustProv = (string) reader["CustProv"];

                    cust.CustPostal = (string) reader["CustPostal"];
                    cust.Custcountry = (string) reader["CustCountry"];
                    cust.CustHomePhone = (string) reader["CustHomePhone"];
                 
                    if ((string) reader["CustEmail"] != null)
                    {
                        cust.CustEmail = (string) reader["CustEmail"];
                    }
            //        cust.CustAbout = (string) reader["CustAbout"];

                    //if not a null value define the ShippedDate of the new order object



                }

                //this catches the null exceptions on import
            }
            catch (Exception ex)
            {
                // throw exception to the form to handle
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            //if no exceptions return the imported order object
            return cust;
        }



        public static int getnewCustomer()
        {

            // reference to new (null) order object
            Customer cust = new Customer();

            //create connection to Northwinds database
            SqlConnection connection = TravelExpertsDB.GetConnection();

            // create select command that pulls specific values from Orders table for 1 Order
            string selectQuery = "SELECT CustomerID FROM Customers WHERE CustomerID = (SELECT MAX(CustomerID) FROM Customers)";

            //Represents a stored procedure to execute against a SQL Server database
            //info from website:   msdn.microsoft.com/en-us/library/system.data.sqlclient.sqlcommand(v=vs.110).aspx
            SqlCommand selectCommand = new SqlCommand(selectQuery, connection);

            //use the store procedure to select the order using the parameter OrderID passed from the main form
          //  selectCommand.Parameters.AddWithValue("@CustomerID", );

            try
            {
                // open connection
                connection.Open();

                //DataReader provides a way of reading a forward-only stream of rows from a SQL Server database
                //Info from msdn.microsoft.com/en-us/library/system.data.sqlclient.sqldatareader(v=vs.110).aspx
                SqlDataReader reader = selectCommand.ExecuteReader();


                //this if statements processes one row at a time
                if (reader.Read())
                {

                    //each row is a new object during importing
                    //    cst = new Customer();
                    // Customer cust;
                    //define the OrderID and CustomerID of thew new object by using the reader
                    cust.CustomerID = (int) reader["CustomerID"];
                    


                }

                //this catches the null exceptions on import
            }
            catch (Exception ex)
            {
                // throw exception to the form to handle
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            //if no exceptions return the imported order object
            return cust.CustomerID;
        }








        public static bool updateCustomer(Customer oldCustomer, Customer newCustomer)
       {
            bool successful = false;
            SqlConnection connection = TravelExpertsDB.GetConnection();

           string updateString = "update Customers set " +
                               //  "CustomerID = @newCustomerID, " +
                                 "CustFirstName = @newCustFirstName, " +
                                 "CustLastName = @newCustLastName, " +
                                 "CustPassword = @newCustPassword, " +
                                 "CustAddress = @newCustAddress, " +
                                 "CustCity = @newCustCity, " +
                                 "CustProv = @newCustProv, " +
                                 "CustPostal = @newCustPostal, " +
                                 "CustCountry = @newCustCountry, " +
                                 "CustHomePhone = @newCustHomePhone, " +
                                 "CustEmail = @newCustEmail " +
                                // "CustAbout = @newCustAbout " +
                                 "where " + // update succeeds only if record not changed by other users
                                 "CustomerID = @oldCustomerID and " +
                                 "CustFirstName = @oldCustFirstName and " +
                                 "CustLastName = @oldCustLastName and " +
                                 "CustPassword = @oldCustPassword and " +
                                 "CustAddress = @oldCustAddress and " +
                                 "CustCity = @oldCustCity and " +
                                 "CustProv = @oldCustProv and " +
                                 "CustPostal = @oldCustPostal and " +
                                 "CustCountry = @oldCustCountry and " +
                                 "CustHomePhone = @oldCustHomePhone and " +
                                 "CustEmail = @oldCustEmail ";
                            //     "CustAbout = @oldCustAbout ";

            SqlCommand updateCommand = new SqlCommand(updateString, connection);
            updateCommand.Parameters.AddWithValue("@oldCustomerID", oldCustomer.CustomerID);
            updateCommand.Parameters.AddWithValue("@oldCustFirstName", oldCustomer.CustFirstName);
            updateCommand.Parameters.AddWithValue("@oldCustLastName", oldCustomer.CustLastName);
            updateCommand.Parameters.AddWithValue("@oldCustPassword", oldCustomer.CustPassword);
            updateCommand.Parameters.AddWithValue("@oldCustAddress", oldCustomer.CustAddress);
            updateCommand.Parameters.AddWithValue("@oldCustCity", oldCustomer.CustCity);
            updateCommand.Parameters.AddWithValue("@oldCustProv", oldCustomer.CustProv);
            updateCommand.Parameters.AddWithValue("@oldCustPostal", oldCustomer.CustPostal);
            updateCommand.Parameters.AddWithValue("@oldCustCountry", oldCustomer.Custcountry);
            updateCommand.Parameters.AddWithValue("@oldCustHomePhone", oldCustomer.CustHomePhone);
            updateCommand.Parameters.AddWithValue("@oldCustEmail", oldCustomer.CustEmail);


            updateCommand.Parameters.AddWithValue("@newCustomerID", newCustomer.CustomerID);
            updateCommand.Parameters.AddWithValue("@newCustFirstName", newCustomer.CustFirstName);
            updateCommand.Parameters.AddWithValue("@newCustLastName", newCustomer.CustLastName);
            updateCommand.Parameters.AddWithValue("@newCustPassword", newCustomer.CustPassword);
            updateCommand.Parameters.AddWithValue("@newCustAddress", newCustomer.CustAddress);
            updateCommand.Parameters.AddWithValue("@newCustCity", newCustomer.CustCity);
            updateCommand.Parameters.AddWithValue("@newCustProv", newCustomer.CustProv);
            updateCommand.Parameters.AddWithValue("@newCustPostal", newCustomer.CustPostal);
            updateCommand.Parameters.AddWithValue("@newCustCountry", newCustomer.Custcountry);
            updateCommand.Parameters.AddWithValue("@newCustHomePhone", newCustomer.CustHomePhone);
            updateCommand.Parameters.AddWithValue("@newCustEmail", newCustomer.CustEmail);

            
            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count == 1)
                    successful = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return successful;




        }


}
    }
