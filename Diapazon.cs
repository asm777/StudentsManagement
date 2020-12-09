using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagement
{
    class Diapazon
    {
        public DateTime startDate { get; private set; }
        public DateTime finishDate { get; private set; }
        public Diapazon(DateTime keyDate)
        {
            //Looking for startDate
            startDate = keyDate;
            int numberOfMon = 0;
            while (true)
            {
                if (startDate.DayOfWeek == DayOfWeek.Monday)
                {
                    numberOfMon++;
                    if (numberOfMon == 2)
                    {
                        break;
                    }
                }
                startDate = startDate.AddDays(-1);
            }

            //Looking for finishDate
            finishDate = keyDate;
            int numberOfSun = 0;
            while (true)
            {
                if (finishDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    numberOfSun++;
                    if (numberOfSun == 2)
                    {
                        break;
                    }
                }
                finishDate = finishDate.AddDays(+1);
            }
            int d = startDate.Day;
            int m = startDate.Month;
            int y = startDate.Year;
            startDate = new DateTime(y, m, d, 0, 0, 0);
            d = finishDate.Day;
            m = finishDate.Month;
            y = finishDate.Year;
            finishDate = new DateTime(y, m, d, 0, 0, 0);
        }

        public DateTime this[int i]
        {
            get
            {
                return startDate.AddDays(i);
            }
        }
    }
}
