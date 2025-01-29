using System.ComponentModel.DataAnnotations;
public class Task {
    public int TaskId {get; set;} 
    [Required]
    public required string Title {get; set;}
    public string Description {get; set;}
    public DateTime DueDate {get; set;}

    public enum Priority {high, medium, low}

    public bool IsCompleted {get; set;}
}