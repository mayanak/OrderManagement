using System;
using System.Collections.Generic;

namespace OrderManagement
{
    public class Program
    {
          string paymentFor;
	  string payslipDetails;
          console.WriteLine(" Please enter product type");
          paymentFor=console.ReadLine();
          ProductAbstract objProduct=new ConcreteProuduct();
          MemberShipAbstract objMembership= new ConcreteMemberShip();
          
		  if(paymentFor=="Book")
		  {
			  
			 IPayamentRepository objBook=objProduct.GetPaymentDetailsByType(paymentFor); 
			  payslipDetails=objBook.GeneratePaySlip();
			 objBook.GetCommisionDetails();
			 
			 Console.WriteLine(payslipDetails);
		  }
		  else if (paymentFor=="PhysicalProudct")
		  {
			  
			  IPayamentRepository objPhysicalProduct=objProduct.GetPaymentDetailsByType(paymentFor); 
			  payslipDetails=objPhysicalProduct.GeneratePaySlip();
			 objPhysicalProduct.GetCommisionDetails();
		  }
		   else if (paymentFor=="MemberShip")
		  {
			  
			  IPayamentRepository objMemberShip=objAMembership.GetPaymentDetailsByType(paymentFor); 
			 string payslipDetails=objMemberShip.GeneratePaySlip();
			 //if member need to be activate need call below method
			 objMemberShip.ActivateMember();
			 
			 //for member updatetion
			 objMemberShip.UpgrateMemberShip();
			 //send Activation/updatetion mail to member
			 objMemberShip.SendMail();
		  }
		  
        }
    }
}
