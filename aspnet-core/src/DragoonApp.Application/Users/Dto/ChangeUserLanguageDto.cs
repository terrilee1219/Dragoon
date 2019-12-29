using System.ComponentModel.DataAnnotations;

namespace DragoonApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}