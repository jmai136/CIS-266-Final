﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Listing
    {
        public int listingID { get; set; }
        public int sellerID { get; set; }
        /*public int buyerID {get; set;}
        public string buyerFirstName { get; set; }
        public string buyerLastName {get; set; }*/
        public string carVIN { get; set; }
        // should have the properties for Car and the DateTime of the creation of the listing
        // Grab subclass of car?
        public string description { get; set; }
        public DateTime creationDateTime { get; set; }
    }
}
