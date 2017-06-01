using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminPowerStations.Models
{
    /// <summary>
    /// Provide support for the HomeController and Views / Home.
    /// </summary>
    public class Home
    {
        public Home()
        {
            TotalDbRows = GetNumberDBrows();
        }

        public int TotalDbRows { get; private set; }

        #region Get total # rows in the DB
        public int GetNumberDBrows()
        {
            int _numRecords = 0;

            using (var db = new PowerStations_datEntities())
            {
                _numRecords += db.PowerStations.Count();
                _numRecords += db.PowerReading00.Count();
                _numRecords += db.PowerReading01.Count();
                _numRecords += db.PowerReading02.Count();
                _numRecords += db.PowerReading03.Count();
                _numRecords += db.PowerReading04.Count();
                _numRecords += db.PowerReading05.Count();
                _numRecords += db.PowerReading06.Count();
                _numRecords += db.PowerReading07.Count();
                _numRecords += db.PowerReading08.Count();
                _numRecords += db.PowerReading09.Count();
                _numRecords += db.PowerReading10.Count();
                _numRecords += db.PowerReading11.Count();
                _numRecords += db.PowerReading12.Count();
                _numRecords += db.PowerReading13.Count();
                _numRecords += db.PowerReading14.Count();
                _numRecords += db.PowerReading15.Count();
                _numRecords += db.PowerReading16.Count();
                _numRecords += db.PowerReading17.Count();
                _numRecords += db.PowerReading18.Count();
                _numRecords += db.PowerReading19.Count();
                _numRecords += db.PowerReading20.Count();
                _numRecords += db.PowerReading21.Count();
                _numRecords += db.PowerReading22.Count();
                _numRecords += db.PowerReading23.Count();
            }
            return _numRecords;
        }
        #endregion


    }
}