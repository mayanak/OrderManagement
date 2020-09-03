
using System;

namespace PaymentGateWay
{
     public class Book :IPaymentRepository
     {
        public string GeneratePayslip()
        {
          return "Book order payslip generaed ";
        }
        
       public void GetCommisionDetails()
       {
            console.Writeline(" Book Order commision percentage is 4%");
       }
       
     }
     
     
    
}
