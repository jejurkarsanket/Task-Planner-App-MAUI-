using System.ComponentModel.DataAnnotations;

namespace ToDoAPI.Models
{
    //Model for Holding Id and Name of Task
    public class ToDo
    {
        [Key]
        public int Id { get; set; }
        public string? ToDoName { get; set; }
    }
}
