namespace Api.Options
{
    public sealed class RedisOptions : CacheOptions
    {
        public string Connection { get; set; }

        public string InstanceName { get; set; }
    }
}
