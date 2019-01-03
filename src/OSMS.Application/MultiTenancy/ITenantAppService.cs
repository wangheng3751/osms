using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OSMS.MultiTenancy.Dto;

namespace OSMS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

