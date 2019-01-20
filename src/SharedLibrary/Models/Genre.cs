using NetCoreStack.Contracts;

namespace SharedLibrary
{
    [CollectionName("Genres")]
    public class Genre : EntityIdentityBson
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
