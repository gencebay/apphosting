using MongoDB.Driver;

namespace AppHosting
{
    public class LookupContext
    {
        private readonly IMongoDatabaseAccessor _databaseAccessor;

        protected IMongoDatabase Database => _databaseAccessor.Database;

        public LookupContext(IMongoDatabaseAccessor databaseAccessor)
        {
            _databaseAccessor = databaseAccessor;
        }

        public IMongoCollection<Album> AlbumCollection => Database.GetCollection<Album>("Albums");
        public IMongoCollection<Artist> ArtistCollection => Database.GetCollection<Artist>("Artists");
    }
}
