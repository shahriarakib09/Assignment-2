using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management
{
    class Birthday
    {
        private int day, month, year;

        public Birthday(int day,int month,int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;   
        }
        public int Day
        {
            set { this.day = value; }
            get { return this.day; }
        }
        public int Month
        {
            set { this.month = value; }
            get { return this.month; }
        }
        public int Year
        {
            set { this.year = value; }
            get { return this.year; }
        }
        public bool CheckDate()
        {
            if(day>31||month>12||year>2002)
            {
                Console.WriteLine("Invalid Date");
                return false;
            }
            else
            {
                return true;
            }
            
        }
        public string GetDate()
        {
            if(CheckDate() ==true)
            {
                return "Birthdate :" + this.day + "-" + this.month + "-" + this.year;

            }
            else
            {
                return "";
            }
        }
    }
}
