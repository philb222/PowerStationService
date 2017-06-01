using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AdminPowerStations.APIs
{
	/// <summary>
	/// Implement the IPowerService interface.
	/// </summary>
	public class PowerService : IPowerService
	{
		#region ReportStationsAll
		/// <summary>
		/// Report power usage for all power stations in the DB for the request time.
		/// </summary>
		/// <param name="hour">Hour to report</param>
		/// <param name="minute">Minute to report</param>
		/// <param name="second">Second to report</param>
		/// <returns>Power usage for all stations for the requested time.</returns>
		public PowerUsage_AllStations_OneSecond ReportStationsAll(string hour, string minute, string second)
		{
			PowerUsage_AllStations_OneSecond _results = new PowerUsage_AllStations_OneSecond();
			try
			{
				_results.ReadingHour = Byte.Parse(hour);
				_results.ReadingMinute = Byte.Parse(minute);
				_results.ReadingSecond = Byte.Parse(second);

				if (_results.ReadingHour < 0 || _results.ReadingHour > 23)
				{
					_results.ErrorMessage = "Invalid hour";
					return _results;
				}

				if (_results.ReadingMinute < 0 || _results.ReadingMinute > 59)
				{
					_results.ErrorMessage = "Invalid minute";
					return _results;
				}

				if (_results.ReadingSecond < 0 || _results.ReadingSecond > 59)
				{
					_results.ErrorMessage = "Invalid second";
					return _results;
				}

				switch (_results.ReadingHour)
				{
					case (0):
						{
							using (var db = new PowerStations_datEntities())
							{
								PowerReading00 _dbRec = db.PowerReading00
									.Where(r => r.ReadingMinute == _results.ReadingMinute && r.ReadingSecond == _results.ReadingSecond)
									.Select(r => r).FirstOrDefault();

								if (_dbRec != null)
								{
									_results.Station01PowerUsage = _dbRec.Station01PowerUsage;
									_results.Station02PowerUsage = _dbRec.Station02PowerUsage;
									_results.Station03PowerUsage = _dbRec.Station03PowerUsage;
									_results.Station04PowerUsage = _dbRec.Station04PowerUsage;
									_results.Station05PowerUsage = _dbRec.Station05PowerUsage;
									_results.Station06PowerUsage = _dbRec.Station06PowerUsage;
									_results.Station07PowerUsage = _dbRec.Station07PowerUsage;
									_results.Station08PowerUsage = _dbRec.Station08PowerUsage;
									_results.Station09PowerUsage = _dbRec.Station09PowerUsage;
									_results.Station10PowerUsage = _dbRec.Station10PowerUsage;
								}
							}
							break;
						}

					case (1):
						{
							using (var db = new PowerStations_datEntities())
							{
								PowerReading01 _dbRec = db.PowerReading01
									.Where(r => r.ReadingMinute == _results.ReadingMinute && r.ReadingSecond == _results.ReadingSecond)
									.Select(r => r).FirstOrDefault();

								if (_dbRec != null)
								{
									_results.Station01PowerUsage = _dbRec.Station01PowerUsage;
									_results.Station02PowerUsage = _dbRec.Station02PowerUsage;
									_results.Station03PowerUsage = _dbRec.Station03PowerUsage;
									_results.Station04PowerUsage = _dbRec.Station04PowerUsage;
									_results.Station05PowerUsage = _dbRec.Station05PowerUsage;
									_results.Station06PowerUsage = _dbRec.Station06PowerUsage;
									_results.Station07PowerUsage = _dbRec.Station07PowerUsage;
									_results.Station08PowerUsage = _dbRec.Station08PowerUsage;
									_results.Station09PowerUsage = _dbRec.Station09PowerUsage;
									_results.Station10PowerUsage = _dbRec.Station10PowerUsage;
								}
							}
							break;
						}

					case (2):
						{
							using (var db = new PowerStations_datEntities())
							{
								PowerReading02 _dbRec = db.PowerReading02
									.Where(r => r.ReadingMinute == _results.ReadingMinute && r.ReadingSecond == _results.ReadingSecond)
									.Select(r => r).FirstOrDefault();

								if (_dbRec != null)
								{
									_results.Station01PowerUsage = _dbRec.Station01PowerUsage;
									_results.Station02PowerUsage = _dbRec.Station02PowerUsage;
									_results.Station03PowerUsage = _dbRec.Station03PowerUsage;
									_results.Station04PowerUsage = _dbRec.Station04PowerUsage;
									_results.Station05PowerUsage = _dbRec.Station05PowerUsage;
									_results.Station06PowerUsage = _dbRec.Station06PowerUsage;
									_results.Station07PowerUsage = _dbRec.Station07PowerUsage;
									_results.Station08PowerUsage = _dbRec.Station08PowerUsage;
									_results.Station09PowerUsage = _dbRec.Station09PowerUsage;
									_results.Station10PowerUsage = _dbRec.Station10PowerUsage;
								}
							}
							break;
						}

					case (3):
						{
							using (var db = new PowerStations_datEntities())
							{
								PowerReading03 _dbRec = db.PowerReading03
									.Where(r => r.ReadingMinute == _results.ReadingMinute && r.ReadingSecond == _results.ReadingSecond)
									.Select(r => r).FirstOrDefault();

								if (_dbRec != null)
								{
									_results.Station01PowerUsage = _dbRec.Station01PowerUsage;
									_results.Station02PowerUsage = _dbRec.Station02PowerUsage;
									_results.Station03PowerUsage = _dbRec.Station03PowerUsage;
									_results.Station04PowerUsage = _dbRec.Station04PowerUsage;
									_results.Station05PowerUsage = _dbRec.Station05PowerUsage;
									_results.Station06PowerUsage = _dbRec.Station06PowerUsage;
									_results.Station07PowerUsage = _dbRec.Station07PowerUsage;
									_results.Station08PowerUsage = _dbRec.Station08PowerUsage;
									_results.Station09PowerUsage = _dbRec.Station09PowerUsage;
									_results.Station10PowerUsage = _dbRec.Station10PowerUsage;
								}
							}
							break;
						}

					case (4):
						{
							using (var db = new PowerStations_datEntities())
							{
								PowerReading04 _dbRec = db.PowerReading04
									.Where(r => r.ReadingMinute == _results.ReadingMinute && r.ReadingSecond == _results.ReadingSecond)
									.Select(r => r).FirstOrDefault();

								if (_dbRec != null)
								{
									_results.Station01PowerUsage = _dbRec.Station01PowerUsage;
									_results.Station02PowerUsage = _dbRec.Station02PowerUsage;
									_results.Station03PowerUsage = _dbRec.Station03PowerUsage;
									_results.Station04PowerUsage = _dbRec.Station04PowerUsage;
									_results.Station05PowerUsage = _dbRec.Station05PowerUsage;
									_results.Station06PowerUsage = _dbRec.Station06PowerUsage;
									_results.Station07PowerUsage = _dbRec.Station07PowerUsage;
									_results.Station08PowerUsage = _dbRec.Station08PowerUsage;
									_results.Station09PowerUsage = _dbRec.Station09PowerUsage;
									_results.Station10PowerUsage = _dbRec.Station10PowerUsage;
								}
							}
							break;
						}

					case (5):
						{
							using (var db = new PowerStations_datEntities())
							{
								PowerReading05 _dbRec = db.PowerReading05
									.Where(r => r.ReadingMinute == _results.ReadingMinute && r.ReadingSecond == _results.ReadingSecond)
									.Select(r => r).FirstOrDefault();

								if (_dbRec != null)
								{
									_results.Station01PowerUsage = _dbRec.Station01PowerUsage;
									_results.Station02PowerUsage = _dbRec.Station02PowerUsage;
									_results.Station03PowerUsage = _dbRec.Station03PowerUsage;
									_results.Station04PowerUsage = _dbRec.Station04PowerUsage;
									_results.Station05PowerUsage = _dbRec.Station05PowerUsage;
									_results.Station06PowerUsage = _dbRec.Station06PowerUsage;
									_results.Station07PowerUsage = _dbRec.Station07PowerUsage;
									_results.Station08PowerUsage = _dbRec.Station08PowerUsage;
									_results.Station09PowerUsage = _dbRec.Station09PowerUsage;
									_results.Station10PowerUsage = _dbRec.Station10PowerUsage;
								}
							}
							break;
						}

					case (6):
						{
							using (var db = new PowerStations_datEntities())
							{
								PowerReading06 _dbRec = db.PowerReading06
									.Where(r => r.ReadingMinute == _results.ReadingMinute && r.ReadingSecond == _results.ReadingSecond)
									.Select(r => r).FirstOrDefault();

								if (_dbRec != null)
								{
									_results.Station01PowerUsage = _dbRec.Station01PowerUsage;
									_results.Station02PowerUsage = _dbRec.Station02PowerUsage;
									_results.Station03PowerUsage = _dbRec.Station03PowerUsage;
									_results.Station04PowerUsage = _dbRec.Station04PowerUsage;
									_results.Station05PowerUsage = _dbRec.Station05PowerUsage;
									_results.Station06PowerUsage = _dbRec.Station06PowerUsage;
									_results.Station07PowerUsage = _dbRec.Station07PowerUsage;
									_results.Station08PowerUsage = _dbRec.Station08PowerUsage;
									_results.Station09PowerUsage = _dbRec.Station09PowerUsage;
									_results.Station10PowerUsage = _dbRec.Station10PowerUsage;
								}
							}
							break;
						}

					case (7):
						{
							using (var db = new PowerStations_datEntities())
							{
								PowerReading07 _dbRec = db.PowerReading07
									.Where(r => r.ReadingMinute == _results.ReadingMinute && r.ReadingSecond == _results.ReadingSecond)
									.Select(r => r).FirstOrDefault();

								if (_dbRec != null)
								{
									_results.Station01PowerUsage = _dbRec.Station01PowerUsage;
									_results.Station02PowerUsage = _dbRec.Station02PowerUsage;
									_results.Station03PowerUsage = _dbRec.Station03PowerUsage;
									_results.Station04PowerUsage = _dbRec.Station04PowerUsage;
									_results.Station05PowerUsage = _dbRec.Station05PowerUsage;
									_results.Station06PowerUsage = _dbRec.Station06PowerUsage;
									_results.Station07PowerUsage = _dbRec.Station07PowerUsage;
									_results.Station08PowerUsage = _dbRec.Station08PowerUsage;
									_results.Station09PowerUsage = _dbRec.Station09PowerUsage;
									_results.Station10PowerUsage = _dbRec.Station10PowerUsage;
								}
							}
							break;
						}

					case (8):
						{
							using (var db = new PowerStations_datEntities())
							{
								PowerReading08 _dbRec = db.PowerReading08
									.Where(r => r.ReadingMinute == _results.ReadingMinute && r.ReadingSecond == _results.ReadingSecond)
									.Select(r => r).FirstOrDefault();

								if (_dbRec != null)
								{
									_results.Station01PowerUsage = _dbRec.Station01PowerUsage;
									_results.Station02PowerUsage = _dbRec.Station02PowerUsage;
									_results.Station03PowerUsage = _dbRec.Station03PowerUsage;
									_results.Station04PowerUsage = _dbRec.Station04PowerUsage;
									_results.Station05PowerUsage = _dbRec.Station05PowerUsage;
									_results.Station06PowerUsage = _dbRec.Station06PowerUsage;
									_results.Station07PowerUsage = _dbRec.Station07PowerUsage;
									_results.Station08PowerUsage = _dbRec.Station08PowerUsage;
									_results.Station09PowerUsage = _dbRec.Station09PowerUsage;
									_results.Station10PowerUsage = _dbRec.Station10PowerUsage;
								}
							}
							break;
						}

					case (9):
						{
							using (var db = new PowerStations_datEntities())
							{
								PowerReading09 _dbRec = db.PowerReading09
									.Where(r => r.ReadingMinute == _results.ReadingMinute && r.ReadingSecond == _results.ReadingSecond)
									.Select(r => r).FirstOrDefault();

								if (_dbRec != null)
								{
									_results.Station01PowerUsage = _dbRec.Station01PowerUsage;
									_results.Station02PowerUsage = _dbRec.Station02PowerUsage;
									_results.Station03PowerUsage = _dbRec.Station03PowerUsage;
									_results.Station04PowerUsage = _dbRec.Station04PowerUsage;
									_results.Station05PowerUsage = _dbRec.Station05PowerUsage;
									_results.Station06PowerUsage = _dbRec.Station06PowerUsage;
									_results.Station07PowerUsage = _dbRec.Station07PowerUsage;
									_results.Station08PowerUsage = _dbRec.Station08PowerUsage;
									_results.Station09PowerUsage = _dbRec.Station09PowerUsage;
									_results.Station10PowerUsage = _dbRec.Station10PowerUsage;
								}
							}
							break;
						}

					case (10):
						{
							using (var db = new PowerStations_datEntities())
							{
								PowerReading10 _dbRec = db.PowerReading10
									.Where(r => r.ReadingMinute == _results.ReadingMinute && r.ReadingSecond == _results.ReadingSecond)
									.Select(r => r).FirstOrDefault();

								if (_dbRec != null)
								{
									_results.Station01PowerUsage = _dbRec.Station01PowerUsage;
									_results.Station02PowerUsage = _dbRec.Station02PowerUsage;
									_results.Station03PowerUsage = _dbRec.Station03PowerUsage;
									_results.Station04PowerUsage = _dbRec.Station04PowerUsage;
									_results.Station05PowerUsage = _dbRec.Station05PowerUsage;
									_results.Station06PowerUsage = _dbRec.Station06PowerUsage;
									_results.Station07PowerUsage = _dbRec.Station07PowerUsage;
									_results.Station08PowerUsage = _dbRec.Station08PowerUsage;
									_results.Station09PowerUsage = _dbRec.Station09PowerUsage;
									_results.Station10PowerUsage = _dbRec.Station10PowerUsage;
								}
							}
							break;
						}

					case (11):
						{
							using (var db = new PowerStations_datEntities())
							{
								PowerReading11 _dbRec = db.PowerReading11
									.Where(r => r.ReadingMinute == _results.ReadingMinute && r.ReadingSecond == _results.ReadingSecond)
									.Select(r => r).FirstOrDefault();

								if (_dbRec != null)
								{
									_results.Station01PowerUsage = _dbRec.Station01PowerUsage;
									_results.Station02PowerUsage = _dbRec.Station02PowerUsage;
									_results.Station03PowerUsage = _dbRec.Station03PowerUsage;
									_results.Station04PowerUsage = _dbRec.Station04PowerUsage;
									_results.Station05PowerUsage = _dbRec.Station05PowerUsage;
									_results.Station06PowerUsage = _dbRec.Station06PowerUsage;
									_results.Station07PowerUsage = _dbRec.Station07PowerUsage;
									_results.Station08PowerUsage = _dbRec.Station08PowerUsage;
									_results.Station09PowerUsage = _dbRec.Station09PowerUsage;
									_results.Station10PowerUsage = _dbRec.Station10PowerUsage;
								}
							}
							break;
						}

					case (12):
						{
							using (var db = new PowerStations_datEntities())
							{
								PowerReading12 _dbRec = db.PowerReading12
									.Where(r => r.ReadingMinute == _results.ReadingMinute && r.ReadingSecond == _results.ReadingSecond)
									.Select(r => r).FirstOrDefault();

								if (_dbRec != null)
								{
									_results.Station01PowerUsage = _dbRec.Station01PowerUsage;
									_results.Station02PowerUsage = _dbRec.Station02PowerUsage;
									_results.Station03PowerUsage = _dbRec.Station03PowerUsage;
									_results.Station04PowerUsage = _dbRec.Station04PowerUsage;
									_results.Station05PowerUsage = _dbRec.Station05PowerUsage;
									_results.Station06PowerUsage = _dbRec.Station06PowerUsage;
									_results.Station07PowerUsage = _dbRec.Station07PowerUsage;
									_results.Station08PowerUsage = _dbRec.Station08PowerUsage;
									_results.Station09PowerUsage = _dbRec.Station09PowerUsage;
									_results.Station10PowerUsage = _dbRec.Station10PowerUsage;
								}
							}
							break;
						}

					case (13):
						{
							using (var db = new PowerStations_datEntities())
							{
								PowerReading13 _dbRec = db.PowerReading13
									.Where(r => r.ReadingMinute == _results.ReadingMinute && r.ReadingSecond == _results.ReadingSecond)
									.Select(r => r).FirstOrDefault();

								if (_dbRec != null)
								{
									_results.Station01PowerUsage = _dbRec.Station01PowerUsage;
									_results.Station02PowerUsage = _dbRec.Station02PowerUsage;
									_results.Station03PowerUsage = _dbRec.Station03PowerUsage;
									_results.Station04PowerUsage = _dbRec.Station04PowerUsage;
									_results.Station05PowerUsage = _dbRec.Station05PowerUsage;
									_results.Station06PowerUsage = _dbRec.Station06PowerUsage;
									_results.Station07PowerUsage = _dbRec.Station07PowerUsage;
									_results.Station08PowerUsage = _dbRec.Station08PowerUsage;
									_results.Station09PowerUsage = _dbRec.Station09PowerUsage;
									_results.Station10PowerUsage = _dbRec.Station10PowerUsage;
								}
							}
							break;
						}

					case (14):
						{
							using (var db = new PowerStations_datEntities())
							{
								PowerReading14 _dbRec = db.PowerReading14
									.Where(r => r.ReadingMinute == _results.ReadingMinute && r.ReadingSecond == _results.ReadingSecond)
									.Select(r => r).FirstOrDefault();

								if (_dbRec != null)
								{
									_results.Station01PowerUsage = _dbRec.Station01PowerUsage;
									_results.Station02PowerUsage = _dbRec.Station02PowerUsage;
									_results.Station03PowerUsage = _dbRec.Station03PowerUsage;
									_results.Station04PowerUsage = _dbRec.Station04PowerUsage;
									_results.Station05PowerUsage = _dbRec.Station05PowerUsage;
									_results.Station06PowerUsage = _dbRec.Station06PowerUsage;
									_results.Station07PowerUsage = _dbRec.Station07PowerUsage;
									_results.Station08PowerUsage = _dbRec.Station08PowerUsage;
									_results.Station09PowerUsage = _dbRec.Station09PowerUsage;
									_results.Station10PowerUsage = _dbRec.Station10PowerUsage;
								}
							}
							break;
						}

					case (15):
						{
							using (var db = new PowerStations_datEntities())
							{
								PowerReading15 _dbRec = db.PowerReading15
									.Where(r => r.ReadingMinute == _results.ReadingMinute && r.ReadingSecond == _results.ReadingSecond)
									.Select(r => r).FirstOrDefault();

								if (_dbRec != null)
								{
									_results.Station01PowerUsage = _dbRec.Station01PowerUsage;
									_results.Station02PowerUsage = _dbRec.Station02PowerUsage;
									_results.Station03PowerUsage = _dbRec.Station03PowerUsage;
									_results.Station04PowerUsage = _dbRec.Station04PowerUsage;
									_results.Station05PowerUsage = _dbRec.Station05PowerUsage;
									_results.Station06PowerUsage = _dbRec.Station06PowerUsage;
									_results.Station07PowerUsage = _dbRec.Station07PowerUsage;
									_results.Station08PowerUsage = _dbRec.Station08PowerUsage;
									_results.Station09PowerUsage = _dbRec.Station09PowerUsage;
									_results.Station10PowerUsage = _dbRec.Station10PowerUsage;
								}
							}
							break;
						}

					case (16):
						{
							using (var db = new PowerStations_datEntities())
							{
								PowerReading16 _dbRec = db.PowerReading16
									.Where(r => r.ReadingMinute == _results.ReadingMinute && r.ReadingSecond == _results.ReadingSecond)
									.Select(r => r).FirstOrDefault();

								if (_dbRec != null)
								{
									_results.Station01PowerUsage = _dbRec.Station01PowerUsage;
									_results.Station02PowerUsage = _dbRec.Station02PowerUsage;
									_results.Station03PowerUsage = _dbRec.Station03PowerUsage;
									_results.Station04PowerUsage = _dbRec.Station04PowerUsage;
									_results.Station05PowerUsage = _dbRec.Station05PowerUsage;
									_results.Station06PowerUsage = _dbRec.Station06PowerUsage;
									_results.Station07PowerUsage = _dbRec.Station07PowerUsage;
									_results.Station08PowerUsage = _dbRec.Station08PowerUsage;
									_results.Station09PowerUsage = _dbRec.Station09PowerUsage;
									_results.Station10PowerUsage = _dbRec.Station10PowerUsage;
								}
							}
							break;
						}

					case (17):
						{
							using (var db = new PowerStations_datEntities())
							{
								PowerReading17 _dbRec = db.PowerReading17
									.Where(r => r.ReadingMinute == _results.ReadingMinute && r.ReadingSecond == _results.ReadingSecond)
									.Select(r => r).FirstOrDefault();

								if (_dbRec != null)
								{
									_results.Station01PowerUsage = _dbRec.Station01PowerUsage;
									_results.Station02PowerUsage = _dbRec.Station02PowerUsage;
									_results.Station03PowerUsage = _dbRec.Station03PowerUsage;
									_results.Station04PowerUsage = _dbRec.Station04PowerUsage;
									_results.Station05PowerUsage = _dbRec.Station05PowerUsage;
									_results.Station06PowerUsage = _dbRec.Station06PowerUsage;
									_results.Station07PowerUsage = _dbRec.Station07PowerUsage;
									_results.Station08PowerUsage = _dbRec.Station08PowerUsage;
									_results.Station09PowerUsage = _dbRec.Station09PowerUsage;
									_results.Station10PowerUsage = _dbRec.Station10PowerUsage;
								}
							}
							break;
						}

					case (18):
						{
							using (var db = new PowerStations_datEntities())
							{
								PowerReading18 _dbRec = db.PowerReading18
									.Where(r => r.ReadingMinute == _results.ReadingMinute && r.ReadingSecond == _results.ReadingSecond)
									.Select(r => r).FirstOrDefault();

								if (_dbRec != null)
								{
									_results.Station01PowerUsage = _dbRec.Station01PowerUsage;
									_results.Station02PowerUsage = _dbRec.Station02PowerUsage;
									_results.Station03PowerUsage = _dbRec.Station03PowerUsage;
									_results.Station04PowerUsage = _dbRec.Station04PowerUsage;
									_results.Station05PowerUsage = _dbRec.Station05PowerUsage;
									_results.Station06PowerUsage = _dbRec.Station06PowerUsage;
									_results.Station07PowerUsage = _dbRec.Station07PowerUsage;
									_results.Station08PowerUsage = _dbRec.Station08PowerUsage;
									_results.Station09PowerUsage = _dbRec.Station09PowerUsage;
									_results.Station10PowerUsage = _dbRec.Station10PowerUsage;
								}
							}
							break;
						}

					case (19):
						{
							using (var db = new PowerStations_datEntities())
							{
								PowerReading19 _dbRec = db.PowerReading19
									.Where(r => r.ReadingMinute == _results.ReadingMinute && r.ReadingSecond == _results.ReadingSecond)
									.Select(r => r).FirstOrDefault();

								if (_dbRec != null)
								{
									_results.Station01PowerUsage = _dbRec.Station01PowerUsage;
									_results.Station02PowerUsage = _dbRec.Station02PowerUsage;
									_results.Station03PowerUsage = _dbRec.Station03PowerUsage;
									_results.Station04PowerUsage = _dbRec.Station04PowerUsage;
									_results.Station05PowerUsage = _dbRec.Station05PowerUsage;
									_results.Station06PowerUsage = _dbRec.Station06PowerUsage;
									_results.Station07PowerUsage = _dbRec.Station07PowerUsage;
									_results.Station08PowerUsage = _dbRec.Station08PowerUsage;
									_results.Station09PowerUsage = _dbRec.Station09PowerUsage;
									_results.Station10PowerUsage = _dbRec.Station10PowerUsage;
								}
							}
							break;
						}

					case (20):
						{
							using (var db = new PowerStations_datEntities())
							{
								PowerReading20 _dbRec = db.PowerReading20
									.Where(r => r.ReadingMinute == _results.ReadingMinute && r.ReadingSecond == _results.ReadingSecond)
									.Select(r => r).FirstOrDefault();

								if (_dbRec != null)
								{
									_results.Station01PowerUsage = _dbRec.Station01PowerUsage;
									_results.Station02PowerUsage = _dbRec.Station02PowerUsage;
									_results.Station03PowerUsage = _dbRec.Station03PowerUsage;
									_results.Station04PowerUsage = _dbRec.Station04PowerUsage;
									_results.Station05PowerUsage = _dbRec.Station05PowerUsage;
									_results.Station06PowerUsage = _dbRec.Station06PowerUsage;
									_results.Station07PowerUsage = _dbRec.Station07PowerUsage;
									_results.Station08PowerUsage = _dbRec.Station08PowerUsage;
									_results.Station09PowerUsage = _dbRec.Station09PowerUsage;
									_results.Station10PowerUsage = _dbRec.Station10PowerUsage;
								}
							}
							break;
						}

					case (21):
						{
							using (var db = new PowerStations_datEntities())
							{
								PowerReading21 _dbRec = db.PowerReading21
									.Where(r => r.ReadingMinute == _results.ReadingMinute && r.ReadingSecond == _results.ReadingSecond)
									.Select(r => r).FirstOrDefault();

								if (_dbRec != null)
								{
									_results.Station01PowerUsage = _dbRec.Station01PowerUsage;
									_results.Station02PowerUsage = _dbRec.Station02PowerUsage;
									_results.Station03PowerUsage = _dbRec.Station03PowerUsage;
									_results.Station04PowerUsage = _dbRec.Station04PowerUsage;
									_results.Station05PowerUsage = _dbRec.Station05PowerUsage;
									_results.Station06PowerUsage = _dbRec.Station06PowerUsage;
									_results.Station07PowerUsage = _dbRec.Station07PowerUsage;
									_results.Station08PowerUsage = _dbRec.Station08PowerUsage;
									_results.Station09PowerUsage = _dbRec.Station09PowerUsage;
									_results.Station10PowerUsage = _dbRec.Station10PowerUsage;
								}
							}
							break;
						}

					case (22):
						{
							using (var db = new PowerStations_datEntities())
							{
								PowerReading22 _dbRec = db.PowerReading22
									.Where(r => r.ReadingMinute == _results.ReadingMinute && r.ReadingSecond == _results.ReadingSecond)
									.Select(r => r).FirstOrDefault();

								if (_dbRec != null)
								{
									_results.Station01PowerUsage = _dbRec.Station01PowerUsage;
									_results.Station02PowerUsage = _dbRec.Station02PowerUsage;
									_results.Station03PowerUsage = _dbRec.Station03PowerUsage;
									_results.Station04PowerUsage = _dbRec.Station04PowerUsage;
									_results.Station05PowerUsage = _dbRec.Station05PowerUsage;
									_results.Station06PowerUsage = _dbRec.Station06PowerUsage;
									_results.Station07PowerUsage = _dbRec.Station07PowerUsage;
									_results.Station08PowerUsage = _dbRec.Station08PowerUsage;
									_results.Station09PowerUsage = _dbRec.Station09PowerUsage;
									_results.Station10PowerUsage = _dbRec.Station10PowerUsage;
								}
							}
							break;
						}

					case (23):
						{
							using (var db = new PowerStations_datEntities())
							{
								PowerReading23 _dbRec = db.PowerReading23
									.Where(r => r.ReadingMinute == _results.ReadingMinute && r.ReadingSecond == _results.ReadingSecond)
									.Select(r => r).FirstOrDefault();

								if (_dbRec != null)
								{
									_results.Station01PowerUsage = _dbRec.Station01PowerUsage;
									_results.Station02PowerUsage = _dbRec.Station02PowerUsage;
									_results.Station03PowerUsage = _dbRec.Station03PowerUsage;
									_results.Station04PowerUsage = _dbRec.Station04PowerUsage;
									_results.Station05PowerUsage = _dbRec.Station05PowerUsage;
									_results.Station06PowerUsage = _dbRec.Station06PowerUsage;
									_results.Station07PowerUsage = _dbRec.Station07PowerUsage;
									_results.Station08PowerUsage = _dbRec.Station08PowerUsage;
									_results.Station09PowerUsage = _dbRec.Station09PowerUsage;
									_results.Station10PowerUsage = _dbRec.Station10PowerUsage;
								}
							}
							break;
						}
				}           // End of Switch
			}
			catch (Exception ex)
			{
				_results.ErrorMessage = ex.Message;
			}
			return _results;
		}
		#endregion

		#region Show power usage for 1 station for 15 minutes

		/// <summary>
		/// Return power station readings for a 15-minute period.
		/// </summary>
		/// <param name="stationNumber">Station number to report</param>
		/// <param name="hour">Hour to report</param>
		/// <param name="minute">Starting minute to report</param>
		/// <returns>Object PowerUsage_OneStation_15Minutes is returned with the results</returns>
		public PowerUsage_OneStation_15Minutes ReportOneStation(string stationNumber, string hour, string minute)
		{
			PowerUsage_OneStation_15Minutes _results = null;

			try
			{
				_results = new PowerUsage_OneStation_15Minutes();
				_results.StationNumber = Byte.Parse(stationNumber);
				_results.ReadingHour = Byte.Parse(hour);
				_results.StartReadingMinute = Byte.Parse(minute);

				if (_results.StationNumber < 0 || _results.StationNumber > 10)
				{
					_results.ErrorMessage = "Invalid station number";
					return _results;
				}

				if (_results.ReadingHour < 0 || _results.ReadingHour > 23)
				{
					_results.ErrorMessage = "Invalid hour";
					return _results;
				}

				if (_results.StartReadingMinute < 0 || _results.StartReadingMinute > 59)
				{
					_results.ErrorMessage = "Invalid minute";
					return _results;
				}

				// Get general station info first.
				using (var db = new PowerStations_datEntities())
				{
					PowerStation _stationInfo = db.PowerStations
						.Where(r => r.ID == (short)_results.StationNumber)
						.Select(r => r).FirstOrDefault();

					if (_stationInfo != null)
					{
						_results.StationName = _stationInfo.Name;
						_results.StationLocation = _stationInfo.Location;
						_results.StationPhone = _stationInfo.Phone;
					}
				}
				// ===========================


				// Now get the main power station readings data.

				int _startMinute = _results.StartReadingMinute;
				int _lastMinute = _startMinute + 15;

				switch (_results.ReadingHour)
				{
					// Case for hour '0' (midnite to 00:59:59)
					case (0):
						{
							using (var db = new PowerStations_datEntities())
							{
								// Get a list of 1 second readings for a 15-minute period
								List<PowerReading00> _dbRecords = (db.PowerReading00
									.Where(r => r.ReadingMinute >= _startMinute && r.ReadingMinute < _lastMinute)
									.Select(r => r))
									.ToList();

								// If list of records read OK...
								if (_dbRecords != null)
								{
									// Create an array to return the requested data.
									_results.PowerUsage = new decimal[_dbRecords.Count];

									// Loop thru each 1-second DB record
									int x = 0;
									foreach (var record in _dbRecords)
									{
										// Now split off to get a reading from the requested station number.
										switch (_results.StationNumber)
										{
											case (1):
												{
													_results.PowerUsage[x++] = record.Station01PowerUsage;
													break;
												}
											case (2):
												{
													_results.PowerUsage[x++] = record.Station02PowerUsage;
													break;
												}
											case (3):
												{
													_results.PowerUsage[x++] = record.Station03PowerUsage;
													break;
												}
											case (4):
												{
													_results.PowerUsage[x++] = record.Station04PowerUsage;
													break;
												}
											case (5):
												{
													_results.PowerUsage[x++] = record.Station05PowerUsage;
													break;
												}
											case (6):
												{
													_results.PowerUsage[x++] = record.Station06PowerUsage;
													break;
												}
											case (7):
												{
													_results.PowerUsage[x++] = record.Station07PowerUsage;
													break;
												}
											case (8):
												{
													_results.PowerUsage[x++] = record.Station08PowerUsage;
													break;
												}
											case (9):
												{
													_results.PowerUsage[x++] = record.Station09PowerUsage;
													break;
												}
											case (10):
												{
													_results.PowerUsage[x++] = record.Station10PowerUsage;
													break;
												}
										}           // End switch by station number
									}               // End foreach loop thru DB records
								}                   // End list of DB records null check
							}                       // End using DB entities
							break;
						}                           // End this hour 'case'

					case (1):                       // Case for hour '1' (01:00:00 to 01:59:59)
						{
							using (var db = new PowerStations_datEntities())
							{
								// Get a list of 1 second readings for a 15-minute period
								List<PowerReading01> _dbRecords = (db.PowerReading01
									.Where(r => r.ReadingMinute >= _startMinute && r.ReadingMinute < _lastMinute)
									.Select(r => r))
									.ToList();

								// If list of records read OK...
								if (_dbRecords != null)
								{
									// Create an array to return the requested data.
									_results.PowerUsage = new decimal[_dbRecords.Count];

									// Loop thru each 1-second DB record
									int x = 0;
									foreach (var record in _dbRecords)
									{
										// Now split off to get a reading from the requested station number.
										switch (_results.StationNumber)
										{
											case (1):
												{
													_results.PowerUsage[x++] = record.Station01PowerUsage;
													break;
												}
											case (2):
												{
													_results.PowerUsage[x++] = record.Station02PowerUsage;
													break;
												}
											case (3):
												{
													_results.PowerUsage[x++] = record.Station03PowerUsage;
													break;
												}
											case (4):
												{
													_results.PowerUsage[x++] = record.Station04PowerUsage;
													break;
												}
											case (5):
												{
													_results.PowerUsage[x++] = record.Station05PowerUsage;
													break;
												}
											case (6):
												{
													_results.PowerUsage[x++] = record.Station06PowerUsage;
													break;
												}
											case (7):
												{
													_results.PowerUsage[x++] = record.Station07PowerUsage;
													break;
												}
											case (8):
												{
													_results.PowerUsage[x++] = record.Station08PowerUsage;
													break;
												}
											case (9):
												{
													_results.PowerUsage[x++] = record.Station09PowerUsage;
													break;
												}
											case (10):
												{
													_results.PowerUsage[x++] = record.Station10PowerUsage;
													break;
												}
										}           // End switch by station number
									}               // End foreach loop thru DB records
								}                   // End list of DB records null check
							}                       // End using DB entities
							break;
						}                           // End this hour 'case'

					case (2):                       // Case for hour '2' (02:00:00 to 02:59:59)
						{
							using (var db = new PowerStations_datEntities())
							{
								// Get a list of 1 second readings for a 15-minute period
								List<PowerReading02> _dbRecords = (db.PowerReading02
									.Where(r => r.ReadingMinute >= _startMinute && r.ReadingMinute < _lastMinute)
									.Select(r => r))
									.ToList();

								// If list of records read OK...
								if (_dbRecords != null)
								{
									// Create an array to return the requested data.
									_results.PowerUsage = new decimal[_dbRecords.Count];

									// Loop thru each 1-second DB record
									int x = 0;
									foreach (var record in _dbRecords)
									{
										// Now split off to get a reading from the requested station number.
										switch (_results.StationNumber)
										{
											case (1):
												{
													_results.PowerUsage[x++] = record.Station01PowerUsage;
													break;
												}
											case (2):
												{
													_results.PowerUsage[x++] = record.Station02PowerUsage;
													break;
												}
											case (3):
												{
													_results.PowerUsage[x++] = record.Station03PowerUsage;
													break;
												}
											case (4):
												{
													_results.PowerUsage[x++] = record.Station04PowerUsage;
													break;
												}
											case (5):
												{
													_results.PowerUsage[x++] = record.Station05PowerUsage;
													break;
												}
											case (6):
												{
													_results.PowerUsage[x++] = record.Station06PowerUsage;
													break;
												}
											case (7):
												{
													_results.PowerUsage[x++] = record.Station07PowerUsage;
													break;
												}
											case (8):
												{
													_results.PowerUsage[x++] = record.Station08PowerUsage;
													break;
												}
											case (9):
												{
													_results.PowerUsage[x++] = record.Station09PowerUsage;
													break;
												}
											case (10):
												{
													_results.PowerUsage[x++] = record.Station10PowerUsage;
													break;
												}
										}           // End switch by station number
									}               // End foreach loop thru DB records
								}                   // End list of DB records null check
							}                       // End using DB entities
							break;
						}                           // End this hour 'case'

					case (3):                       // Case for hour '3' (03:00:00 to 03:59:59)
						{
							using (var db = new PowerStations_datEntities())
							{
								// Get a list of 1 second readings for a 15-minute period
								List<PowerReading03> _dbRecords = (db.PowerReading03
									.Where(r => r.ReadingMinute >= _startMinute && r.ReadingMinute < _lastMinute)
									.Select(r => r))
									.ToList();

								// If list of records read OK...
								if (_dbRecords != null)
								{
									// Create an array to return the requested data.
									_results.PowerUsage = new decimal[_dbRecords.Count];

									// Loop thru each 1-second DB record
									int x = 0;
									foreach (var record in _dbRecords)
									{
										// Now split off to get a reading from the requested station number.
										switch (_results.StationNumber)
										{
											case (1):
												{
													_results.PowerUsage[x++] = record.Station01PowerUsage;
													break;
												}
											case (2):
												{
													_results.PowerUsage[x++] = record.Station02PowerUsage;
													break;
												}
											case (3):
												{
													_results.PowerUsage[x++] = record.Station03PowerUsage;
													break;
												}
											case (4):
												{
													_results.PowerUsage[x++] = record.Station04PowerUsage;
													break;
												}
											case (5):
												{
													_results.PowerUsage[x++] = record.Station05PowerUsage;
													break;
												}
											case (6):
												{
													_results.PowerUsage[x++] = record.Station06PowerUsage;
													break;
												}
											case (7):
												{
													_results.PowerUsage[x++] = record.Station07PowerUsage;
													break;
												}
											case (8):
												{
													_results.PowerUsage[x++] = record.Station08PowerUsage;
													break;
												}
											case (9):
												{
													_results.PowerUsage[x++] = record.Station09PowerUsage;
													break;
												}
											case (10):
												{
													_results.PowerUsage[x++] = record.Station10PowerUsage;
													break;
												}
										}           // End switch by station number
									}               // End foreach loop thru DB records
								}                   // End list of DB records null check
							}                       // End using DB entities
							break;
						}                           // End this hour 'case'

					case (4):                       // Case for hour '4' (04:00:00 to 04:59:59)
						{
							using (var db = new PowerStations_datEntities())
							{
								// Get a list of 1 second readings for a 15-minute period
								List<PowerReading04> _dbRecords = (db.PowerReading04
									.Where(r => r.ReadingMinute >= _startMinute && r.ReadingMinute < _lastMinute)
									.Select(r => r))
									.ToList();

								// If list of records read OK...
								if (_dbRecords != null)
								{
									// Create an array to return the requested data.
									_results.PowerUsage = new decimal[_dbRecords.Count];

									// Loop thru each 1-second DB record
									int x = 0;
									foreach (var record in _dbRecords)
									{
										// Now split off to get a reading from the requested station number.
										switch (_results.StationNumber)
										{
											case (1):
												{
													_results.PowerUsage[x++] = record.Station01PowerUsage;
													break;
												}
											case (2):
												{
													_results.PowerUsage[x++] = record.Station02PowerUsage;
													break;
												}
											case (3):
												{
													_results.PowerUsage[x++] = record.Station03PowerUsage;
													break;
												}
											case (4):
												{
													_results.PowerUsage[x++] = record.Station04PowerUsage;
													break;
												}
											case (5):
												{
													_results.PowerUsage[x++] = record.Station05PowerUsage;
													break;
												}
											case (6):
												{
													_results.PowerUsage[x++] = record.Station06PowerUsage;
													break;
												}
											case (7):
												{
													_results.PowerUsage[x++] = record.Station07PowerUsage;
													break;
												}
											case (8):
												{
													_results.PowerUsage[x++] = record.Station08PowerUsage;
													break;
												}
											case (9):
												{
													_results.PowerUsage[x++] = record.Station09PowerUsage;
													break;
												}
											case (10):
												{
													_results.PowerUsage[x++] = record.Station10PowerUsage;
													break;
												}
										}           // End switch by station number
									}               // End foreach loop thru DB records
								}                   // End list of DB records null check
							}                       // End using DB entities
							break;
						}                           // End this hour 'case'

					case (5):                       // Case for hour '5' (05:00:00 to 05:59:59)
						{
							using (var db = new PowerStations_datEntities())
							{
								// Get a list of 1 second readings for a 15-minute period
								List<PowerReading05> _dbRecords = (db.PowerReading05
									.Where(r => r.ReadingMinute >= _startMinute && r.ReadingMinute < _lastMinute)
									.Select(r => r))
									.ToList();

								// If list of records read OK...
								if (_dbRecords != null)
								{
									// Create an array to return the requested data.
									_results.PowerUsage = new decimal[_dbRecords.Count];

									// Loop thru each 1-second DB record
									int x = 0;
									foreach (var record in _dbRecords)
									{
										// Now split off to get a reading from the requested station number.
										switch (_results.StationNumber)
										{
											case (1):
												{
													_results.PowerUsage[x++] = record.Station01PowerUsage;
													break;
												}
											case (2):
												{
													_results.PowerUsage[x++] = record.Station02PowerUsage;
													break;
												}
											case (3):
												{
													_results.PowerUsage[x++] = record.Station03PowerUsage;
													break;
												}
											case (4):
												{
													_results.PowerUsage[x++] = record.Station04PowerUsage;
													break;
												}
											case (5):
												{
													_results.PowerUsage[x++] = record.Station05PowerUsage;
													break;
												}
											case (6):
												{
													_results.PowerUsage[x++] = record.Station06PowerUsage;
													break;
												}
											case (7):
												{
													_results.PowerUsage[x++] = record.Station07PowerUsage;
													break;
												}
											case (8):
												{
													_results.PowerUsage[x++] = record.Station08PowerUsage;
													break;
												}
											case (9):
												{
													_results.PowerUsage[x++] = record.Station09PowerUsage;
													break;
												}
											case (10):
												{
													_results.PowerUsage[x++] = record.Station10PowerUsage;
													break;
												}
										}           // End switch by station number
									}               // End foreach loop thru DB records
								}                   // End list of DB records null check
							}                       // End using DB entities
							break;
						}                           // End this hour 'case'

					case (6):                       // Case for hour '6' (06:00:00 to 06:59:59)
						{
							using (var db = new PowerStations_datEntities())
							{
								// Get a list of 1 second readings for a 15-minute period
								List<PowerReading06> _dbRecords = (db.PowerReading06
									.Where(r => r.ReadingMinute >= _startMinute && r.ReadingMinute < _lastMinute)
									.Select(r => r))
									.ToList();

								// If list of records read OK...
								if (_dbRecords != null)
								{
									// Create an array to return the requested data.
									_results.PowerUsage = new decimal[_dbRecords.Count];

									// Loop thru each 1-second DB record
									int x = 0;
									foreach (var record in _dbRecords)
									{
										// Now split off to get a reading from the requested station number.
										switch (_results.StationNumber)
										{
											case (1):
												{
													_results.PowerUsage[x++] = record.Station01PowerUsage;
													break;
												}
											case (2):
												{
													_results.PowerUsage[x++] = record.Station02PowerUsage;
													break;
												}
											case (3):
												{
													_results.PowerUsage[x++] = record.Station03PowerUsage;
													break;
												}
											case (4):
												{
													_results.PowerUsage[x++] = record.Station04PowerUsage;
													break;
												}
											case (5):
												{
													_results.PowerUsage[x++] = record.Station05PowerUsage;
													break;
												}
											case (6):
												{
													_results.PowerUsage[x++] = record.Station06PowerUsage;
													break;
												}
											case (7):
												{
													_results.PowerUsage[x++] = record.Station07PowerUsage;
													break;
												}
											case (8):
												{
													_results.PowerUsage[x++] = record.Station08PowerUsage;
													break;
												}
											case (9):
												{
													_results.PowerUsage[x++] = record.Station09PowerUsage;
													break;
												}
											case (10):
												{
													_results.PowerUsage[x++] = record.Station10PowerUsage;
													break;
												}
										}           // End switch by station number
									}               // End foreach loop thru DB records
								}                   // End list of DB records null check
							}                       // End using DB entities
							break;
						}                           // End this hour 'case'

					case (7):                       // Case for hour '7' (07:00:00 to 07:59:59)
						{
							using (var db = new PowerStations_datEntities())
							{
								// Get a list of 1 second readings for a 15-minute period
								List<PowerReading07> _dbRecords = (db.PowerReading07
									.Where(r => r.ReadingMinute >= _startMinute && r.ReadingMinute < _lastMinute)
									.Select(r => r))
									.ToList();

								// If list of records read OK...
								if (_dbRecords != null)
								{
									// Create an array to return the requested data.
									_results.PowerUsage = new decimal[_dbRecords.Count];

									// Loop thru each 1-second DB record
									int x = 0;
									foreach (var record in _dbRecords)
									{
										// Now split off to get a reading from the requested station number.
										switch (_results.StationNumber)
										{
											case (1):
												{
													_results.PowerUsage[x++] = record.Station01PowerUsage;
													break;
												}
											case (2):
												{
													_results.PowerUsage[x++] = record.Station02PowerUsage;
													break;
												}
											case (3):
												{
													_results.PowerUsage[x++] = record.Station03PowerUsage;
													break;
												}
											case (4):
												{
													_results.PowerUsage[x++] = record.Station04PowerUsage;
													break;
												}
											case (5):
												{
													_results.PowerUsage[x++] = record.Station05PowerUsage;
													break;
												}
											case (6):
												{
													_results.PowerUsage[x++] = record.Station06PowerUsage;
													break;
												}
											case (7):
												{
													_results.PowerUsage[x++] = record.Station07PowerUsage;
													break;
												}
											case (8):
												{
													_results.PowerUsage[x++] = record.Station08PowerUsage;
													break;
												}
											case (9):
												{
													_results.PowerUsage[x++] = record.Station09PowerUsage;
													break;
												}
											case (10):
												{
													_results.PowerUsage[x++] = record.Station10PowerUsage;
													break;
												}
										}           // End switch by station number
									}               // End foreach loop thru DB records
								}                   // End list of DB records null check
							}                       // End using DB entities
							break;
						}                           // End this hour 'case'

					case (8):                       // Case for hour '8' (08:00:00 to 08:59:59)
						{
							using (var db = new PowerStations_datEntities())
							{
								// Get a list of 1 second readings for a 15-minute period
								List<PowerReading08> _dbRecords = (db.PowerReading08
									.Where(r => r.ReadingMinute >= _startMinute && r.ReadingMinute < _lastMinute)
									.Select(r => r))
									.ToList();

								// If list of records read OK...
								if (_dbRecords != null)
								{
									// Create an array to return the requested data.
									_results.PowerUsage = new decimal[_dbRecords.Count];

									// Loop thru each 1-second DB record
									int x = 0;
									foreach (var record in _dbRecords)
									{
										// Now split off to get a reading from the requested station number.
										switch (_results.StationNumber)
										{
											case (1):
												{
													_results.PowerUsage[x++] = record.Station01PowerUsage;
													break;
												}
											case (2):
												{
													_results.PowerUsage[x++] = record.Station02PowerUsage;
													break;
												}
											case (3):
												{
													_results.PowerUsage[x++] = record.Station03PowerUsage;
													break;
												}
											case (4):
												{
													_results.PowerUsage[x++] = record.Station04PowerUsage;
													break;
												}
											case (5):
												{
													_results.PowerUsage[x++] = record.Station05PowerUsage;
													break;
												}
											case (6):
												{
													_results.PowerUsage[x++] = record.Station06PowerUsage;
													break;
												}
											case (7):
												{
													_results.PowerUsage[x++] = record.Station07PowerUsage;
													break;
												}
											case (8):
												{
													_results.PowerUsage[x++] = record.Station08PowerUsage;
													break;
												}
											case (9):
												{
													_results.PowerUsage[x++] = record.Station09PowerUsage;
													break;
												}
											case (10):
												{
													_results.PowerUsage[x++] = record.Station10PowerUsage;
													break;
												}
										}           // End switch by station number
									}               // End foreach loop thru DB records
								}                   // End list of DB records null check
							}                       // End using DB entities
							break;
						}                           // End this hour 'case'

					case (9):                       // Case for hour '9' (09:00:00 to 09:59:59)
						{
							using (var db = new PowerStations_datEntities())
							{
								// Get a list of 1 second readings for a 15-minute period
								List<PowerReading09> _dbRecords = (db.PowerReading09
									.Where(r => r.ReadingMinute >= _startMinute && r.ReadingMinute < _lastMinute)
									.Select(r => r))
									.ToList();

								// If list of records read OK...
								if (_dbRecords != null)
								{
									// Create an array to return the requested data.
									_results.PowerUsage = new decimal[_dbRecords.Count];

									// Loop thru each 1-second DB record
									int x = 0;
									foreach (var record in _dbRecords)
									{
										// Now split off to get a reading from the requested station number.
										switch (_results.StationNumber)
										{
											case (1):
												{
													_results.PowerUsage[x++] = record.Station01PowerUsage;
													break;
												}
											case (2):
												{
													_results.PowerUsage[x++] = record.Station02PowerUsage;
													break;
												}
											case (3):
												{
													_results.PowerUsage[x++] = record.Station03PowerUsage;
													break;
												}
											case (4):
												{
													_results.PowerUsage[x++] = record.Station04PowerUsage;
													break;
												}
											case (5):
												{
													_results.PowerUsage[x++] = record.Station05PowerUsage;
													break;
												}
											case (6):
												{
													_results.PowerUsage[x++] = record.Station06PowerUsage;
													break;
												}
											case (7):
												{
													_results.PowerUsage[x++] = record.Station07PowerUsage;
													break;
												}
											case (8):
												{
													_results.PowerUsage[x++] = record.Station08PowerUsage;
													break;
												}
											case (9):
												{
													_results.PowerUsage[x++] = record.Station09PowerUsage;
													break;
												}
											case (10):
												{
													_results.PowerUsage[x++] = record.Station10PowerUsage;
													break;
												}
										}           // End switch by station number
									}               // End foreach loop thru DB records
								}                   // End list of DB records null check
							}                       // End using DB entities
							break;
						}                           // End this hour 'case'

					case (10):                       // Case for hour '10' (10:00:00 to 10:59:59)
						{
							using (var db = new PowerStations_datEntities())
							{
								// Get a list of 1 second readings for a 15-minute period
								List<PowerReading10> _dbRecords = (db.PowerReading10
									.Where(r => r.ReadingMinute >= _startMinute && r.ReadingMinute < _lastMinute)
									.Select(r => r))
									.ToList();

								// If list of records read OK...
								if (_dbRecords != null)
								{
									// Create an array to return the requested data.
									_results.PowerUsage = new decimal[_dbRecords.Count];

									// Loop thru each 1-second DB record
									int x = 0;
									foreach (var record in _dbRecords)
									{
										// Now split off to get a reading from the requested station number.
										switch (_results.StationNumber)
										{
											case (1):
												{
													_results.PowerUsage[x++] = record.Station01PowerUsage;
													break;
												}
											case (2):
												{
													_results.PowerUsage[x++] = record.Station02PowerUsage;
													break;
												}
											case (3):
												{
													_results.PowerUsage[x++] = record.Station03PowerUsage;
													break;
												}
											case (4):
												{
													_results.PowerUsage[x++] = record.Station04PowerUsage;
													break;
												}
											case (5):
												{
													_results.PowerUsage[x++] = record.Station05PowerUsage;
													break;
												}
											case (6):
												{
													_results.PowerUsage[x++] = record.Station06PowerUsage;
													break;
												}
											case (7):
												{
													_results.PowerUsage[x++] = record.Station07PowerUsage;
													break;
												}
											case (8):
												{
													_results.PowerUsage[x++] = record.Station08PowerUsage;
													break;
												}
											case (9):
												{
													_results.PowerUsage[x++] = record.Station09PowerUsage;
													break;
												}
											case (10):
												{
													_results.PowerUsage[x++] = record.Station10PowerUsage;
													break;
												}
										}           // End switch by station number
									}               // End foreach loop thru DB records
								}                   // End list of DB records null check
							}                       // End using DB entities
							break;
						}                           // End this hour 'case'

					case (11):                       // Case for hour '11' (11:00:00 to 11:59:59)
						{
							using (var db = new PowerStations_datEntities())
							{
								// Get a list of 1 second readings for a 15-minute period
								List<PowerReading11> _dbRecords = (db.PowerReading11
									.Where(r => r.ReadingMinute >= _startMinute && r.ReadingMinute < _lastMinute)
									.Select(r => r))
									.ToList();

								// If list of records read OK...
								if (_dbRecords != null)
								{
									// Create an array to return the requested data.
									_results.PowerUsage = new decimal[_dbRecords.Count];

									// Loop thru each 1-second DB record
									int x = 0;
									foreach (var record in _dbRecords)
									{
										// Now split off to get a reading from the requested station number.
										switch (_results.StationNumber)
										{
											case (1):
												{
													_results.PowerUsage[x++] = record.Station01PowerUsage;
													break;
												}
											case (2):
												{
													_results.PowerUsage[x++] = record.Station02PowerUsage;
													break;
												}
											case (3):
												{
													_results.PowerUsage[x++] = record.Station03PowerUsage;
													break;
												}
											case (4):
												{
													_results.PowerUsage[x++] = record.Station04PowerUsage;
													break;
												}
											case (5):
												{
													_results.PowerUsage[x++] = record.Station05PowerUsage;
													break;
												}
											case (6):
												{
													_results.PowerUsage[x++] = record.Station06PowerUsage;
													break;
												}
											case (7):
												{
													_results.PowerUsage[x++] = record.Station07PowerUsage;
													break;
												}
											case (8):
												{
													_results.PowerUsage[x++] = record.Station08PowerUsage;
													break;
												}
											case (9):
												{
													_results.PowerUsage[x++] = record.Station09PowerUsage;
													break;
												}
											case (10):
												{
													_results.PowerUsage[x++] = record.Station10PowerUsage;
													break;
												}
										}           // End switch by station number
									}               // End foreach loop thru DB records
								}                   // End list of DB records null check
							}                       // End using DB entities
							break;
						}                           // End this hour 'case'

					case (12):                       // Case for hour '12' (12:00:00 to 12:59:59)
						{
							using (var db = new PowerStations_datEntities())
							{
								// Get a list of 1 second readings for a 15-minute period
								List<PowerReading12> _dbRecords = (db.PowerReading12
									.Where(r => r.ReadingMinute >= _startMinute && r.ReadingMinute < _lastMinute)
									.Select(r => r))
									.ToList();

								// If list of records read OK...
								if (_dbRecords != null)
								{
									// Create an array to return the requested data.
									_results.PowerUsage = new decimal[_dbRecords.Count];

									// Loop thru each 1-second DB record
									int x = 0;
									foreach (var record in _dbRecords)
									{
										// Now split off to get a reading from the requested station number.
										switch (_results.StationNumber)
										{
											case (1):
												{
													_results.PowerUsage[x++] = record.Station01PowerUsage;
													break;
												}
											case (2):
												{
													_results.PowerUsage[x++] = record.Station02PowerUsage;
													break;
												}
											case (3):
												{
													_results.PowerUsage[x++] = record.Station03PowerUsage;
													break;
												}
											case (4):
												{
													_results.PowerUsage[x++] = record.Station04PowerUsage;
													break;
												}
											case (5):
												{
													_results.PowerUsage[x++] = record.Station05PowerUsage;
													break;
												}
											case (6):
												{
													_results.PowerUsage[x++] = record.Station06PowerUsage;
													break;
												}
											case (7):
												{
													_results.PowerUsage[x++] = record.Station07PowerUsage;
													break;
												}
											case (8):
												{
													_results.PowerUsage[x++] = record.Station08PowerUsage;
													break;
												}
											case (9):
												{
													_results.PowerUsage[x++] = record.Station09PowerUsage;
													break;
												}
											case (10):
												{
													_results.PowerUsage[x++] = record.Station10PowerUsage;
													break;
												}
										}           // End switch by station number
									}               // End foreach loop thru DB records
								}                   // End list of DB records null check
							}                       // End using DB entities
							break;
						}                           // End this hour 'case'

					case (13):                       // Case for hour '13' (13:00:00 to 13:59:59)
						{
							using (var db = new PowerStations_datEntities())
							{
								// Get a list of 1 second readings for a 15-minute period
								List<PowerReading13> _dbRecords = (db.PowerReading13
									.Where(r => r.ReadingMinute >= _startMinute && r.ReadingMinute < _lastMinute)
									.Select(r => r))
									.ToList();

								// If list of records read OK...
								if (_dbRecords != null)
								{
									// Create an array to return the requested data.
									_results.PowerUsage = new decimal[_dbRecords.Count];

									// Loop thru each 1-second DB record
									int x = 0;
									foreach (var record in _dbRecords)
									{
										// Now split off to get a reading from the requested station number.
										switch (_results.StationNumber)
										{
											case (1):
												{
													_results.PowerUsage[x++] = record.Station01PowerUsage;
													break;
												}
											case (2):
												{
													_results.PowerUsage[x++] = record.Station02PowerUsage;
													break;
												}
											case (3):
												{
													_results.PowerUsage[x++] = record.Station03PowerUsage;
													break;
												}
											case (4):
												{
													_results.PowerUsage[x++] = record.Station04PowerUsage;
													break;
												}
											case (5):
												{
													_results.PowerUsage[x++] = record.Station05PowerUsage;
													break;
												}
											case (6):
												{
													_results.PowerUsage[x++] = record.Station06PowerUsage;
													break;
												}
											case (7):
												{
													_results.PowerUsage[x++] = record.Station07PowerUsage;
													break;
												}
											case (8):
												{
													_results.PowerUsage[x++] = record.Station08PowerUsage;
													break;
												}
											case (9):
												{
													_results.PowerUsage[x++] = record.Station09PowerUsage;
													break;
												}
											case (10):
												{
													_results.PowerUsage[x++] = record.Station10PowerUsage;
													break;
												}
										}           // End switch by station number
									}               // End foreach loop thru DB records
								}                   // End list of DB records null check
							}                       // End using DB entities
							break;
						}                           // End this hour 'case'

					case (14):                       // Case for hour '14' (14:00:00 to 14:59:59)
						{
							using (var db = new PowerStations_datEntities())
							{
								// Get a list of 1 second readings for a 15-minute period
								List<PowerReading14> _dbRecords = (db.PowerReading14
									.Where(r => r.ReadingMinute >= _startMinute && r.ReadingMinute < _lastMinute)
									.Select(r => r))
									.ToList();

								// If list of records read OK...
								if (_dbRecords != null)
								{
									// Create an array to return the requested data.
									_results.PowerUsage = new decimal[_dbRecords.Count];

									// Loop thru each 1-second DB record
									int x = 0;
									foreach (var record in _dbRecords)
									{
										// Now split off to get a reading from the requested station number.
										switch (_results.StationNumber)
										{
											case (1):
												{
													_results.PowerUsage[x++] = record.Station01PowerUsage;
													break;
												}
											case (2):
												{
													_results.PowerUsage[x++] = record.Station02PowerUsage;
													break;
												}
											case (3):
												{
													_results.PowerUsage[x++] = record.Station03PowerUsage;
													break;
												}
											case (4):
												{
													_results.PowerUsage[x++] = record.Station04PowerUsage;
													break;
												}
											case (5):
												{
													_results.PowerUsage[x++] = record.Station05PowerUsage;
													break;
												}
											case (6):
												{
													_results.PowerUsage[x++] = record.Station06PowerUsage;
													break;
												}
											case (7):
												{
													_results.PowerUsage[x++] = record.Station07PowerUsage;
													break;
												}
											case (8):
												{
													_results.PowerUsage[x++] = record.Station08PowerUsage;
													break;
												}
											case (9):
												{
													_results.PowerUsage[x++] = record.Station09PowerUsage;
													break;
												}
											case (10):
												{
													_results.PowerUsage[x++] = record.Station10PowerUsage;
													break;
												}
										}           // End switch by station number
									}               // End foreach loop thru DB records
								}                   // End list of DB records null check
							}                       // End using DB entities
							break;
						}                           // End this hour 'case'

					case (15):                       // Case for hour '15' (15:00:00 to 15:59:59)
						{
							using (var db = new PowerStations_datEntities())
							{
								// Get a list of 1 second readings for a 15-minute period
								List<PowerReading15> _dbRecords = (db.PowerReading15
									.Where(r => r.ReadingMinute >= _startMinute && r.ReadingMinute < _lastMinute)
									.Select(r => r))
									.ToList();

								// If list of records read OK...
								if (_dbRecords != null)
								{
									// Create an array to return the requested data.
									_results.PowerUsage = new decimal[_dbRecords.Count];

									// Loop thru each 1-second DB record
									int x = 0;
									foreach (var record in _dbRecords)
									{
										// Now split off to get a reading from the requested station number.
										switch (_results.StationNumber)
										{
											case (1):
												{
													_results.PowerUsage[x++] = record.Station01PowerUsage;
													break;
												}
											case (2):
												{
													_results.PowerUsage[x++] = record.Station02PowerUsage;
													break;
												}
											case (3):
												{
													_results.PowerUsage[x++] = record.Station03PowerUsage;
													break;
												}
											case (4):
												{
													_results.PowerUsage[x++] = record.Station04PowerUsage;
													break;
												}
											case (5):
												{
													_results.PowerUsage[x++] = record.Station05PowerUsage;
													break;
												}
											case (6):
												{
													_results.PowerUsage[x++] = record.Station06PowerUsage;
													break;
												}
											case (7):
												{
													_results.PowerUsage[x++] = record.Station07PowerUsage;
													break;
												}
											case (8):
												{
													_results.PowerUsage[x++] = record.Station08PowerUsage;
													break;
												}
											case (9):
												{
													_results.PowerUsage[x++] = record.Station09PowerUsage;
													break;
												}
											case (10):
												{
													_results.PowerUsage[x++] = record.Station10PowerUsage;
													break;
												}
										}           // End switch by station number
									}               // End foreach loop thru DB records
								}                   // End list of DB records null check
							}                       // End using DB entities
							break;
						}                           // End this hour 'case'

					case (16):                       // Case for hour '16' (16:00:00 to 16:59:59)
						{
							using (var db = new PowerStations_datEntities())
							{
								// Get a list of 1 second readings for a 15-minute period
								List<PowerReading16> _dbRecords = (db.PowerReading16
									.Where(r => r.ReadingMinute >= _startMinute && r.ReadingMinute < _lastMinute)
									.Select(r => r))
									.ToList();

								// If list of records read OK...
								if (_dbRecords != null)
								{
									// Create an array to return the requested data.
									_results.PowerUsage = new decimal[_dbRecords.Count];

									// Loop thru each 1-second DB record
									int x = 0;
									foreach (var record in _dbRecords)
									{
										// Now split off to get a reading from the requested station number.
										switch (_results.StationNumber)
										{
											case (1):
												{
													_results.PowerUsage[x++] = record.Station01PowerUsage;
													break;
												}
											case (2):
												{
													_results.PowerUsage[x++] = record.Station02PowerUsage;
													break;
												}
											case (3):
												{
													_results.PowerUsage[x++] = record.Station03PowerUsage;
													break;
												}
											case (4):
												{
													_results.PowerUsage[x++] = record.Station04PowerUsage;
													break;
												}
											case (5):
												{
													_results.PowerUsage[x++] = record.Station05PowerUsage;
													break;
												}
											case (6):
												{
													_results.PowerUsage[x++] = record.Station06PowerUsage;
													break;
												}
											case (7):
												{
													_results.PowerUsage[x++] = record.Station07PowerUsage;
													break;
												}
											case (8):
												{
													_results.PowerUsage[x++] = record.Station08PowerUsage;
													break;
												}
											case (9):
												{
													_results.PowerUsage[x++] = record.Station09PowerUsage;
													break;
												}
											case (10):
												{
													_results.PowerUsage[x++] = record.Station10PowerUsage;
													break;
												}
										}           // End switch by station number
									}               // End foreach loop thru DB records
								}                   // End list of DB records null check
							}                       // End using DB entities
							break;
						}                           // End this hour 'case'

					case (17):                       // Case for hour '17' (17:00:00 to 17:59:59)
						{
							using (var db = new PowerStations_datEntities())
							{
								// Get a list of 1 second readings for a 15-minute period
								List<PowerReading17> _dbRecords = (db.PowerReading17
									.Where(r => r.ReadingMinute >= _startMinute && r.ReadingMinute < _lastMinute)
									.Select(r => r))
									.ToList();

								// If list of records read OK...
								if (_dbRecords != null)
								{
									// Create an array to return the requested data.
									_results.PowerUsage = new decimal[_dbRecords.Count];

									// Loop thru each 1-second DB record
									int x = 0;
									foreach (var record in _dbRecords)
									{
										// Now split off to get a reading from the requested station number.
										switch (_results.StationNumber)
										{
											case (1):
												{
													_results.PowerUsage[x++] = record.Station01PowerUsage;
													break;
												}
											case (2):
												{
													_results.PowerUsage[x++] = record.Station02PowerUsage;
													break;
												}
											case (3):
												{
													_results.PowerUsage[x++] = record.Station03PowerUsage;
													break;
												}
											case (4):
												{
													_results.PowerUsage[x++] = record.Station04PowerUsage;
													break;
												}
											case (5):
												{
													_results.PowerUsage[x++] = record.Station05PowerUsage;
													break;
												}
											case (6):
												{
													_results.PowerUsage[x++] = record.Station06PowerUsage;
													break;
												}
											case (7):
												{
													_results.PowerUsage[x++] = record.Station07PowerUsage;
													break;
												}
											case (8):
												{
													_results.PowerUsage[x++] = record.Station08PowerUsage;
													break;
												}
											case (9):
												{
													_results.PowerUsage[x++] = record.Station09PowerUsage;
													break;
												}
											case (10):
												{
													_results.PowerUsage[x++] = record.Station10PowerUsage;
													break;
												}
										}           // End switch by station number
									}               // End foreach loop thru DB records
								}                   // End list of DB records null check
							}                       // End using DB entities
							break;
						}                           // End this hour 'case'

					case (18):                       // Case for hour '18' (18:00:00 to 18:59:59)
						{
							using (var db = new PowerStations_datEntities())
							{
								// Get a list of 1 second readings for a 15-minute period
								List<PowerReading18> _dbRecords = (db.PowerReading18
									.Where(r => r.ReadingMinute >= _startMinute && r.ReadingMinute < _lastMinute)
									.Select(r => r))
									.ToList();

								// If list of records read OK...
								if (_dbRecords != null)
								{
									// Create an array to return the requested data.
									_results.PowerUsage = new decimal[_dbRecords.Count];

									// Loop thru each 1-second DB record
									int x = 0;
									foreach (var record in _dbRecords)
									{
										// Now split off to get a reading from the requested station number.
										switch (_results.StationNumber)
										{
											case (1):
												{
													_results.PowerUsage[x++] = record.Station01PowerUsage;
													break;
												}
											case (2):
												{
													_results.PowerUsage[x++] = record.Station02PowerUsage;
													break;
												}
											case (3):
												{
													_results.PowerUsage[x++] = record.Station03PowerUsage;
													break;
												}
											case (4):
												{
													_results.PowerUsage[x++] = record.Station04PowerUsage;
													break;
												}
											case (5):
												{
													_results.PowerUsage[x++] = record.Station05PowerUsage;
													break;
												}
											case (6):
												{
													_results.PowerUsage[x++] = record.Station06PowerUsage;
													break;
												}
											case (7):
												{
													_results.PowerUsage[x++] = record.Station07PowerUsage;
													break;
												}
											case (8):
												{
													_results.PowerUsage[x++] = record.Station08PowerUsage;
													break;
												}
											case (9):
												{
													_results.PowerUsage[x++] = record.Station09PowerUsage;
													break;
												}
											case (10):
												{
													_results.PowerUsage[x++] = record.Station10PowerUsage;
													break;
												}
										}           // End switch by station number
									}               // End foreach loop thru DB records
								}                   // End list of DB records null check
							}                       // End using DB entities
							break;
						}                           // End this hour 'case'

					case (19):                       // Case for hour '19' (19:00:00 to 19:59:59)
						{
							using (var db = new PowerStations_datEntities())
							{
								// Get a list of 1 second readings for a 15-minute period
								List<PowerReading19> _dbRecords = (db.PowerReading19
									.Where(r => r.ReadingMinute >= _startMinute && r.ReadingMinute < _lastMinute)
									.Select(r => r))
									.ToList();

								// If list of records read OK...
								if (_dbRecords != null)
								{
									// Create an array to return the requested data.
									_results.PowerUsage = new decimal[_dbRecords.Count];

									// Loop thru each 1-second DB record
									int x = 0;
									foreach (var record in _dbRecords)
									{
										// Now split off to get a reading from the requested station number.
										switch (_results.StationNumber)
										{
											case (1):
												{
													_results.PowerUsage[x++] = record.Station01PowerUsage;
													break;
												}
											case (2):
												{
													_results.PowerUsage[x++] = record.Station02PowerUsage;
													break;
												}
											case (3):
												{
													_results.PowerUsage[x++] = record.Station03PowerUsage;
													break;
												}
											case (4):
												{
													_results.PowerUsage[x++] = record.Station04PowerUsage;
													break;
												}
											case (5):
												{
													_results.PowerUsage[x++] = record.Station05PowerUsage;
													break;
												}
											case (6):
												{
													_results.PowerUsage[x++] = record.Station06PowerUsage;
													break;
												}
											case (7):
												{
													_results.PowerUsage[x++] = record.Station07PowerUsage;
													break;
												}
											case (8):
												{
													_results.PowerUsage[x++] = record.Station08PowerUsage;
													break;
												}
											case (9):
												{
													_results.PowerUsage[x++] = record.Station09PowerUsage;
													break;
												}
											case (10):
												{
													_results.PowerUsage[x++] = record.Station10PowerUsage;
													break;
												}
										}           // End switch by station number
									}               // End foreach loop thru DB records
								}                   // End list of DB records null check
							}                       // End using DB entities
							break;
						}                           // End this hour 'case'

					case (20):                       // Case for hour '20' (20:00:00 to 20:59:59)
						{
							using (var db = new PowerStations_datEntities())
							{
								// Get a list of 1 second readings for a 15-minute period
								List<PowerReading20> _dbRecords = (db.PowerReading20
									.Where(r => r.ReadingMinute >= _startMinute && r.ReadingMinute < _lastMinute)
									.Select(r => r))
									.ToList();

								// If list of records read OK...
								if (_dbRecords != null)
								{
									// Create an array to return the requested data.
									_results.PowerUsage = new decimal[_dbRecords.Count];

									// Loop thru each 1-second DB record
									int x = 0;
									foreach (var record in _dbRecords)
									{
										// Now split off to get a reading from the requested station number.
										switch (_results.StationNumber)
										{
											case (1):
												{
													_results.PowerUsage[x++] = record.Station01PowerUsage;
													break;
												}
											case (2):
												{
													_results.PowerUsage[x++] = record.Station02PowerUsage;
													break;
												}
											case (3):
												{
													_results.PowerUsage[x++] = record.Station03PowerUsage;
													break;
												}
											case (4):
												{
													_results.PowerUsage[x++] = record.Station04PowerUsage;
													break;
												}
											case (5):
												{
													_results.PowerUsage[x++] = record.Station05PowerUsage;
													break;
												}
											case (6):
												{
													_results.PowerUsage[x++] = record.Station06PowerUsage;
													break;
												}
											case (7):
												{
													_results.PowerUsage[x++] = record.Station07PowerUsage;
													break;
												}
											case (8):
												{
													_results.PowerUsage[x++] = record.Station08PowerUsage;
													break;
												}
											case (9):
												{
													_results.PowerUsage[x++] = record.Station09PowerUsage;
													break;
												}
											case (10):
												{
													_results.PowerUsage[x++] = record.Station10PowerUsage;
													break;
												}
										}           // End switch by station number
									}               // End foreach loop thru DB records
								}                   // End list of DB records null check
							}                       // End using DB entities
							break;
						}                           // End this hour 'case'

					case (21):                       // Case for hour '21' (21:00:00 to 21:59:59)
						{
							using (var db = new PowerStations_datEntities())
							{
								// Get a list of 1 second readings for a 15-minute period
								List<PowerReading21> _dbRecords = (db.PowerReading21
									.Where(r => r.ReadingMinute >= _startMinute && r.ReadingMinute < _lastMinute)
									.Select(r => r))
									.ToList();

								// If list of records read OK...
								if (_dbRecords != null)
								{
									// Create an array to return the requested data.
									_results.PowerUsage = new decimal[_dbRecords.Count];

									// Loop thru each 1-second DB record
									int x = 0;
									foreach (var record in _dbRecords)
									{
										// Now split off to get a reading from the requested station number.
										switch (_results.StationNumber)
										{
											case (1):
												{
													_results.PowerUsage[x++] = record.Station01PowerUsage;
													break;
												}
											case (2):
												{
													_results.PowerUsage[x++] = record.Station02PowerUsage;
													break;
												}
											case (3):
												{
													_results.PowerUsage[x++] = record.Station03PowerUsage;
													break;
												}
											case (4):
												{
													_results.PowerUsage[x++] = record.Station04PowerUsage;
													break;
												}
											case (5):
												{
													_results.PowerUsage[x++] = record.Station05PowerUsage;
													break;
												}
											case (6):
												{
													_results.PowerUsage[x++] = record.Station06PowerUsage;
													break;
												}
											case (7):
												{
													_results.PowerUsage[x++] = record.Station07PowerUsage;
													break;
												}
											case (8):
												{
													_results.PowerUsage[x++] = record.Station08PowerUsage;
													break;
												}
											case (9):
												{
													_results.PowerUsage[x++] = record.Station09PowerUsage;
													break;
												}
											case (10):
												{
													_results.PowerUsage[x++] = record.Station10PowerUsage;
													break;
												}
										}           // End switch by station number
									}               // End foreach loop thru DB records
								}                   // End list of DB records null check
							}                       // End using DB entities
							break;
						}                           // End this hour 'case'

					case (22):                       // Case for hour '22' (22:00:00 to 22:59:59)
						{
							using (var db = new PowerStations_datEntities())
							{
								// Get a list of 1 second readings for a 15-minute period
								List<PowerReading22> _dbRecords = (db.PowerReading22
									.Where(r => r.ReadingMinute >= _startMinute && r.ReadingMinute < _lastMinute)
									.Select(r => r))
									.ToList();

								// If list of records read OK...
								if (_dbRecords != null)
								{
									// Create an array to return the requested data.
									_results.PowerUsage = new decimal[_dbRecords.Count];

									// Loop thru each 1-second DB record
									int x = 0;
									foreach (var record in _dbRecords)
									{
										// Now split off to get a reading from the requested station number.
										switch (_results.StationNumber)
										{
											case (1):
												{
													_results.PowerUsage[x++] = record.Station01PowerUsage;
													break;
												}
											case (2):
												{
													_results.PowerUsage[x++] = record.Station02PowerUsage;
													break;
												}
											case (3):
												{
													_results.PowerUsage[x++] = record.Station03PowerUsage;
													break;
												}
											case (4):
												{
													_results.PowerUsage[x++] = record.Station04PowerUsage;
													break;
												}
											case (5):
												{
													_results.PowerUsage[x++] = record.Station05PowerUsage;
													break;
												}
											case (6):
												{
													_results.PowerUsage[x++] = record.Station06PowerUsage;
													break;
												}
											case (7):
												{
													_results.PowerUsage[x++] = record.Station07PowerUsage;
													break;
												}
											case (8):
												{
													_results.PowerUsage[x++] = record.Station08PowerUsage;
													break;
												}
											case (9):
												{
													_results.PowerUsage[x++] = record.Station09PowerUsage;
													break;
												}
											case (10):
												{
													_results.PowerUsage[x++] = record.Station10PowerUsage;
													break;
												}
										}           // End switch by station number
									}               // End foreach loop thru DB records
								}                   // End list of DB records null check
							}                       // End using DB entities
							break;
						}                           // End this hour 'case'

					case (23):                       // Case for hour '23' (23:00:00 to 23:59:59)
						{
							using (var db = new PowerStations_datEntities())
							{
								// Get a list of 1 second readings for a 15-minute period
								List<PowerReading23> _dbRecords = (db.PowerReading23
									.Where(r => r.ReadingMinute >= _startMinute && r.ReadingMinute < _lastMinute)
									.Select(r => r))
									.ToList();

								// If list of records read OK...
								if (_dbRecords != null)
								{
									// Create an array to return the requested data.
									_results.PowerUsage = new decimal[_dbRecords.Count];

									// Loop thru each 1-second DB record
									int x = 0;
									foreach (var record in _dbRecords)
									{
										// Now split off to get a reading from the requested station number.
										switch (_results.StationNumber)
										{
											case (1):
												{
													_results.PowerUsage[x++] = record.Station01PowerUsage;
													break;
												}
											case (2):
												{
													_results.PowerUsage[x++] = record.Station02PowerUsage;
													break;
												}
											case (3):
												{
													_results.PowerUsage[x++] = record.Station03PowerUsage;
													break;
												}
											case (4):
												{
													_results.PowerUsage[x++] = record.Station04PowerUsage;
													break;
												}
											case (5):
												{
													_results.PowerUsage[x++] = record.Station05PowerUsage;
													break;
												}
											case (6):
												{
													_results.PowerUsage[x++] = record.Station06PowerUsage;
													break;
												}
											case (7):
												{
													_results.PowerUsage[x++] = record.Station07PowerUsage;
													break;
												}
											case (8):
												{
													_results.PowerUsage[x++] = record.Station08PowerUsage;
													break;
												}
											case (9):
												{
													_results.PowerUsage[x++] = record.Station09PowerUsage;
													break;
												}
											case (10):
												{
													_results.PowerUsage[x++] = record.Station10PowerUsage;
													break;
												}
										}           // End switch by station number
									}               // End foreach loop thru DB records
								}                   // End list of DB records null check
							}                       // End using DB entities
							break;
						}                           // End this hour 'case'

				}           // End of switch by hour
			}
			catch (Exception ex)
			{
				_results.ErrorMessage = ex.Message;
			}
			return _results;
		}
		#endregion

	}
}
