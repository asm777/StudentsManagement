using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagement
{
    class Diapazon
    {
        public DateTime startDate { get; }
        public DateTime finishDate { get; }
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
