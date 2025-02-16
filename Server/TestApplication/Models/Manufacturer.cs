namespace ProductApi.models;

public class Manufacturer {
    public long Id {get; set;}
    public string? Name {get; set;}

    public ICollection<ProductItem>? Products {get; set;}
}

