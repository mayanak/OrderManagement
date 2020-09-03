using Microsoft.VisuvalStudio.TestingTools.UnitTesting;
using PayamentGateWay;

namespace UnitTestProject
{
[TestClass]

public class UnitTest1
{
[TestMethod]
  public void GenrateOderPaySlip()
  {
       PaymentAbstract objAbstract= new ConcreateFactory();
       IPayamentRepository objBook= objAbstract.GetPaymentDetailsByType("Book");
       string expected="Book payslip generaed sucessfully";
       string actuval=objBook.GeneratePaySlip();
       Assert.AreEqual(expected,actuval);

  }
}

}
