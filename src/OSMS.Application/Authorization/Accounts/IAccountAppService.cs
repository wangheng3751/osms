using System.Threading.Tasks;
using Abp.Application.Services;
using OSMS.Authorization.Accounts.Dto;

namespace OSMS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
