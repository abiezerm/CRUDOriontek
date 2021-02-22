using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGClaves.General
{
    public struct ObjectCallBack
    {

        public string EventName;
        public object Data;
        public bool IsError;
        public string ErrorMessage;
        public string InnerMessage;

        public ObjectCallBack(string eventName, object data)
        {
            EventName = eventName;
            Data = data;
            IsError = false;
            ErrorMessage = null;
            InnerMessage = null;
        }
        public ObjectCallBack(string eventName, object data, string errorMessage, string innerMessage)
        {
            EventName = eventName;
            Data = data;
            IsError = true;
            ErrorMessage = errorMessage;
            InnerMessage = innerMessage;
        }

    }
}
