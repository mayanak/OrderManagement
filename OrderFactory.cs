Using System;


namespace PaymentGateWay
{
  public interface IPayamentRepository
  {
    string GeneratePaySlip();
    void GetCommisionDetails();
  }
  
 public interface IMemeberShipRepository
 {
 
    void ActivateMember();
    void SendMail();
    void UpgrateMemberShip();
 }
// Product and MemberShip Abstract class
public abstract class ProductAbstract
{
 public abstract IPayamentRepository GetPaymentDetailsByType(string type);
}
public abstract class MemberShipAbstract
{
 public abstract IMemeberShipRepository GetPaymentDetailsByType(string type);
}

public class ConcereProuduct :ProductAbstract
{
    publick override IPayamentRepository GetPaymentDetailsByType(string type);
    {
      switch(type)
      {
        case "Book":
          return new Book();
          case "Book":
          return new PhysicalProudct();
          default :
          return new Book();
        
      }
    }
}

public class ConcereMemberShip :MemberShipAbstract
{
    publick override IMemeberShipRepository GetPaymentDetailsByType(string type);
    {
      switch(type)
      {
        case "MemberShip":
          return new MemberShip();
          default :
          return new MemberShip();

      }
    }
}
}
