namespace DQS.Common
{
    public class OverlapPairs
    {
        public DateRange First { get; private set; }
        public DateRange Second { get; private set; }

        public OverlapPairs(DateRange First, DateRange Second)
        {
            this.First = First;
            this.Second = Second;
        }
    }
}
