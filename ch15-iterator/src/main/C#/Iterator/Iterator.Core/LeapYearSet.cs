using System.Collections;

namespace Iterator.Core
{
    public class LeapYearSet : IEnumerable
    {
        private int from;
        private int to;

        public LeapYearSet(int from, int to)
        {
            this.from = from;
            this.to = to;
        }

        public IEnumerator GetEnumerator()
        {
            return new LeapYearIterator(from, to);
        }
    }
}
