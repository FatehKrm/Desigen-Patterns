using DesigenPattern.CQRS.CQRSPattern.Commands;
using DesigenPattern.CQRS.CQRSPattern.Handlers;
using DesigenPattern.CQRS.CQRSPattern.Queries;
using DesigenPattern.CQRS.CQRSPattern.Results;
using Microsoft.AspNetCore.Mvc;

namespace DesigenPattern.CQRS.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;
        private readonly GetProductByIdQueryHandler _getProductByIdQueryHandler;
        private readonly DeleteProductCommandHandler _deleteProductCommandHandler;
        private readonly GetPorductUpdateByIdQueryHandler _getPorductUpdateByIdQueryHandler;
        private readonly UpdateProductCommandHandler _updateProductCommandHandler;

        public DefaultController(GetProductQueryHandler getProductQueryHandler, CreateProductCommandHandler createProductCommandHandler, GetProductByIdQueryHandler getProductByIdQueryHandler, DeleteProductCommandHandler deleteProductCommandHandler, GetPorductUpdateByIdQueryHandler getPorductUpdateByIdQueryHandler, UpdateProductCommandHandler updateProductCommandHandler) // Constructor Injection
        {
            _getProductQueryHandler = getProductQueryHandler;
            _createProductCommandHandler = createProductCommandHandler;
            _getProductByIdQueryHandler = getProductByIdQueryHandler;
            _deleteProductCommandHandler = deleteProductCommandHandler;
            _getPorductUpdateByIdQueryHandler = getPorductUpdateByIdQueryHandler;
            _updateProductCommandHandler = updateProductCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand command)
        {
            _createProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var values = _getProductByIdQueryHandler.Handle(new GetProductByIdQuery(id));
            return View(values);
        }
        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {
            _deleteProductCommandHandler.Handle(new DeleteProductCommand(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var valeus = _getPorductUpdateByIdQueryHandler.Handle(new GetProductUpdateByIdQuery(id));
            return View(valeus);
        }
        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductCommand command)
        {
            _updateProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
