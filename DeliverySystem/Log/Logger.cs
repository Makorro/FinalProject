using DeliverySystem.Log;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace DeliverySystem
{
    public static class Logger
    {
        private static BindingList<LogObserver> _log = new BindingList<LogObserver>();

        public static void Add(LogObserver NewObserver)
        {
            _log.Add(NewObserver);
        }

        public static void RemoveLogs()
        {
            foreach (var LogManager in _log)
            {
                LogManager.Close();
            }
            _log.Clear();
        }

        public static void DeleteLog(int id)
        {
            LogObserver log_observer = _log.FirstOrDefault(x => x.IdLog == id);
            log_observer.Close();
            _log.Remove(log_observer);
        }

        public static void Log(string LogMessage)
        {
            foreach (var LogManager in _log)
            {
                LogManager.ConcreteLog(new LogItem(DateTime.Now, LogMessage));
            }
        }

        public static List<int> GetIds()
        {
            List<int> _ids = new List<int>();
            foreach (var LogManager in _log)
            {
                _ids.Add(LogManager.GetId());
            }
            return _ids;
        }

        public static BindingList<LogObserver> GetBindingList()
        {
            return _log;
        }
    }
}