using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorAntd.Models
{
    public static class AppLifetime
    {
        public static DateTime StartTimeUtc { get; } = DateTime.UtcNow;
        public static TimeSpan ElapsedTime => DateTime.UtcNow - StartTimeUtc;
    }
}
