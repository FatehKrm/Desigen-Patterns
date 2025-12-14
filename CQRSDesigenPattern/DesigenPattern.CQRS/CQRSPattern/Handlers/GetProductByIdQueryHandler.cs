using DesigenPattern.CQRS.CQRSPattern.Queries;
using DesigenPattern.CQRS.CQRSPattern.Results;
using DesigenPattern.CQRS.DAL;

namespace DesigenPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductByIdQueryResult Handle(GetProductByIdQuery query )
        {
            var values = _context.Set<Product>().Find(query.ID);
            return new GetProductByIdQueryResult
            {
                Name = values.Name,
                Price = values.Price,
                ProductId = values.ProductId,
                Stock = values.Stock
            };
        }
    }
}
