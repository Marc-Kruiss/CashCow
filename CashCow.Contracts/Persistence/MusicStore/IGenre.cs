using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNQuick.Contracts.Persistence.MusicStore
{
    [ContractInfo(ContextType=ContextType.Table)]
    public interface IGenre:IVersionable,ICopyable<IGenre>
    {
        [ContractPropertyInfo(Required=true,MaxLength=256,IsUnique=true)]
        public string Name { get; set; }
    }
}
