//created by Mike Rabatich Jan 2017
//accesses database to get bookingdetails info

using FinalASPGroupProj.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FinalASPGroupProj.AppCode
{
    public class BookingDetailsDB
    {
        
            // Method created by Justin and Mike

            public static List<BookingDetails> bookingDetails(int custID)
            {

                //make empty list
                //List<int> bookingIds = new List<int>();
                List<BookingDetails> bookingdetails = new List<BookingDetails>();
                List<money> vacationCost= new List<money>();
                //create connection
                SqlConnection connection = TravelExpertsDB.GetConnection();

                //create selectcommand
                string selectString = "select CustomerId, BookingDetailId, Destination, TripStart, TripEnd, BasePrice, bd.BookingId from Bookings b, BookingDetails bd where b.BookingId=bd.BookingId and CustomerId = @CustomerId";
                SqlCommand selectCommand = new SqlCommand(selectString, connection);
                selectCommand.Parameters.AddWithValue("@CustomerId", custID);
                try
                {

                    connection.Open();

                    //run the selectCommand and process the results adding Bookings to the list
                    SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.Default);

                    //process one row at a time
                    while (reader.Read())
                    {
                       
                        BookingDetails Bkd = new BookingDetails();

                        Bkd.CustomerId = (int)reader["CustomerId"];
                        Bkd.BookingDetailId = (int)reader["BookingDetailID"];
                        Bkd.Destination = reader["Destination"].ToString();


                        DateTime tripEnd = (DateTime)reader["TripEnd"];
                        Bkd.End = tripEnd.ToString("d");

                         DateTime tripStart = (DateTime)reader["TripStart"];
                         Bkd.Start = tripStart.ToString("d");

                        decimal money = (decimal) reader["BasePrice"];
                        Bkd.BasePrice = money.ToString("C");

                   // Bkd.BasePrice = price.ToString("C");
                   Bkd.BookingId = (int)reader["BookingID"];

                        bookingdetails.Add(Bkd);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();

                }
                return bookingdetails;
            }


        public static List<money> getPrice(int custID)
        {

           //make empty list of decimal money values
          
            List<money> vacCost = new List<money>();
            //create connection
            SqlConnection connection = TravelExpertsDB.GetConnection();

            //create selectcommand
            string selectString = "select BasePrice, bd.BookingId from Bookings b, BookingDetails bd where b.BookingId = bd.BookingId and CustomerId = @CustomerId";
            SqlCommand selectCommand = new SqlCommand(selectString, connection);
            selectCommand.Parameters.AddWithValue("@CustomerId", custID);
            try
            {

                connection.Open();

                //run the selectCommand and process the results adding Bookings to the list
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.Default);

                //process one row at a time
                while (reader.Read())
                {
                   
                    money cost = new money();

                    cost.vacationCost = (decimal)reader["BasePrice"];
                    vacCost.Add(cost);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();

            }
            return vacCost;
        }





    }
        
    
}