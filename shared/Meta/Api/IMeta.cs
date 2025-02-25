using System;
using System.Threading;
using System.Threading.Tasks;

namespace Shared.Meta.Api
{
    public interface IMeta
    {
        public ValueTask<ServerInfo> GetInfo(CancellationToken cancellationToken);
    }
    
    [Serializable]
    public class ServerInfo
    {
        public string? RandomName;
        public int RequestId;
        public DateTime RequestTime;
    }
}