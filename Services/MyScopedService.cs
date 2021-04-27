using blazorAntdProTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorAntdProTemplate.Services
{
    public interface IMyScopedService
    {
        public TimeSpan DeltaCreationTime { get; }
        public int InstanceNumber { get; }
    }
    public class MyScopedService : IMyScopedService
    {
        public TimeSpan DeltaCreationTime { get; }
        public int InstanceNumber { get; }
        private static volatile int PreviousInstanceNumber;
        public MyScopedService()
        {
            DeltaCreationTime = DateTime.UtcNow - AppLifetime.StartTimeUtc;
            InstanceNumber = System.Threading.Interlocked.Increment(ref PreviousInstanceNumber);
        }
    }
}
