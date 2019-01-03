using System.Collections.Generic;
using OSMS.Roles.Dto;
using OSMS.Users.Dto;

namespace OSMS.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
