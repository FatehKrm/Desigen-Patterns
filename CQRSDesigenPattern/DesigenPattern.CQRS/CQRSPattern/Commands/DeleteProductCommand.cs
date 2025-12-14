namespace DesigenPattern.CQRS.CQRSPattern.Commands
{
    public class DeleteProductCommand
    {
        public int ID { get; set; }
        public DeleteProductCommand(int id)
        {
            this.ID = id; 
        }
    }
}
