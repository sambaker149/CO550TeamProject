namespace CO550TeamProject.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public DateTime PlannedDelivery { get; set; }
        public DateTime ActualDelivery { get; set; }
        public string OrderStatus { get; set; }
    }
}
