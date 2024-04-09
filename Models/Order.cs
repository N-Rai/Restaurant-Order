namespace Restuarant_Order.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public required TimeOnly PlacedAt { get; set; }
        public required DateOnly PlacedOn { get; set; }
        public required int TableNumber { get; set; }
        public string? Other { get; set; }
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending;

        public Order (int orderId, TimeOnly placedAt, DateOnly placedOn, int tableNumber, string? other, OrderStatus orderStatus)
        {
            OrderId = orderId;
            PlacedAt = placedAt;
            PlacedOn = placedOn;
            TableNumber = tableNumber;
            Other = other;
            OrderStatus = orderStatus;
        }
    }
    public enum OrderStatus
    {
        Pending = 0,
        Cooking = 1,
        Served = 2,
    }
}
