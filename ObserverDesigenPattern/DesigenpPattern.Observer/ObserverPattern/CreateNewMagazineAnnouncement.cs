using DesigenpPattern.Observer.Dal;

namespace DesigenpPattern.Observer.ObserverPattern
{
    public class CreateNewMagazineAnnouncement : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateNewMagazineAnnouncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void createNewUser(AppUser appUser)
        {
            context.userProccesses.Add(new UserProccess
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Magazine = "Bilim dergisi",
                Content = "Bilim dergimizin mart sayısı 1 Martta evinize ulaşacaktır, konular : jupiter ve mars gezegenleri hakkında"
            });
            context.SaveChanges();
        }
    }
}
