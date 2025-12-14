namespace DesigenPattern.CQRS.CQRSPattern.Queries
{
    public class GetProductByIdQuery
    {
        public GetProductByIdQuery(int id)
        {
            this.ID = id;
        }
        public int ID { get; set; }
    }
}
