using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05
{
    internal class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected MyDate StartDate;
        protected MyDate FinishDate;


        public Airplane(string startCity, MyDate startDate, string finishCity, MyDate finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }
        public int GetTotalTime()
        {
            DateTime startDateTime = new DateTime(StartDate.Years, StartDate.Months, StartDate.Days, StartDate.Hours, StartDate.Minutes, 0);
            DateTime finishDateTime = new DateTime(FinishDate.Years, FinishDate.Months, FinishDate.Days, FinishDate.Hours, FinishDate.Minutes, 0);


            if (finishDateTime > startDateTime)
            {
                TimeSpan travelTime = finishDateTime - startDateTime;
                return (int)travelTime.TotalMinutes;
            }
            else
            {
                return 0;
            }
        }
        public bool IsArrivingToday()
        {
            DateTime startDateTime = new DateTime(StartDate.Years, StartDate.Months, StartDate.Days, StartDate.Hours, StartDate.Minutes, 0);
            DateTime finishDateTime = new DateTime(FinishDate.Years, FinishDate.Months, FinishDate.Days, FinishDate.Hours, FinishDate.Minutes, 0);

            return startDateTime.Date == finishDateTime.Date;
        }
    }
}
