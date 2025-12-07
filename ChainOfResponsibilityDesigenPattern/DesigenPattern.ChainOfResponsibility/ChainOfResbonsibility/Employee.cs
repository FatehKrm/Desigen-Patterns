using DesigenPattern.ChainOfResponsibility.Dal;
using DesigenPattern.ChainOfResponsibility.Models;

namespace DesigenPattern.ChainOfResponsibility.ChainOfResbonsibility
{
    public abstract class Employee // chain of responsibility deki özelliklerden birisi abstract class kullanmaktır.
    {
        protected Employee nextApprove; // bir sonraki çalışanı tutmak için
        public void SetNextApprove(Employee superVizer)
        {
            this.nextApprove = superVizer;
        }
        public abstract void ProcessRequest(CustomerProcessViewModel req);

        // bu davranış java'daki likedlistteki gibi çalışıyor node.next gibi düşünebiliriz.
    }
}
