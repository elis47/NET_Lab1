using System;

namespace ClassLibrary
{
    public class WorkAlarm : Alarm
    {
        public string Office { get; set; }

        public WorkAlarm(Guid guid, string office, DateTime alertTime)
        {
            Id = guid;
            Office = office;
            AlertTime = alertTime;
        }

        public override string Trigger()
        {
            return "If it's past to 8, you're soo late!";
        }
    }
}
