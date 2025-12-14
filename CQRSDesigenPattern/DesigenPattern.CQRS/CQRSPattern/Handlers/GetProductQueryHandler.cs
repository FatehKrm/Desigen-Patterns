using DesigenPattern.CQRS.CQRSPattern.Results;
using DesigenPattern.CQRS.DAL;

namespace DesigenPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductQueryHandler // Sorgu işlemlerini yapacak olan sınıf
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                ID = x.ProductId,
                ProductName = x.Name,
                Price = x.Price,
                Stock = x.Stock
            }).ToList();
            return values;
        }
       
    }
}
