using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    public class TimeZoneTime
    {
        private DateTimeOffset dt;
        private TimeZoneInfo tz;

        public TimeZoneTime(DateTimeOffset dateTime, TimeZoneInfo timeZone)
        {
            dt = dateTime;
            tz = timeZone;
        }

        public DateTimeOffset DateTime
        { get { return dt; } }

        public TimeZoneInfo TimeZone
        { get { return tz; } }
    }
}
