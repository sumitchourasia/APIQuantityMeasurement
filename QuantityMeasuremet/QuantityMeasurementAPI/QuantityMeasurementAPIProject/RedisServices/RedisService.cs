using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using StackExchange.Redis;

namespace QuantityMeasurementAPIProject.RedisServices
{
    public class RedisService
    {
        private readonly string _redisHost;
        private readonly int _redisPort;
        private ConnectionMultiplexer _redis;
        private readonly ILoggerFactory _loggerFactory;

        public RedisService(IConfiguration config, ILoggerFactory logFactory)
        {
            _redisHost = config["Redis:Host"];
            _redisPort = Convert.ToInt32(config["Redis:Port"]);
            _loggerFactory = logFactory;
        }

        public void Connect()
        {
            try
            {
               // var configString = $"{_redisHost}:{_redisPort},connectRetry=5";
                _redis = ConnectionMultiplexer.Connect("localhost");
            }
            catch (RedisConnectionException err)
            {
                throw err;
            }
        }

        public async Task<bool> Set(string key, string value)
        {
            var db = _redis.GetDatabase();
            return await db.StringSetAsync(key, value);
        }

        public async Task<string> Get(string key)
        {
            var db = _redis.GetDatabase();
            return await db.StringGetAsync(key);
        }
    }
}
