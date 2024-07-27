using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainofResponsibilityPattern
{
    public abstract class Employee //abstract class yapılıyor ki bütün çalışanlar buradan miras alabilsin.
    {
        protected Employee NextApprover; //protected o sınıf ve o sınıfı miras alanlar sınıflara erişim sağlıyor
        public void SetNextApprover(Employee employee)
        {
            this.NextApprover = employee;
        }
        public abstract void ProcessRequest(CustomerViewModel customerViewModel);
    }
}
