using System.ComponentModel.DataAnnotations;

namespace ToDoAPI.Models
{
    //Model for Holding Id and Name of Task
    public class ToDo
    {
        [Key]

        //Note ID
        public int Id { get; set; }

        //Note Name
        public string? ToDoName { get; set; }
    }
}
