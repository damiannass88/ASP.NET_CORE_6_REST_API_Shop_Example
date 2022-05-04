namespace ASP.NET_CORE_6_REST_API_Shop_Example.Models
{
    public class ShopProduct
    {
        public Guid Id { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public DateTimeOffset ProductCreationDate { get; set; }
        public DateTimeOffset ProductModificationDate { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
