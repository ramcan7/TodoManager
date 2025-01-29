using System.ComponentModel.DataAnnotations;
public class Client {
    public int ClientId{get; set;}
    public required string ClientUsername {get; set;}
    public required string ClientEmail {get; set;}
    public required string ClientPassword {get; set;}
}