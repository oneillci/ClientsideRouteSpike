using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientsideRouteSpike.Models
{
    public class ParkingPermit
    {
        public ParkingPermitType ParkingPermitType { get; set; }

        public bool AcceptsTerms { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string Number { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }


    }

    public enum ParkingPermitType
    {
        Residential,
        Business
    }
}