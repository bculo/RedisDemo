using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Options
{
    public sealed class RedisOptions
    {
        public string Connection { get; set; }

        public string InstanceName { get; set; }
    }
}
