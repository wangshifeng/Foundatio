﻿using System;
using Foundatio.Messaging;
using Foundatio.Serializer;
using StackExchange.Redis;

namespace Foundatio.Caching {
    public class RedisHybridCacheClient : HybridCacheClient {
        public RedisHybridCacheClient(ConnectionMultiplexer connectionMultiplexer, ISerializer serializer = null, string channelName = "cache-messages")
            : base(new RedisCacheClient(connectionMultiplexer, serializer), new RedisMessageBus(connectionMultiplexer.GetSubscriber(), channelName, serializer)) { }
    }
}
