using System;

namespace ClassLibrary
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public string Assignee { get; set; }
        public int Estimation { get; set; } //number of days

        public Task()
        {
            StartDate = DateTime.Now;
            Estimation = 0;
        }

        public bool IsOnTrack()
        {
            return (DateTime.Now - StartDate).Days < Estimation;
        }

        public int CalculateRemainingEstimate()
        {
            // ?
            return 0;
        }

    }
}
