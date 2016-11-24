namespace TheorySamples.AAA
{
    public class DateInfoProvider
    {
        private readonly IDateTimeProvider dateTimeProvider;

        public DateInfoProvider(IDateTimeProvider dateTimeProvider)
        {
            this.dateTimeProvider = dateTimeProvider;
        }

        public TimeOfDay TimeOfDay
        {
            get
            {
                var currentTime = this.dateTimeProvider.Now;
                if (currentTime.Hour < 6)
                {
                    return TimeOfDay.Night;
                }

                if (currentTime.Hour < 12)
                {
                    return TimeOfDay.Morning; ;
                }

                if (currentTime.Hour < 18)
                {
                    return TimeOfDay.Afternoon;
                }

                return TimeOfDay.Evening;
            }
        }

        public int Year => this.dateTimeProvider.Now.Year;
    }
}
