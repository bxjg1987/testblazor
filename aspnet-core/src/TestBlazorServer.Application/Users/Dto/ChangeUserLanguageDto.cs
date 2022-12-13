using System.ComponentModel.DataAnnotations;

namespace TestBlazorServer.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}