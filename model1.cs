using System;
using System.Collections.Generic;
using System.Linq;
//we'll go through these later
using System.Threading.Tasks;
//this is our data model for the rsvp system

namespace WebApplication1.Models
{
    public class GuestResponse{
        //these are the user inputs, 3 strings and a boolean
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }
        //nullable bool- so it can be true, false, or null

    }
}