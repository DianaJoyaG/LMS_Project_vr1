using System.ComponentModel.DataAnnotations;

namespace LMS_project.Models
{
    public class Borrowing
    {
        public int IdBook { get; set; } // primary key of the entity In database design, does not requiere a data annotation

        [Required]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters.")]
        public string Title { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Author name cannot be longer than 100 characters.")]
        public string Author { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "Description name cannot be longer than 100 characters.")]
        public string Description { get; set; }
        
        [Required]
        public int IdReader { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string NameReader { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BorrowedDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ReturnedDate { get; set; } // Nullable, assuming the book might not have been returned yet

    }
}
