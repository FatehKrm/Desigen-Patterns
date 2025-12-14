using DesigenPattern.CQRS.CQRSPattern.Commands;
using DesigenPattern.CQRS.DAL;

namespace DesigenPattern.CQRS.CQRSPattern.Handlers
{
    public class DeleteProductCommandHandler
    {
        private readonly Context _context;

        public DeleteProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(DeleteProductCommand command)
        {
            var valeus = _context.Products.Find(command.ID);
            _context.Products.Remove(valeus);
            _context.SaveChanges();
        }
    }
}
