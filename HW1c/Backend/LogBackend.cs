using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HW1c.Models;
using HW1c.Backend;

namespace HW1c.Backend
{
    public class LogBackend
    {
        #region SingletonPattern
        private static volatile LogBackend instance;
        private static object syncRoot = new object();

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
        #endregion SingletonPattern

        // Hook up the Repositry
        private ILogRepository repository = new LogRepositoryMock();

        /// <summary>
        ///  Returns the List of Logs
        /// </summary>
        /// <returns></returns>
        public LogViewModel Index()
        {
            var myData = new LogViewModel();
            myData.LogList = repository.Index();

            return myData;
        }

    }
}