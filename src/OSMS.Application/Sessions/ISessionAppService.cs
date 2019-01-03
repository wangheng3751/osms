using System.Threading.Tasks;
using Abp.Application.Services;
using OSMS.Sessions.Dto;

namespace OSMS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
