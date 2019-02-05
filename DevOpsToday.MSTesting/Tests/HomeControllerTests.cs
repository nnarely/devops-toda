using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspnetCore.Mvc;

namespace DevOpsToday.MSTesting.Tests
{
  [TestClass]
  public class HomeControllersTests
  {
    [TestMethod]
    public void Test_IndexAction()
    {
      var sut = new HomeController();

      Assert.IsNotNull(sut.Index());
    }

    [TestMethod]
    public void Test_Privacy
  }
}