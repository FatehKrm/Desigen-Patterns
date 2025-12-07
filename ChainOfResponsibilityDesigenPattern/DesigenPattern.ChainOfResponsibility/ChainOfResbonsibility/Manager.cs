using DesigenPattern.ChainOfResponsibility.Dal;

namespace DesigenPattern.ChainOfResponsibility.ChainOfResbonsibility
{
    public class Manager : Employee// müdür
    {
        public override void ProcessRequest(Models.CustomerProcessViewModel req)
        {
            Context context = new Context();

            if (req.Amount <= 250000)
            {
                Dal.CustomerProccess customerProccess = new Dal.CustomerProccess();
                customerProccess.Amount = req.Amount.ToString();
                customerProccess.Name = req.Name;
                customerProccess.EmployeeName = "Şube müdürü - Ahmet Yılmaz";
                customerProccess.Description = "Para çekme işlemi onaylandı, müşteriye talep edilen tutar ödendi.";
                context.CustomerProccesses.Add(customerProccess);
                context.SaveChanges();
            }
            else if (nextApprove != null)
            {
                Dal.CustomerProccess customerProccess = new Dal.CustomerProccess();
                customerProccess.Amount = req.Amount.ToString();
                customerProccess.Name = req.Name;
                customerProccess.EmployeeName = "Şube müdürü - Ahmet Yılmaz";
                customerProccess.Description = "Para çekme işlemi onaylanmadı, talep edilen tutar şube müdürü limitlerinin üzerinde.";
                context.CustomerProccesses.Add(customerProccess);
                context.SaveChanges();
                nextApprove.ProcessRequest(req);
            }
        }
    }
}
