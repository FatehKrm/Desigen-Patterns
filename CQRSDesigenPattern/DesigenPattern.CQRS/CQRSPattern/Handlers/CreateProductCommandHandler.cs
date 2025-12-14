using DesigenPattern.CQRS.CQRSPattern.Commands;
using DesigenPattern.CQRS.DAL;

namespace DesigenPattern.CQRS.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context) // consturctor injection
        {
            _context = context;
        }
        public void Handle(CreateProductCommand command)
        {
            _context.Add(new Product
            { 
                Description = command.Description,
                Name = command.Name,
                Price = command.Price,
                Status = true,
                Stock = command.Stock
            });
            _context.SaveChanges();
        }
    }
}
