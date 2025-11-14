
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleApi.Controllers;

namespace SampleApi.Tests
{
    [TestClass]
    public class CalculatorControllerTests
    {
        [TestMethod]
        public void Add_ReturnsCorrectValue()
        {
            var controller = new CalculatorController();
            var result = controller.Add(5, 10) as Microsoft.AspNetCore.Mvc.OkObjectResult;

            dynamic data = result!.Value!;
            Assert.AreEqual(15, (int)data.result);
        }
    }
}
