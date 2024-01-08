namespace AuctionService.Entities;

public class  Item
{
    public Guid Id { get; set; }
    public String Make { get; set; }
    public String Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public string Mileage { get; set; }
    public string ImageUrl { get; set; }

    // nav properties
    public Auction Auction { get; set; }
    public Guid AuctionId { get; set; }
}
