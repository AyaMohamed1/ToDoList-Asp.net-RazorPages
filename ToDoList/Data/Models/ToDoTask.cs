using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList.Data.Models
{
    public class ToDoTask
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [MaxLength(30, ErrorMessage = "Description can't be more than 30 chars!")]
        public string Description { get; set; }

        [ForeignKey("Owner")]
        public int OwnerId { get; set; }
        
        public virtual Owner? Owner { get; set; }
        
        public DateTime AssignedDate { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual Category? Category { get; set; }
        public StatusEnum Status { get; set; }
        //public string Status { get; set; }
        
    }
}
