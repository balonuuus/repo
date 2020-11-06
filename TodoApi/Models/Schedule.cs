using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string DataStart { get; set; }
        
        [Required]
        public string DataStop { get; set; }
    }
}