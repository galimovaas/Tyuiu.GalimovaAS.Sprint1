using Tyuiu.GalimovaAS.Sprint1.Task2.V2.Lib;
namespace Tyuiu.GalimovaAS.Sprint1.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = (int)100;
            var res = ds.ConvertAngleToRad(x);
            Assert.AreEqual(1.745, res);
        }
    }
}