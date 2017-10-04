using System;

namespace ClassLibrary
{
    public class CarAlarm : Alarm
    {
        public string Location { get; set; }

        public CarAlarm(Guid guid, string location, DateTime alertTime)
        {
            Id = guid;
            Location = location;
            AlertTime = alertTime;
        }

        public override string Trigger()
        {
            AlertTime = DateTime.Now;
            return "Car activated at " + Location + "! Calling cops, run for your life!";
        }
    }
}
