namespace ASPshop.DTOs;

public class OrderDto
{
    public string BasketId { get; set; }
    public int DeliveryMathodId { get; set; }
    public AddressDto ShipToAddress { get; set; }
}