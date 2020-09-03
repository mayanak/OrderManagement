using System;
using System.Collections.Generic;

namespace OrderManagement
{
    public class Program
    {
       string paymentFor;
          console.WriteLine(" Please enter product type");
          paymentFor=console.ReadLine();
          ProductAbstract objProduct=new ConcreteProuduct();
          MemberShipAbstract objMembership= new ConcreteMemberShip();
          
		  if(paymentFor=="Book")
		  {
			  
			 IPayamentRepository objBook=objProduct.GetPaymentDetailsByType(paymentFor); 
			 string payslipDetails=objBook.GeneratePaySlip();
			 objBook.GetCommisionDetails();
			 
			 Console.WriteLine(payslipDetails);
		  }
		  else if (paymentFor=="PhysicalProudct")
		  {
			  
			  IPayamentRepository objPhysicalProduct=objProduct.GetPaymentDetailsByType(paymentFor); 
			 string payslipDetails=objPhysicalProduct.GeneratePaySlip();
			 objPhysicalProduct.GetCommisionDetails();
		  }
		    else if (paymentFor=="PhysicalProudct")
		  {
			  
			  IPayamentRepository objPhysicalProduct=objProduct.GetPaymentDetailsByType(paymentFor); 
			 string payslipDetails=objPhysicalProduct.GeneratePaySlip();
			 objPhysicalProduct.GetCommisionDetails();
		  }
		  
        }
    }
}
