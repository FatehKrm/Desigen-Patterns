using DesigenpPattern.Observer.Dal;

namespace DesigenpPattern.Observer.ObserverPattern
{
    public class CreateDiscountCode : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void createNewUser(AppUser appUser)
        {
            context.discounts.Add(new Discount
            {
                DiscountCode = "DERGMART",
                DiscountAmount = 35,
                Status = true
            });
            context.SaveChanges();
        }
    }
}
