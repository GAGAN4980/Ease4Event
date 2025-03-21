using System.ComponentModel.DataAnnotations;

namespace Ease4Event.Models
{
    public class Event
	{
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public TimeSpan Time { get; set; }

        [Required]
        [StringLength(200)]
        public string Location { get; set; }
    }
}

