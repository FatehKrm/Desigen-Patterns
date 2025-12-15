using DesigenpPattern.Observer.Dal;

namespace DesigenpPattern.Observer.ObserverPattern
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {

            _serviceProvider = serviceProvider;
        }

        public void createNewUser(AppUser appUser)
        {
            context.welcomeMessages.Add(new WelcomeMessage
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Content = "Dergi bültenimize kayıyt olduğunuz için çok teşekkür ederiz, dergilerimize  web sitemiz üzerinden ulaşabilirsiniz."
            });
            context.SaveChanges();  
        }
    }
}
