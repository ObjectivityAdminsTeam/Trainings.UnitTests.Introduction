namespace TheorySamples.AAA
{
    using System;

    public interface IDateTimeProvider
    {
        DateTime Now { get; }
    }
}