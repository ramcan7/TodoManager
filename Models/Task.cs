using System.ComponentModel.DataAnnotations;
public class Task {
    public int TaskId {get; set;} 
    [Required]
    public required string Title {get; set;}
    public required string Description {get; set;}
    public DateTime DueDate {get; set;}

    public enum Priority {high, medium, low} 

    public TimeSpan timeSpan {get; set;}

    public bool IsCompleted {get; set;}
}