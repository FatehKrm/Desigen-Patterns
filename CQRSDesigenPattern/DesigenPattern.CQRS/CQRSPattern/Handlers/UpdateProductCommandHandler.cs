using DesigenPattern.CQRS.CQRSPattern.Commands;
using DesigenPattern.CQRS.DAL;

namespace DesigenPattern.CQRS.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateProductCommand command)
        {
            var values = _context.Products.Find(command.ProductId);
            values.Name = command.Name;
            values.Status = true;
            values.Description = command.Description;
            values.Price = command.Price;
            values.Stock = command.Stock;
            _context.SaveChanges();
        }
    }
}
