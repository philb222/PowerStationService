using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AdminPowerStations.APIs
{
    [ServiceContract]
    public interface IPowerService
    {
		//http://localhost:65094/APIs/PowerService.svc/Stations/All/0/0/0
		//[WebGet(UriTemplate = "/Stations/All/{hour}/{minute}/{second}")]
		[OperationContract]
		PowerUsage_AllStations_OneSecond ReportStationsAll(string hour, string minute, string second);

		//http://localhost:65094/APIs/PowerService.svc/Station/4/Hour/10
		//[WebGet(UriTemplate = "/Station/{stationNumber}/Hour/{Hour}")]
		[OperationContract]
		PowerUsage_OneStation_15Minutes ReportOneStation(string stationNumber, string hour, string minutes);
	}

	public class PowerUsage_AllStations_OneSecond
    {
		// Provided Inputs:
		public byte ReadingHour;
        public byte ReadingMinute;
        public byte ReadingSecond;

		// Outputs
		public string ErrorMessage;
		public decimal Station01PowerUsage;
        public decimal Station02PowerUsage;
        public decimal Station03PowerUsage;
        public decimal Station04PowerUsage;
        public decimal Station05PowerUsage;
        public decimal Station06PowerUsage;
        public decimal Station07PowerUsage;
        public decimal Station08PowerUsage;
        public decimal Station09PowerUsage;
        public decimal Station10PowerUsage;
    }

	public class PowerUsage_OneStation_15Minutes
	{
		// Provided Inputs:
		public byte StationNumber;
		public byte ReadingHour;
		public byte StartReadingMinute;

		// Outputs
		public string ErrorMessage;			// Null if OK
		public string StationName;
		public string StationLocation;
		public string StationPhone;
		public decimal[] PowerUsage;
	}

}
