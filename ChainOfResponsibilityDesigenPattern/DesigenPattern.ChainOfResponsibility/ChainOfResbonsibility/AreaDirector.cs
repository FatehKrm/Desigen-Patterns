using DesigenPattern.ChainOfResponsibility.Dal;
using DesigenPattern.ChainOfResponsibility.Models;

namespace DesigenPattern.ChainOfResponsibility.ChainOfResbonsibility
{
    public class AreaDirector : Employee// bölge müdürü
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 400000)
            {
                CustomerProccess customerProccess = new CustomerProccess();
                customerProccess.Amount = req.Amount.ToString();
                customerProccess.Name = req.Name;
                customerProccess.EmployeeName = "Bölge müdürü - Orman kerimoğlu";
                customerProccess.Description = "Para çekme işlemi onaylandı, müşteriye talep edilen tutar ödendi.";
                context.CustomerProccesses.Add(customerProccess);
                context.SaveChanges();
            }
            else 
            {
                CustomerProccess customerProccess = new CustomerProccess();
                customerProccess.Amount = req.Amount.ToString();
                customerProccess.Name = req.Name;
                customerProccess.EmployeeName = " Bölge müdürü - Orman kerimoğlu";
                customerProccess.Description = "Para çekme işlemi onaylanmadı, talep edilen tutar Bölge müdürü limitlerinin üzerinde.";
                context.CustomerProccesses.Add(customerProccess);
                context.SaveChanges();
            }
        }
    }
}
