using Api.Interfaces;
using Api.Models;
using Api.Options;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Api.Services
{
    public class UserService : IUserService
    {
        private readonly IDistributedCache _cache;
        private readonly CacheOptions _options;

        public UserService(IDistributedCache cache, IOptions<RedisOptions> options)
        {
            _cache = cache;
            _options = options.Value;
        }

        public async Task AddUser(string username, int age, string email)
        {
            if (GetUser(username) != null)
                throw new Exception("User already exist");

            var user = new User
            {
                Age = age,
                Email = email,
                UserName = username
            };

            await _cache.SetStringAsync(username.ToLower(), JsonConvert.SerializeObject(user), GetCacheOptions());
        }

        public async Task<User> GetUser(string username)
        {
            var json = await _cache.GetStringAsync(username.ToLower());
            return JsonConvert.DeserializeObject<User>(json);
        }

        public async Task RemoveUser(string username)
        {
            await _cache.RemoveAsync(username.ToLower());
        }

        public DistributedCacheEntryOptions GetCacheOptions()
        {
            return new DistributedCacheEntryOptions
            {
                AbsoluteExpiration = DateTime.UtcNow + TimeSpan.FromMinutes(_options.ExpirationTime)
            };
        }
    }
}
