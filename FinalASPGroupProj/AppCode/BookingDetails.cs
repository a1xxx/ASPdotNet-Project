//File created by Mike Rabatich Jan 2017
//defines the values of the bookingdetails objects

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
        public class BookingDetails
        {

            public int CustomerId { get; set; }

            public int BookingDetailId { get; set; }

            public string Destination { get; set;  }

         

            public string BasePrice { get; set; }

            public int BookingId { get; set; }

           // public DateTime TripStart { get; set; }

//            public DateTime TripEnd { get; set; }

            public string Start { get; set; }    
            public string End { get; set; }



    }
}