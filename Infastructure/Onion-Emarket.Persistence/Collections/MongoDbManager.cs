using MongoDB.Driver;


namespace Onion_Emarket.Persistence.Collections
{
    public sealed class MongoDbManager
    {
        public static IMongoDatabase GetDatabase(IMongoClient client)
        {
            return client.GetDatabase("emarket");
        }
    }
}
