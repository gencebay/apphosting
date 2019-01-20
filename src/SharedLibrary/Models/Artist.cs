using NetCoreStack.Contracts;

namespace SharedLibrary
{
    [CollectionName("Artists")]
    public class Artist : EntityIdentityBson
    {
        public string Name { get; set; }
    }
}
