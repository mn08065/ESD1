using System;
using System.Collections.Generic;

namespace LibraryManagementSystem.Domain
{
    public class Member : BaseModel
    {
        public string Name { get; set; } = default!;
        public ICollection<Loan> Loans { get; set; } = new List<Loan>();

        // Number of loans that have not been returned
        public int LoanCount => Loans.Select(l => l.ReturnDate == null).Count();

        public virtual bool CanBorrow()
        {
            // DO NOT MODIFY ABOVE THIS LINE
            if (LoanCount < 3)
            {
                return true;
            }
            return false;
            //throw new NotImplementedException("Member.CanBorrow is not implemented");
            // DO NOT MODIFY BELOW THIS LINE
        }

        public virtual void RecordLoan(Loan loan)
        {
            Loans.Add(loan);
        }

        public virtual void ReturnLoan(Loan loan)
        {
            Loans.First(l => l.Id == loan.Id).ReturnDate = DateTime.Now;
        }
    }
}