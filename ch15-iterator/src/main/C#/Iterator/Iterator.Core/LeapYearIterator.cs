using System.Collections;

namespace Iterator.Core
{
    public class LeapYearIterator : IEnumerator
    {
        private int from;
        private int to;
        private int currentLeapYear;

        public LeapYearIterator(int from, int to)
        {
            this.from = from;
            this.to = to;
            currentLeapYear = from - 1;
        }

        public bool MoveNext()
        {
            currentLeapYear = nextLeapYear(currentLeapYear);
            if (currentLeapYear <= to)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>  
        ///  
        /// </summary>  
        public object Current
        {
            get
            {
                return currentLeapYear;
            }
        }


        public void Reset()
        {
            currentLeapYear = from - 1;
        }

        private int nextLeapYear(int year)
        {
            int yearIndex = year + 1;
            while (!isLeap(yearIndex))
            {
                yearIndex++;
            }
            return yearIndex++;
        }

        private bool isLeap(int year)
        {
            //2100 Is Not a Leap Year
            return ((year % 4 == 0 && year % 100 != 0) || (year % 100 == 0 && year % 400 == 0)) ;
        }
    }
}
