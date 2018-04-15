using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using StackExchange.Redis;

namespace RedisPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            var internetPort = ConfigurationManager.AppSettings["internetPort"];
            ConnectionMultiplexer conn = ConnectionMultiplexer.Connect(internetPort);

            IDatabase cache = conn.GetDatabase();

            cache.StringSet("key1","value1");
            string data = cache.StringGet("key1");

            Console.WriteLine(data);
            Console.ReadKey();
        }
    }
}
