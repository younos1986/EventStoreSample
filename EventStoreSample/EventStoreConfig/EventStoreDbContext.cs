﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using EventStore.ClientAPI;
using EventStore.ClientAPI.SystemData;

namespace EventStoreSample.EventStoreConfig
{
    public class EventStoreDbContext : IEventStoreDbContext
    {
        public async Task<IEventStoreConnection> GetConnection()
        {
            IEventStoreConnection connection = EventStoreConnection.Create(
                new IPEndPoint(IPAddress.Loopback, 1113),
                nameof(EventStoreSample));

            await connection.ConnectAsync();
            
            return connection;
        }

        public async Task<EventReadResult> ReadStreamAsync(long eventNumber)
        {
            const string appName = nameof(EventStoreSample);
            IEventStoreConnection connection = await GetConnection();

             return await connection.ReadEventAsync("" , eventNumber, false, EventStoreCredentials.Default);
        }

        public async Task AppendToStreamAsync(params EventData[] events)
        {
            const string appName = nameof(EventStoreSample);
            IEventStoreConnection connection = await GetConnection();

            await connection.AppendToStreamAsync(appName, ExpectedVersion.Any, events , EventStoreCredentials.Default);
        }
    }
}
