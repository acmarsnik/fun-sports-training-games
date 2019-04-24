using System;
using FstgWebApi.DataModels;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace FstgWebApi.DataAccess
{
    public class FstgContext
    {
        private readonly IMongoDatabase _database = null;

        public FstgContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<Score> Scores
        {
            get
            {
                return _database.GetCollection<Score>("scores");
            }
        }
    }
}
