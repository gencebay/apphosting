using NetCoreStack.Contracts;

namespace AppHosting
{
    [CollectionName("Artists")]
    public class Artist : EntityIdentityBson
    {
        public string Name { get; set; }
    }
}
