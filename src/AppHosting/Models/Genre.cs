using NetCoreStack.Contracts;

namespace AppHosting
{
    [CollectionName("Genres")]
    public class Genre : EntityIdentityBson
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
