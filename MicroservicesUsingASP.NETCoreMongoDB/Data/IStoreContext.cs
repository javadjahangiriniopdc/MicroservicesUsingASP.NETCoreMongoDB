using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroservicesUsingASP.NETCoreMongoDB.Entities;
using MongoDB.Driver;

namespace MicroservicesUsingASP.NETCoreMongoDB.Data
{
     public interface IStoreContext
    {
         IMongoCollection<Product> Products { get;  }
    }
}
