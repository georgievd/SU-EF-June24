namespace ProductShop.DTOs.Export
{
    public class SellerWithProductsDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<SoldProductsDto> SoldProducts { get; set; }
    }
}
