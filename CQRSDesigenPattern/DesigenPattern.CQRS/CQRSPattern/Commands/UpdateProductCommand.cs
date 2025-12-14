namespace DesigenPattern.CQRS.CQRSPattern.Commands
{
    public class UpdateProductCommand
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Stock { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
