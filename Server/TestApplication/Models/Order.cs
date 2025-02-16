namespace ProductApi.models
{
    public class Order {
        public long Id {get; set;}
        public DateTime OrderDate {get; set;}
        public long ClientId {get; set;}

        public required Client Client {get; set;}

        public ICollection<OrderItem>? OrderItems {get; set;}
    }

}
