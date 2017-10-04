using System;

namespace ClassLibrary
{
    public class HouseAlarm : Alarm
    {
        public string Address { get; }

        public HouseAlarm(Guid guid, string address, DateTime alertTime)
        {
            Id = guid;
            Address = address;
            AlertTime = alertTime;
        }

        public override string Trigger()
        {
            AlertTime = DateTime.Now;
            return "House alarm triggered, calling cops!";
        }
    }
}
