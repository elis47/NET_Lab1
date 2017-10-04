using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public interface IAlertService
    {
        List<Alarm> AlarmList { get; set; }

        void SoundAlarm(Guid id);
    }
}
