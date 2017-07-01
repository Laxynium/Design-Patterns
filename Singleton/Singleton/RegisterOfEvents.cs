using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class RegisterOfEvents
    {
        private static RegisterOfEvents _instance;

        private bool _immediateSaving;

        private const string _fileName="registerOfEvents.txt";

        private List<string> _eventsToSave=null;

        private RegisterOfEvents(bool enableImmediateSaving=true)
        {
            _immediateSaving = enableImmediateSaving;

            if (File.Exists(_fileName))
            {
                _eventsToSave=File.ReadAllLines(_fileName).ToList();
            }
            else
            {
                _eventsToSave = new List<string>();
            }
        }

        public void EnableImmediateSaving(bool enable)
        {
            _immediateSaving = enable;
        }

        public static RegisterOfEvents GetInstance()
        {
            return _instance ?? (_instance = new RegisterOfEvents(true));
        }
        public void Save()
        {
            File.AppendAllLines(_fileName,_eventsToSave);
        }

        public void AddEvent(string _event)
        {
            _eventsToSave.Add(_event);
            if (_immediateSaving) Save();
        }
    }
}
