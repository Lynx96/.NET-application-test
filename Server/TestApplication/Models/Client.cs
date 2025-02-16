namespace ProductApi.models;

public class Client {
    public long Id {get; set;}
    public string? Name {get; set;}
    public string? Email {get; set;}
    public string? PhoneNumber {get; set;}
    
    public ICollection<Order>? Orders {get; set;}
   
}