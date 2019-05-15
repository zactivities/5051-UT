using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HW1c.Models;
using HW1c.Backend;
using Telemetry.Backend;

namespace HW1c.Backend
{
    public class LogBackend
    {

        private static volatile LogBackend instance;
        private static object syncRoot = new object();

        // Hook up the Repositry
        private ILogRepository repository = new LogRepositoryMock();

        private LogBackend() { }

        public static LogBackend Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new LogBackend();
                    }
                }

                return instance;
            }
        }

        /// <summary>
        ///  Returns the List of Logs
        /// </summary>
        /// <returns></returns>
        public LogViewModel Index()
        {
            var myData = new LogViewModel();

            // TODO:  Populate some Log Data here...
            myData.LogList.Add(new LogModel { AppVersion = "1", PhoneID = "ABC", RecordedDateTime = DateTime.Now });
            myData.LogList.Add(new LogModel { AppVersion = "2", PhoneID = "MNO", RecordedDateTime = DateTime.Parse("01/23/2019") });
            myData.LogList.Add(new LogModel { AppVersion = "3", PhoneID = "ZYX", RecordedDateTime = DateTime.Now.AddDays(-2) });
            myData.LogList.Add(new LogModel { AppVersion = "3.3", PhoneID = "ZYXa", RecordedDateTime = DateTime.Now.AddYears(-1) });
            return myData;
        }

    }
}