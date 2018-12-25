using MongoDB.Driver;

namespace AppHosting
{
    public interface IMongoDatabaseAccessor
    {
        IMongoDatabase Database { get; }
    }
}
