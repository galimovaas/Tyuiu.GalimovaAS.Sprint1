using Tyuiu.GalimovaAS.Sprint1.Task0.V9.Lib;
namespace Tyuiu.GalimovaAS.Sprint1.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(3, res);
        }
    }
}