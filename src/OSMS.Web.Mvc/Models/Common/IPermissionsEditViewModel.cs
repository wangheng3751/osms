using System.Collections.Generic;
using OSMS.Roles.Dto;

namespace OSMS.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}