using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary
{
    public class AlertService : IAlertService
    {
        public List<Alarm> AlarmList { get; set; }

        public AlertService()
        {
            CarAlarm carAlarm = new CarAlarm(new Guid(), "Home", DateTime.Now);
            HouseAlarm houseAlarm = new HouseAlarm(new Guid(), "Hollywood", DateTime.Today);
            WorkAlarm workAlarm = new WorkAlarm(new Guid(), "UBC", DateTime.Now);

            AlarmList = new List<Alarm> { carAlarm, houseAlarm, workAlarm };
        }

        public override string ToString()
        {
            var result = "";

            foreach (var alarm in AlarmList)
            {
                if (alarm.GetType() == typeof(CarAlarm))
                {
                    var castedAlarm = (CarAlarm)alarm;
                    result += "Car alarm started at " + castedAlarm.Location + "!\n";
                    continue;
                }
                if (alarm.GetType() == typeof(HouseAlarm))
                {
                    var castedAlarm = (HouseAlarm)alarm;
                    result += "House alarm started at " + castedAlarm.Address + "!\n";
                    continue;
                }
                if (alarm.GetType() == typeof(WorkAlarm))
                {
                    var castedAlarm = (WorkAlarm)alarm;
                    result += "Work alarm started at " + castedAlarm.Office + "!\n";
                }
            }
            return result;
        }

        public void SoundAlarm(Guid id)
        {
            try
            {
                var triggeredAlarm = AlarmList.Single(alarm => alarm.Id == id);
                triggeredAlarm.Trigger();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Id-ul nu a fost gasit!" + e.Message);
                throw;
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Operatie invalida!" + e.Message);
                throw;
            }

        }
    }
}
