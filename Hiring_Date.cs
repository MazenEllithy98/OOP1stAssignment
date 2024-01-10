using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1stAssignment
{
    public class Hiring_Date
    {
        private int day;
        private int month;
        private int year;

        // Constructor
        public Hiring_Date(int _Day, int _Month , int _Year)
        {
            day = _Day;
            month = _Month;
            year = _Year;
        }

        public int Day
        {
            get { return day; }
            set
            {
                if (value >= 0 && value <= 31)
                {
                    day = value;
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid day in the month : ");
                    value = int.Parse(Console.ReadLine());
                    day = value;
                }
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                if (value >= 0 && value <= 12)
                {
                    month = value;
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid month number : ");
                    value = int.Parse(Console.ReadLine());
                    month = value;
                }
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 1900 && value <= 2030)   // hiring year  
                {
                    year = value;
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid hiring year number : ");
                    value = int.Parse(Console.ReadLine());
                    year = value;
                }
            }
        }


        public override string ToString()
        {
            return $"Hiring Date : {day} / {month} / {year}";
        }


    }

}
