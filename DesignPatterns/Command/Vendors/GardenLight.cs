using System;

namespace DesignPatterns.Command.Vendors
{
    public class GardenLight
    {
        public int DuskHour { get; set; }
        public int DuskMinute { get; set; }

        public int DawnHour { get; set; }
        public int DawnMinute { get; set; }

        public void SetDuskTime(int hour, int minute)
        {
            if (hour < 0 || hour > 23)
            {
                throw new ArgumentException("The hour must be between 0 and 23.");
            }

            if (minute < 0 || minute > 59)
            {
                throw new ArgumentException("The hour must be between 0 and 59.");
            }
            DuskHour = hour;
            DuskMinute = minute;
            Console.WriteLine("Garden light will be turned on at {0}:{1}.", DuskHour, DuskMinute.ToString("00"));
        }

        public void SetDawnTime(int hour, int minute)
        {
            if (hour < 0 || hour > 23)
            {
                throw new ArgumentException("The hour must be between 0 and 23.");
            }

            if (minute < 0 || minute > 59)
            {
                throw new ArgumentException("The hour must be between 0 and 59.");
            }
            DawnHour = hour;
            DawnMinute = minute;
            Console.WriteLine("Garden light will be turned off at {0}:{1}.", DawnHour, DawnMinute.ToString("00"));
        }

        public void ManualOn()
        {
            Console.WriteLine("Garden light is on.");
        }
        public void ManualOff()
        {
            Console.WriteLine("Garden light is off.");
        }
    }
}
