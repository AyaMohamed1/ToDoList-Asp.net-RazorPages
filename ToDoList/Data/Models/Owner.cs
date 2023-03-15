using System.ComponentModel.DataAnnotations;

namespace ToDoList.Data.Models
{
    public class Owner
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        //public virtual ICollection<ToDoTask> Tasks { get; set; }

    }
}
