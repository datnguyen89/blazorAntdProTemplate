using blazorAntdProTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorAntdProTemplate.Services
{
    public interface IMySingletonService
    {
        public TimeSpan DeltaCreationTime { get; }
        public int InstanceNumber { get; }
    }
    public class MySingletonService : IMySingletonService
    {
        public TimeSpan DeltaCreationTime { get; }
        public int InstanceNumber { get; }
        private static volatile int PreviousInstanceNumber;
        public MySingletonService()
        {
            DeltaCreationTime = DateTime.UtcNow - AppLifetime.StartTimeUtc;
            InstanceNumber = System.Threading.Interlocked.Increment(ref PreviousInstanceNumber);
        }
    }
}
