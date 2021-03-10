//@BaseCode

using SmartNQuick.Contracts;

namespace SmartNQuick.Logic.Entities
{
    abstract partial class VersionEntity : IdentityEntity, IVersionable
    {
        public byte[] RowVersion { get; set; }
    }
}
