using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Net.S._2018.Zenovich._11.Time.Interfaces;

namespace Net.S._2018.Zenovich._11.Time
{
    /// <summary>
    /// Implements publisher.
    /// </summary>
    /// <seealso cref="Net.S._2018.Zenovich._11.Time.Interfaces.ITimer" />
    public class Timer : ITimer
    {
        public event TimerFunc TimerEvent;

        private readonly DateTime _dateTime;

        /// <summary>
        /// Initializes a new instance of the <see cref="Timer"/> class.
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        public Timer(TimeSpan timeSpan)
        {
            TimerEvent = (sender, eventArgs) => { };
            _dateTime = DateTime.Now.Add(timeSpan);

            ThreadPool.QueueUserWorkItem(Run);
        }

        private bool IsLess(DateTime firstDateTime, DateTime secondDateTime)
        {
            return firstDateTime.CompareTo(secondDateTime) < 0;
        }

        private void Run(object state)
        {
            while (IsLess(DateTime.Now, _dateTime))
            {
                Thread.Sleep(10);
            }

            TimerEventArgs eventArgs = new TimerEventArgs(DateTime.Now, "DateTime.Now");
            TimerEvent.Invoke(this, eventArgs);
        }
    }
}
