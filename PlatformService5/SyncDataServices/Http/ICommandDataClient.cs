using System.Threading.Tasks;
using PlatformService.Dtos;

namespace PlatformService5.SyncDataServices.Http
{
    public interface ICommandDataClient
    {
        Task SendPlatformToCommand(PlatformReadDto plat);
    }
}