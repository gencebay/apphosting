using MongoDB.Driver;

namespace SharedLibrary
{
    public interface IMongoDatabaseAccessor
    {
        IMongoDatabase Database { get; }
    }
}
