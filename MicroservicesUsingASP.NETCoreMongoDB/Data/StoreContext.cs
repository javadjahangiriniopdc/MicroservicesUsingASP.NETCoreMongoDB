using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroservicesUsingASP.NETCoreMongoDB.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MongoDB.Driver.Core.Operations;

namespace MicroservicesUsingASP.NETCoreMongoDB.Data
{
    public class StoreContext :IStoreContext
    {
        public StoreContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));

            Products = database.GetCollection<Product>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));
            StoreContextSeed.SeedData(Products);
        }
        public IMongoCollection<Product> Products { get; }
    }
}
