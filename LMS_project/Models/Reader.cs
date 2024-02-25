using System.ComponentModel.DataAnnotations;

namespace LMS_project.Models
{
    public class Reader
    {
        
        [Required]
        public int IdReader { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string NameReader { get; set; }

    }
}
