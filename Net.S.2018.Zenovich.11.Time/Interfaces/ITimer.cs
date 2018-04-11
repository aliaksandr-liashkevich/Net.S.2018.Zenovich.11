using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.S._2018.Zenovich._11.Time.Interfaces
{
    public interface ITimer
    {
        event TimerFunc TimerEvent;
    }
}
