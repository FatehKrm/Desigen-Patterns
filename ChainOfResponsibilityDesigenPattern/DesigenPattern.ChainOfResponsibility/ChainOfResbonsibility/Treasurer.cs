using DesigenPattern.ChainOfResponsibility.Dal;
using DesigenPattern.ChainOfResponsibility.Models;

namespace DesigenPattern.ChainOfResponsibility.ChainOfResbonsibility
{
    public class Treasurer : Employee// veznedar
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 100000)
            {
                CustomerProccess customerProccess = new CustomerProccess();
                customerProccess.Amount = req.Amount.ToString();
                customerProccess.Name = req.Name;
                customerProccess.EmployeeName = "Veznedar - kaplan kerimoğlu";
                customerProccess.Description = "Para çekme işlemi onaylandı, müşteriye talep edilen tutar ödendi.";
                context.CustomerProccesses.Add(customerProccess);
                context.SaveChanges();
            }
            else if(nextApprove!=null)
            {
                CustomerProccess customerProccess = new CustomerProccess();
                customerProccess.Amount = req.Amount.ToString();
                customerProccess.Name = req.Name;
                customerProccess.EmployeeName = "Veznedar - kaplan kerimoğlu";
                customerProccess.Description = "Para çekme işlemi onaylanmadı, talep edilen tutar veznedarın limitlerinin üzerinde.";
                context.CustomerProccesses.Add(customerProccess);
                context.SaveChanges();
                nextApprove.ProcessRequest(req); // bir sonraki yetkiliye yönlendirme node mantığında node = node.next;
            }
        }
    }
}
