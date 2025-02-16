namespace ProductApi.models;

public class OrderItem {
    public long Id {get; set;}
    public int Quantity {get; set;}
    public long ProductItemId {get; set;}
    public ProductItem? ProductItem {get; set;}
    public long OrderId {get; set;}
    public Order? Order {get; set;}
}