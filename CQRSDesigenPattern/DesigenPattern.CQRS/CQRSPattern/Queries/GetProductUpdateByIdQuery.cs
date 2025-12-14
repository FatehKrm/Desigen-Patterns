namespace DesigenPattern.CQRS.CQRSPattern.Queries
{
    public class GetProductUpdateByIdQuery
    {
        public int ID { get; set; }
        public GetProductUpdateByIdQuery(int id)
        {
            this.ID = id;

        }
    }
}
