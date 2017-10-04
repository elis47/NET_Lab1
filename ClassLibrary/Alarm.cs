using System;

namespace ClassLibrary
{
    public abstract class Alarm
    {
        public Guid Id;
        public DateTime AlertTime { get; set; }

        public abstract string Trigger();
    }
}
