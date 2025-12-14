namespace DesigenPattern.CQRS.CQRSPattern.Results
{
    public class GetProductQueryResult // Sorgu sonucunda dönecek olan model
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string Stock { get; set; }
        public decimal Price { get; set; }
    }
}
