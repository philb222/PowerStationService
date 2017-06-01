using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AdminPowerStations.Helpers
{
    public static class DbFunctions
    {

        static string[] _StationNames = { "Surrey Station", "West Vancouver Station", "North Vancouver Station", "Vancouver Station",
        "Burnaby Station", "North Burnaby Station", "Port Moody Station", "Coquitlam Station", "Port Coquitlam Station", "Maple Ridge Station"};

        static string[] _StationLocations = { "1020 Central Street, Surrey", " 20445 Pender Ave, West Vancouver", "8554 Main Street, North Vancouver", "20504 Broadway, Vancouver",
        "24550 Kingsway, Burnaby", "4020 Beta Street, North Burnaby", "22005 Central Bld, Port Moody", "1234 Main Street, Coquitlam", "2040 Bellham Ave, Port Coquitlam",
            " 4244 Maple Street, Maple Ridge" };

		static string[] _StationPhones = { "604-245-0001", "604-245-0002", "604-245-0003", "604-245-0004",
			"604-245-0005", "604-245-0006", "604-245-0007", "604-245-0008", "604-245-0009",	"604-245-0010" };

		#region Init / Create DB records
		public static void PopulateDB()
        {
            int _totalRecords = 0;

            try
            {
                CreatePowerStations();

				int Seed = 31;

                // Now create readings for each hour of a day (00 to 23).
                Task<int> task1 = InitHour00(Seed);
                Task<int> task2 = InitHour01(Seed * 2);
                Task<int> task3 = InitHour02(Seed * 3);
                Task<int> task4 = InitHour03(Seed * 4);
                Task<int> task5 = InitHour04(Seed * 5);
                Task<int> task6 = InitHour05(Seed * 6);
                Task.WaitAll(task1, task2, task3, task4, task5, task6);

                _totalRecords += task1.Result;
                _totalRecords += task2.Result;
                _totalRecords += task3.Result;
                _totalRecords += task4.Result;
                _totalRecords += task5.Result;
                _totalRecords += task6.Result;

                task1 = InitHour06(Seed * 7);
                task2 = InitHour07(Seed * 8);
                task3 = InitHour08(Seed * 9);
                task4 = InitHour09(Seed * 10);
                task5 = InitHour10(Seed * 11);
                task6 = InitHour11(Seed * 12);
                Task.WaitAll(task1, task2, task3, task4, task5, task6);

                _totalRecords += task1.Result;
                _totalRecords += task2.Result;
                _totalRecords += task3.Result;
                _totalRecords += task4.Result;
                _totalRecords += task5.Result;
                _totalRecords += task6.Result;

                task1 = InitHour12(Seed * 13);
                task2 = InitHour13(Seed * 14);
                task3 = InitHour14(Seed * 15);
                task4 = InitHour15(Seed * 16);
                task5 = InitHour16(Seed * 17);
                task6 = InitHour17(Seed * 18);
                Task.WaitAll(task1, task2, task3, task4, task5, task6);

                _totalRecords += task1.Result;
                _totalRecords += task2.Result;
                _totalRecords += task3.Result;
                _totalRecords += task4.Result;
                _totalRecords += task5.Result;
                _totalRecords += task6.Result;

                task1 = InitHour18(Seed * 19);
                task2 = InitHour19(Seed * 20);
                task3 = InitHour20(Seed * 21);
                task4 = InitHour21(Seed * 22);
                task5 = InitHour22(Seed * 23);
                task6 = InitHour23(Seed * 24);
                Task.WaitAll(task1, task2, task3, task4, task5, task6);

                _totalRecords += task1.Result;
                _totalRecords += task2.Result;
                _totalRecords += task3.Result;
                _totalRecords += task4.Result;
                _totalRecords += task5.Result;
                _totalRecords += task6.Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void CreatePowerStations()
        {
            PowerStation _station = null;

            using (var conx = new PowerStations_datEntities())
            {
                for (int x = 0; x < _StationNames.Count(); ++x)
                {
                    _station = new PowerStation()
                    {
                        Name = _StationNames[x],
                        Location = _StationLocations[x],
						Phone = _StationPhones[x],
						Online = true
                    };
                    conx.PowerStations.Add(_station);
                }
                conx.SaveChanges();
            }
        }

        /// <summary>
        /// Initialize an hour's worth of data.
        /// </summary>
        /// <returns>Number of records added.</returns>
        private static Task<int> InitHour00(int seedNumber)
        {
            int _recCount = 0;
            return Task.Run(() =>
            {
                Random _ranGen = new Random(seedNumber);
                PowerReading00 _reading = null;

                using (var conx = new PowerStations_datEntities())
                {

                    for (byte _minute = 0; _minute < 60; ++_minute)
                    {
                        for (byte _second = 0; _second < 60; ++_second)
                        {
                            _reading = new PowerReading00();

                            _reading.ReadingMinute = _minute;
                            _reading.ReadingSecond = _second;

                            _reading.Station01PowerUsage = (_ranGen.Next(60000, 90000)) / 1000m;
                            _reading.Station02PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station03PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station04PowerUsage = (_ranGen.Next(80000, 110000)) / 1000m;
                            _reading.Station05PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station06PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station07PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station08PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station09PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station10PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;

                            conx.PowerReading00.Add(_reading);
                        };
                        _recCount += conx.SaveChanges();
                    };
                }
                return _recCount;
            });
        }

        private static Task<int> InitHour01(int seedNumber)
        {
            int _recCount = 0;
            return Task.Run(() =>
            {
                Random _ranGen = new Random(seedNumber);
                PowerReading01 _reading = null;

                using (var conx = new PowerStations_datEntities())
                {

                    for (byte _minute = 0; _minute < 60; ++_minute)
                    {
                        for (byte _second = 0; _second < 60; ++_second)
                        {
                            _reading = new PowerReading01();

                            _reading.ReadingMinute = _minute;
                            _reading.ReadingSecond = _second;

                            _reading.Station01PowerUsage = (_ranGen.Next(60000, 90000)) / 1000m;
                            _reading.Station02PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station03PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station04PowerUsage = (_ranGen.Next(80000, 110000)) / 1000m;
                            _reading.Station05PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station06PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station07PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station08PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station09PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station10PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;

                            conx.PowerReading01.Add(_reading);
                        };
                        _recCount += conx.SaveChanges();
                    };
                }
                return _recCount;
            });
        }

        private static Task<int> InitHour02(int seedNumber)
        {
            int _recCount = 0;
            return Task.Run(() =>
            {
                Random _ranGen = new Random(seedNumber);
                PowerReading02 _reading = null;

                using (var conx = new PowerStations_datEntities())
                {

                    for (byte _minute = 0; _minute < 60; ++_minute)
                    {
                        for (byte _second = 0; _second < 60; ++_second)
                        {
                            _reading = new PowerReading02();

                            _reading.ReadingMinute = _minute;
                            _reading.ReadingSecond = _second;

                            _reading.Station01PowerUsage = (_ranGen.Next(60000, 90000)) / 1000m;
                            _reading.Station02PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station03PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station04PowerUsage = (_ranGen.Next(80000, 110000)) / 1000m;
                            _reading.Station05PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station06PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station07PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station08PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station09PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station10PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;

                            conx.PowerReading02.Add(_reading);
                        };
                        _recCount += conx.SaveChanges();
                    };
                }
                return _recCount;
            });
        }

        private static Task<int> InitHour03(int seedNumber)
        {
            int _recCount = 0;
            return Task.Run(() =>
            {
                Random _ranGen = new Random(seedNumber);
                PowerReading03 _reading = null;

                using (var conx = new PowerStations_datEntities())
                {

                    for (byte _minute = 0; _minute < 60; ++_minute)
                    {
                        for (byte _second = 0; _second < 60; ++_second)
                        {
                            _reading = new PowerReading03();

                            _reading.ReadingMinute = _minute;
                            _reading.ReadingSecond = _second;

                            _reading.Station01PowerUsage = (_ranGen.Next(60000, 90000)) / 1000m;
                            _reading.Station02PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station03PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station04PowerUsage = (_ranGen.Next(80000, 110000)) / 1000m;
                            _reading.Station05PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station06PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station07PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station08PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station09PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station10PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;

                            conx.PowerReading03.Add(_reading);
                        };
                        _recCount += conx.SaveChanges();
                    };
                }
                return _recCount;
            });
        }

        private static Task<int> InitHour04(int seedNumber)
        {
            int _recCount = 0;
            return Task.Run(() =>
            {
                Random _ranGen = new Random(seedNumber);
                PowerReading04 _reading = null;

                using (var conx = new PowerStations_datEntities())
                {

                    for (byte _minute = 0; _minute < 60; ++_minute)
                    {
                        for (byte _second = 0; _second < 60; ++_second)
                        {
                            _reading = new PowerReading04();

                            _reading.ReadingMinute = _minute;
                            _reading.ReadingSecond = _second;

                            _reading.Station01PowerUsage = (_ranGen.Next(60000, 90000)) / 1000m;
                            _reading.Station02PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station03PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station04PowerUsage = (_ranGen.Next(80000, 110000)) / 1000m;
                            _reading.Station05PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station06PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station07PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station08PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station09PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station10PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;

                            conx.PowerReading04.Add(_reading);
                        };
                        _recCount += conx.SaveChanges();
                    };
                }
                return _recCount;
            });
        }

        private static Task<int> InitHour05(int seedNumber)
        {
            int _recCount = 0;
            return Task.Run(() =>
            {
                Random _ranGen = new Random(seedNumber);
                PowerReading05 _reading = null;

                using (var conx = new PowerStations_datEntities())
                {

                    for (byte _minute = 0; _minute < 60; ++_minute)
                    {
                        for (byte _second = 0; _second < 60; ++_second)
                        {
                            _reading = new PowerReading05();

                            _reading.ReadingMinute = _minute;
                            _reading.ReadingSecond = _second;

                            _reading.Station01PowerUsage = (_ranGen.Next(60000, 90000)) / 1000m;
                            _reading.Station02PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station03PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station04PowerUsage = (_ranGen.Next(80000, 110000)) / 1000m;
                            _reading.Station05PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station06PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station07PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station08PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station09PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station10PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;

                            conx.PowerReading05.Add(_reading);
                        };
                        _recCount += conx.SaveChanges();
                    };
                }
                return _recCount;
            });
        }

        private static Task<int> InitHour06(int seedNumber)
        {
            int _recCount = 0;
            return Task.Run(() =>
            {
                Random _ranGen = new Random(seedNumber);
                PowerReading06 _reading = null;

                using (var conx = new PowerStations_datEntities())
                {

                    for (byte _minute = 0; _minute < 60; ++_minute)
                    {
                        for (byte _second = 0; _second < 60; ++_second)
                        {
                            _reading = new PowerReading06();

                            _reading.ReadingMinute = _minute;
                            _reading.ReadingSecond = _second;

                            _reading.Station01PowerUsage = (_ranGen.Next(60000, 90000)) / 1000m;
                            _reading.Station02PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station03PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station04PowerUsage = (_ranGen.Next(80000, 110000)) / 1000m;
                            _reading.Station05PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station06PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station07PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station08PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station09PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station10PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;

                            conx.PowerReading06.Add(_reading);
                        };
                        _recCount += conx.SaveChanges();
                    };
                }
                return _recCount;
            });
        }

        private static Task<int> InitHour07(int seedNumber)
        {
            int _recCount = 0;
            return Task.Run(() =>
            {
                Random _ranGen = new Random(seedNumber);
                PowerReading07 _reading = null;

                using (var conx = new PowerStations_datEntities())
                {

                    for (byte _minute = 0; _minute < 60; ++_minute)
                    {
                        for (byte _second = 0; _second < 60; ++_second)
                        {
                            _reading = new PowerReading07();

                            _reading.ReadingMinute = _minute;
                            _reading.ReadingSecond = _second;

                            _reading.Station01PowerUsage = (_ranGen.Next(60000, 90000)) / 1000m;
                            _reading.Station02PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station03PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station04PowerUsage = (_ranGen.Next(80000, 110000)) / 1000m;
                            _reading.Station05PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station06PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station07PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station08PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station09PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station10PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;

                            conx.PowerReading07.Add(_reading);
                        };
                        _recCount += conx.SaveChanges();
                    };
                }
                return _recCount;
            });
        }

        private static Task<int> InitHour08(int seedNumber)
        {
            int _recCount = 0;
            return Task.Run(() =>
            {
                Random _ranGen = new Random(seedNumber);
                PowerReading08 _reading = null;

                using (var conx = new PowerStations_datEntities())
                {

                    for (byte _minute = 0; _minute < 60; ++_minute)
                    {
                        for (byte _second = 0; _second < 60; ++_second)
                        {
                            _reading = new PowerReading08();

                            _reading.ReadingMinute = _minute;
                            _reading.ReadingSecond = _second;

                            _reading.Station01PowerUsage = (_ranGen.Next(60000, 90000)) / 1000m;
                            _reading.Station02PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station03PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station04PowerUsage = (_ranGen.Next(80000, 110000)) / 1000m;
                            _reading.Station05PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station06PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station07PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station08PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station09PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station10PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;

                            conx.PowerReading08.Add(_reading);
                        };
                        _recCount += conx.SaveChanges();
                    };
                }
                return _recCount;
            });
        }

        private static Task<int> InitHour09(int seedNumber)
        {
            int _recCount = 0;
            return Task.Run(() =>
            {
                Random _ranGen = new Random(seedNumber);
                PowerReading09 _reading = null;

                using (var conx = new PowerStations_datEntities())
                {

                    for (byte _minute = 0; _minute < 60; ++_minute)
                    {
                        for (byte _second = 0; _second < 60; ++_second)
                        {
                            _reading = new PowerReading09();

                            _reading.ReadingMinute = _minute;
                            _reading.ReadingSecond = _second;

                            _reading.Station01PowerUsage = (_ranGen.Next(60000, 90000)) / 1000m;
                            _reading.Station02PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station03PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station04PowerUsage = (_ranGen.Next(80000, 110000)) / 1000m;
                            _reading.Station05PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station06PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station07PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station08PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station09PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station10PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;

                            conx.PowerReading09.Add(_reading);
                        };
                        _recCount += conx.SaveChanges();
                    };
                }
                return _recCount;
            });
        }

        private static Task<int> InitHour10(int seedNumber)
        {
            int _recCount = 0;
            return Task.Run(() =>
            {
                Random _ranGen = new Random(seedNumber);
                PowerReading10 _reading = null;

                using (var conx = new PowerStations_datEntities())
                {

                    for (byte _minute = 0; _minute < 60; ++_minute)
                    {
                        for (byte _second = 0; _second < 60; ++_second)
                        {
                            _reading = new PowerReading10();

                            _reading.ReadingMinute = _minute;
                            _reading.ReadingSecond = _second;

                            _reading.Station01PowerUsage = (_ranGen.Next(60000, 90000)) / 1000m;
                            _reading.Station02PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station03PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station04PowerUsage = (_ranGen.Next(80000, 110000)) / 1000m;
                            _reading.Station05PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station06PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station07PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station08PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station09PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station10PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;

                            conx.PowerReading10.Add(_reading);
                        };
                        _recCount += conx.SaveChanges();
                    };
                }
                return _recCount;
            });
        }

        private static Task<int> InitHour11(int seedNumber)
        {
            int _recCount = 0;
            return Task.Run(() =>
            {
                Random _ranGen = new Random(seedNumber);
                PowerReading11 _reading = null;

                using (var conx = new PowerStations_datEntities())
                {

                    for (byte _minute = 0; _minute < 60; ++_minute)
                    {
                        for (byte _second = 0; _second < 60; ++_second)
                        {
                            _reading = new PowerReading11();

                            _reading.ReadingMinute = _minute;
                            _reading.ReadingSecond = _second;

                            _reading.Station01PowerUsage = (_ranGen.Next(60000, 90000)) / 1000m;
                            _reading.Station02PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station03PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station04PowerUsage = (_ranGen.Next(80000, 110000)) / 1000m;
                            _reading.Station05PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station06PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station07PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station08PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station09PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station10PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;

                            conx.PowerReading11.Add(_reading);
                        };
                        _recCount += conx.SaveChanges();
                    };
                }
                return _recCount;
            });
        }

        private static Task<int> InitHour12(int seedNumber)
        {
            int _recCount = 0;
            return Task.Run(() =>
            {
                Random _ranGen = new Random(seedNumber);
                PowerReading12 _reading = null;

                using (var conx = new PowerStations_datEntities())
                {

                    for (byte _minute = 0; _minute < 60; ++_minute)
                    {
                        for (byte _second = 0; _second < 60; ++_second)
                        {
                            _reading = new PowerReading12();

                            _reading.ReadingMinute = _minute;
                            _reading.ReadingSecond = _second;

                            _reading.Station01PowerUsage = (_ranGen.Next(60000, 90000)) / 1000m;
                            _reading.Station02PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station03PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station04PowerUsage = (_ranGen.Next(80000, 110000)) / 1000m;
                            _reading.Station05PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station06PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station07PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station08PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station09PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station10PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;

                            conx.PowerReading12.Add(_reading);
                        };
                        _recCount += conx.SaveChanges();
                    };
                }
                return _recCount;
            });
        }

        private static Task<int> InitHour13(int seedNumber)
        {
            int _recCount = 0;
            return Task.Run(() =>
            {
                Random _ranGen = new Random(seedNumber);
                PowerReading13 _reading = null;

                using (var conx = new PowerStations_datEntities())
                {

                    for (byte _minute = 0; _minute < 60; ++_minute)
                    {
                        for (byte _second = 0; _second < 60; ++_second)
                        {
                            _reading = new PowerReading13();

                            _reading.ReadingMinute = _minute;
                            _reading.ReadingSecond = _second;

                            _reading.Station01PowerUsage = (_ranGen.Next(60000, 90000)) / 1000m;
                            _reading.Station02PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station03PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station04PowerUsage = (_ranGen.Next(80000, 110000)) / 1000m;
                            _reading.Station05PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station06PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station07PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station08PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station09PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station10PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;

                            conx.PowerReading13.Add(_reading);
                        };
                        _recCount += conx.SaveChanges();
                    };
                }
                return _recCount;
            });
        }

        private static Task<int> InitHour14(int seedNumber)
        {
            int _recCount = 0;
            return Task.Run(() =>
            {
                Random _ranGen = new Random(seedNumber);
                PowerReading14 _reading = null;

                using (var conx = new PowerStations_datEntities())
                {

                    for (byte _minute = 0; _minute < 60; ++_minute)
                    {
                        for (byte _second = 0; _second < 60; ++_second)
                        {
                            _reading = new PowerReading14();

                            _reading.ReadingMinute = _minute;
                            _reading.ReadingSecond = _second;

                            _reading.Station01PowerUsage = (_ranGen.Next(60000, 90000)) / 1000m;
                            _reading.Station02PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station03PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station04PowerUsage = (_ranGen.Next(80000, 110000)) / 1000m;
                            _reading.Station05PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station06PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station07PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station08PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station09PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station10PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;

                            conx.PowerReading14.Add(_reading);
                        };
                        _recCount += conx.SaveChanges();
                    };
                }
                return _recCount;
            });
        }

        private static Task<int> InitHour15(int seedNumber)
        {
            int _recCount = 0;
            return Task.Run(() =>
            {
                Random _ranGen = new Random(seedNumber);
                PowerReading15 _reading = null;

                using (var conx = new PowerStations_datEntities())
                {

                    for (byte _minute = 0; _minute < 60; ++_minute)
                    {
                        for (byte _second = 0; _second < 60; ++_second)
                        {
                            _reading = new PowerReading15();

                            _reading.ReadingMinute = _minute;
                            _reading.ReadingSecond = _second;

                            _reading.Station01PowerUsage = (_ranGen.Next(60000, 90000)) / 1000m;
                            _reading.Station02PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station03PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station04PowerUsage = (_ranGen.Next(80000, 110000)) / 1000m;
                            _reading.Station05PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station06PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station07PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station08PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station09PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station10PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;

                            conx.PowerReading15.Add(_reading);
                        };
                        _recCount += conx.SaveChanges();
                    };
                }
                return _recCount;
            });
        }

        private static Task<int> InitHour16(int seedNumber)
        {
            int _recCount = 0;
            return Task.Run(() =>
            {
                Random _ranGen = new Random(seedNumber);
                PowerReading16 _reading = null;

                using (var conx = new PowerStations_datEntities())
                {

                    for (byte _minute = 0; _minute < 60; ++_minute)
                    {
                        for (byte _second = 0; _second < 60; ++_second)
                        {
                            _reading = new PowerReading16();

                            _reading.ReadingMinute = _minute;
                            _reading.ReadingSecond = _second;

                            _reading.Station01PowerUsage = (_ranGen.Next(60000, 90000)) / 1000m;
                            _reading.Station02PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station03PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station04PowerUsage = (_ranGen.Next(80000, 110000)) / 1000m;
                            _reading.Station05PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station06PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station07PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station08PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station09PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station10PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;

                            conx.PowerReading16.Add(_reading);
                        };
                        _recCount += conx.SaveChanges();
                    };
                }
                return _recCount;
            });
        }

        private static Task<int> InitHour17(int seedNumber)
        {
            int _recCount = 0;
            return Task.Run(() =>
            {
                Random _ranGen = new Random(seedNumber);
                PowerReading17 _reading = null;

                using (var conx = new PowerStations_datEntities())
                {

                    for (byte _minute = 0; _minute < 60; ++_minute)
                    {
                        for (byte _second = 0; _second < 60; ++_second)
                        {
                            _reading = new PowerReading17();

                            _reading.ReadingMinute = _minute;
                            _reading.ReadingSecond = _second;

                            _reading.Station01PowerUsage = (_ranGen.Next(60000, 90000)) / 1000m;
                            _reading.Station02PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station03PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station04PowerUsage = (_ranGen.Next(80000, 110000)) / 1000m;
                            _reading.Station05PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station06PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station07PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station08PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station09PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station10PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;

                            conx.PowerReading17.Add(_reading);
                        };
                        _recCount += conx.SaveChanges();
                    };
                }
                return _recCount;
            });
        }

        private static Task<int> InitHour18(int seedNumber)
        {
            int _recCount = 0;
            return Task.Run(() =>
            {
                Random _ranGen = new Random(seedNumber);
                PowerReading18 _reading = null;

                using (var conx = new PowerStations_datEntities())
                {

                    for (byte _minute = 0; _minute < 60; ++_minute)
                    {
                        for (byte _second = 0; _second < 60; ++_second)
                        {
                            _reading = new PowerReading18();

                            _reading.ReadingMinute = _minute;
                            _reading.ReadingSecond = _second;

                            _reading.Station01PowerUsage = (_ranGen.Next(60000, 90000)) / 1000m;
                            _reading.Station02PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station03PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station04PowerUsage = (_ranGen.Next(80000, 110000)) / 1000m;
                            _reading.Station05PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station06PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station07PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station08PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station09PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station10PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;

                            conx.PowerReading18.Add(_reading);
                        };
                        _recCount += conx.SaveChanges();
                    };
                }
                return _recCount;
            });
        }

        private static Task<int> InitHour19(int seedNumber)
        {
            int _recCount = 0;
            return Task.Run(() =>
            {
                Random _ranGen = new Random(seedNumber);
                PowerReading19 _reading = null;

                using (var conx = new PowerStations_datEntities())
                {

                    for (byte _minute = 0; _minute < 60; ++_minute)
                    {
                        for (byte _second = 0; _second < 60; ++_second)
                        {
                            _reading = new PowerReading19();

                            _reading.ReadingMinute = _minute;
                            _reading.ReadingSecond = _second;

                            _reading.Station01PowerUsage = (_ranGen.Next(60000, 90000)) / 1000m;
                            _reading.Station02PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station03PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station04PowerUsage = (_ranGen.Next(80000, 110000)) / 1000m;
                            _reading.Station05PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station06PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station07PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station08PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station09PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station10PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;

                            conx.PowerReading19.Add(_reading);
                        };
                        _recCount += conx.SaveChanges();
                    };
                }
                return _recCount;
            });
        }

        private static Task<int> InitHour20(int seedNumber)
        {
            int _recCount = 0;
            return Task.Run(() =>
            {
                Random _ranGen = new Random(seedNumber);
                PowerReading20 _reading = null;

                using (var conx = new PowerStations_datEntities())
                {

                    for (byte _minute = 0; _minute < 60; ++_minute)
                    {
                        for (byte _second = 0; _second < 60; ++_second)
                        {
                            _reading = new PowerReading20();

                            _reading.ReadingMinute = _minute;
                            _reading.ReadingSecond = _second;

                            _reading.Station01PowerUsage = (_ranGen.Next(60000, 90000)) / 1000m;
                            _reading.Station02PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station03PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station04PowerUsage = (_ranGen.Next(80000, 110000)) / 1000m;
                            _reading.Station05PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station06PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station07PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station08PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station09PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station10PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;

                            conx.PowerReading20.Add(_reading);
                        };
                        _recCount += conx.SaveChanges();
                    };
                }
                return _recCount;
            });
        }

        private static Task<int> InitHour21(int seedNumber)
        {
            int _recCount = 0;
            return Task.Run(() =>
            {
                Random _ranGen = new Random(seedNumber);
                PowerReading21 _reading = null;

                using (var conx = new PowerStations_datEntities())
                {

                    for (byte _minute = 0; _minute < 60; ++_minute)
                    {
                        for (byte _second = 0; _second < 60; ++_second)
                        {
                            _reading = new PowerReading21();

                            _reading.ReadingMinute = _minute;
                            _reading.ReadingSecond = _second;

                            _reading.Station01PowerUsage = (_ranGen.Next(60000, 90000)) / 1000m;
                            _reading.Station02PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station03PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station04PowerUsage = (_ranGen.Next(80000, 110000)) / 1000m;
                            _reading.Station05PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station06PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station07PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station08PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station09PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station10PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;

                            conx.PowerReading21.Add(_reading);
                        };
                        _recCount += conx.SaveChanges();
                    };
                }
                return _recCount;
            });
        }

        private static Task<int> InitHour22(int seedNumber)
        {
            int _recCount = 0;
            return Task.Run(() =>
            {
                Random _ranGen = new Random(seedNumber);
                PowerReading22 _reading = null;

                using (var conx = new PowerStations_datEntities())
                {

                    for (byte _minute = 0; _minute < 60; ++_minute)
                    {
                        for (byte _second = 0; _second < 60; ++_second)
                        {
                            _reading = new PowerReading22();

                            _reading.ReadingMinute = _minute;
                            _reading.ReadingSecond = _second;

                            _reading.Station01PowerUsage = (_ranGen.Next(60000, 90000)) / 1000m;
                            _reading.Station02PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station03PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station04PowerUsage = (_ranGen.Next(80000, 110000)) / 1000m;
                            _reading.Station05PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station06PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station07PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station08PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station09PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station10PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;

                            conx.PowerReading22.Add(_reading);
                        };
                        _recCount += conx.SaveChanges();
                    };
                }
                return _recCount;
            });
        }

        private static Task<int> InitHour23(int seedNumber)
        {
            int _recCount = 0;
            return Task.Run(() =>
            {
                Random _ranGen = new Random(seedNumber);
                PowerReading23 _reading = null;

                using (var conx = new PowerStations_datEntities())
                {

                    for (byte _minute = 0; _minute < 60; ++_minute)
                    {
                        for (byte _second = 0; _second < 60; ++_second)
                        {
                            _reading = new PowerReading23();

                            _reading.ReadingMinute = _minute;
                            _reading.ReadingSecond = _second;

                            _reading.Station01PowerUsage = (_ranGen.Next(60000, 90000)) / 1000m;
                            _reading.Station02PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station03PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station04PowerUsage = (_ranGen.Next(80000, 110000)) / 1000m;
                            _reading.Station05PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station06PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station07PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;
                            _reading.Station08PowerUsage = (_ranGen.Next(50000, 80000)) / 1000m;
                            _reading.Station09PowerUsage = (_ranGen.Next(40000, 60000)) / 1000m;
                            _reading.Station10PowerUsage = (_ranGen.Next(50000, 70000)) / 1000m;

                            conx.PowerReading23.Add(_reading);
                        };
                        _recCount += conx.SaveChanges();
                    };
                }
                return _recCount;
            });
        }
        #endregion

        #region Delete all rows from DB

        public static void DeleteAllRows()
        {
            DeletePowerStations();
            DeleteAllReadings();
        }

        private static void DeletePowerStations()
        {
            using (var conx = new PowerStations_datEntities())
            {
                conx.Database.ExecuteSqlCommand(@"TRUNCATE TABLE PowerStation");
            }
        }

        private static void DeleteAllReadings()
        {
            using (var conx = new PowerStations_datEntities())
            {
                conx.Database.ExecuteSqlCommand(@"TRUNCATE TABLE PowerReading00");
                conx.Database.ExecuteSqlCommand(@"TRUNCATE TABLE PowerReading01");
                conx.Database.ExecuteSqlCommand(@"TRUNCATE TABLE PowerReading02");
                conx.Database.ExecuteSqlCommand(@"TRUNCATE TABLE PowerReading03");
                conx.Database.ExecuteSqlCommand(@"TRUNCATE TABLE PowerReading04");
                conx.Database.ExecuteSqlCommand(@"TRUNCATE TABLE PowerReading05");
                conx.Database.ExecuteSqlCommand(@"TRUNCATE TABLE PowerReading06");
                conx.Database.ExecuteSqlCommand(@"TRUNCATE TABLE PowerReading07");
                conx.Database.ExecuteSqlCommand(@"TRUNCATE TABLE PowerReading08");
                conx.Database.ExecuteSqlCommand(@"TRUNCATE TABLE PowerReading09");
                conx.Database.ExecuteSqlCommand(@"TRUNCATE TABLE PowerReading10");
                conx.Database.ExecuteSqlCommand(@"TRUNCATE TABLE PowerReading11");
                conx.Database.ExecuteSqlCommand(@"TRUNCATE TABLE PowerReading12");
                conx.Database.ExecuteSqlCommand(@"TRUNCATE TABLE PowerReading13");
                conx.Database.ExecuteSqlCommand(@"TRUNCATE TABLE PowerReading14");
                conx.Database.ExecuteSqlCommand(@"TRUNCATE TABLE PowerReading15");
                conx.Database.ExecuteSqlCommand(@"TRUNCATE TABLE PowerReading16");
                conx.Database.ExecuteSqlCommand(@"TRUNCATE TABLE PowerReading17");
                conx.Database.ExecuteSqlCommand(@"TRUNCATE TABLE PowerReading18");
                conx.Database.ExecuteSqlCommand(@"TRUNCATE TABLE PowerReading19");
                conx.Database.ExecuteSqlCommand(@"TRUNCATE TABLE PowerReading20");
                conx.Database.ExecuteSqlCommand(@"TRUNCATE TABLE PowerReading21");
                conx.Database.ExecuteSqlCommand(@"TRUNCATE TABLE PowerReading22");
                conx.Database.ExecuteSqlCommand(@"TRUNCATE TABLE PowerReading23");
            }
        }

        #endregion

    }
}