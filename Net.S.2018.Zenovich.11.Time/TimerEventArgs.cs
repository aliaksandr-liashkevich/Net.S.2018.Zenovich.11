using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.S._2018.Zenovich._11.Time
{
    /// <summary>
    /// Contains information about event.
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public class TimerEventArgs : EventArgs
    {
        public TimerEventArgs(DateTime dateTime, string message)
        {
            DateTime = dateTime;
            Message = message;
        }

        public DateTime DateTime { get; protected set; }
        public String Message { get; protected set; }
    }
}
