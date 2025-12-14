using DesigenPattern.CQRS.CQRSPattern.Queries;
using DesigenPattern.CQRS.CQRSPattern.Results;
using DesigenPattern.CQRS.DAL;

namespace DesigenPattern.CQRS.CQRSPattern.Handlers
{
    public class GetPorductUpdateByIdQueryHandler
    {
        private readonly Context _context;

        public GetPorductUpdateByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductUpdateQueryResult Handle(GetProductUpdateByIdQuery query)
        {
            var valeus = _context.Products.Find(query.ID);
            return new GetProductUpdateQueryResult
            {
                Description = valeus.Description,
                Name = valeus.Name,
                Price = valeus.Price,
                Stock = valeus.Stock,
                ID = valeus.ProductId
            };
        }
    }
}
