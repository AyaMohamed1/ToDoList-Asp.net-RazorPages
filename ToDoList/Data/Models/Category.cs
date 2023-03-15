using System.ComponentModel.DataAnnotations;

namespace ToDoList.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string CategoryName { get; set; }

    }
}
