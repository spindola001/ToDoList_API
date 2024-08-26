using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList_API.Models
{
    [Table("Task")]
    public class TaskModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; }
        
        public TaskModel(string Name, string Description) { 
            this.Name = Name;
            this.Description = Description;
        }
    }
}
