using System.ComponentModel.DataAnnotations;

namespace donet_vue_admin.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}