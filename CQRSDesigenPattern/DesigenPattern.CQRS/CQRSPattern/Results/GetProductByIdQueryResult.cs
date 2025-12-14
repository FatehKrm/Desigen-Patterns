namespace DesigenPattern.CQRS.CQRSPattern.Results
{
    public class GetProductByIdQueryResult
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Stock { get; set; }
        public decimal Price { get; set; }
    }
}
