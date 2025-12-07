using DesigenPattern.ChainOfResponsibility.Dal;
using DesigenPattern.ChainOfResponsibility.Models;

namespace DesigenPattern.ChainOfResponsibility.ChainOfResbonsibility
{
    public class ManagerAssistantant : Employee// müdür yardımcısı
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 150000)
            {
                CustomerProccess customerProccess = new CustomerProccess();
                customerProccess.Amount = req.Amount.ToString();
                customerProccess.Name = req.Name;
                customerProccess.EmployeeName = "Şube müdür yardımcısı - Melike Aslan";
                customerProccess.Description = "Para çekme işlemi onaylandı, müşteriye talep edilen tutar ödendi.";
                context.CustomerProccesses.Add(customerProccess);
                context.SaveChanges();
            }
            else if (nextApprove != null)
            {
                CustomerProccess customerProccess = new CustomerProccess();
                customerProccess.Amount = req.Amount.ToString();
                customerProccess.Name = req.Name;
                customerProccess.EmployeeName = "Şube müdür yardımcısı - Melike Aslan";
                customerProccess.Description = "Para çekme işlemi onaylanmadı, talep edilen tutar şube müdür yardımcısı limitlerinin üzerinde.";
                context.CustomerProccesses.Add(customerProccess);
                context.SaveChanges();
                nextApprove.ProcessRequest(req);
            }
        }
    }
}
