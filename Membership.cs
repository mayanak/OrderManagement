
using System;

namespace PaymentGateWay
{
     public class MemberShip :IMemberShipRepository
     {
        public void ActivateMember()
        {
        // To do need to added properties to add the the member
           console.Writeline(" Member added sucessfully");
        }
        
       public void GetCommisionDetails()
       {
            console.Writeline(" Book Order commision percentage is 4%");
       }
       
     }
     
     
    
}
