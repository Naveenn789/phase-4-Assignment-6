using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table("Task")]
    public class Task
    {
        [Key]
        public int Id { get; set; } 
        public string? Name { get; set; }
    }
}
