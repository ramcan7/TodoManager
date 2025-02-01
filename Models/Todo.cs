using System.ComponentModel.DataAnnotations;

namespace TodoManager.Models;
public class Todo {
    public enum Priority {high, medium, low}
    public int TodoId {get; set;} 
    [Required]
    public required string TodoTitle {get; set;}
    public required string TodoDescription {get; set;}
    public DateTime TodoDueDate {get; set;}

    public Priority TodoPriority{get; set;}

    public TimeSpan TodoTimeSpan {get; set;}

    public bool TodoIsCompleted {get; set;}
}
