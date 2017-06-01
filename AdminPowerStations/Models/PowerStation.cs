using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminPowerStations.Models
{
    public class PowerStation
    {
        public string Name { get; set; }
        public string Location { get; set; }
		public string Phone { get; set; }
		public bool Online { get; set; }
    }
}