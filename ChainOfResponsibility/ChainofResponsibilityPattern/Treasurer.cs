using ChainOfResponsibility.DAL;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainofResponsibilityPattern
{
    public class Treasurer : Employee
    {
        private readonly Context _context;

        public Treasurer(Context context)
        {
            _context = context;
        }

        public override void ProcessRequest(CustomerViewModel customerViewModel)
        {
            if (customerViewModel.Amount <= 80000)
            {

                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Name = customerViewModel.Name;
                customerProcess.Amount = customerViewModel.Amount;
                customerProcess.EmployeeName = "Batuhan YALIN";
                customerProcess.Description = "Talep edilen tutar veznedar tarafından ödendi.";
                _context.CustomerProcesses.Add(customerProcess);
                _context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess2 = new CustomerProcess();
                customerProcess2.Name = customerViewModel.Name;
                customerProcess2.Amount = customerViewModel.Amount;
                customerProcess2.EmployeeName = "Batuhan YALIN";
                customerProcess2.Description = "Talep edilen tutar veznedar tarafından ödenemedi, işlem şube müdürü yardımcısına aktarıldı.";
                _context.CustomerProcesses.Add(customerProcess2);
                _context.SaveChanges();
                NextApprover.ProcessRequest(customerViewModel);
            }
        }
    }
}
