using System.ComponentModel.DataAnnotations;

namespace OSMS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}