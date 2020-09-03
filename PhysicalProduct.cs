
using System;

namespace PaymentGateWay
{
     public class PhysicalProduct :IPaymentRepository
     {
        public string GeneratePayslip()
        {
          return "Physical order payslip generaed ";
        }
        
       public void GetCommisionDetails()
       {
            console.Writeline(" Book Order commision percentage is 10%");
       }
       
     }
     
     
    
}
