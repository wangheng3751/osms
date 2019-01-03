using System.Threading.Tasks;
using OSMS.Configuration.Dto;

namespace OSMS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
