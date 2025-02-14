namespace ProductApi.models;

public class ProductItem {
    public long Id {get; set;}
    public string? Description {get; set;}
    public long SerialNumber {get; set;}
    public decimal Price {get; set;}
    public long ManufacturerId {get; set;}

    public Manufacturer? Manufacturer {get; set;}
}