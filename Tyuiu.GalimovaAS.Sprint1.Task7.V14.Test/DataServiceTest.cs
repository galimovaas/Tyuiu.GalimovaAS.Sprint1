using Tyuiu.GalimovaAS.Sprint1.Task7.V14.Lib;
namespace Tyuiu.GalimovaAS.Sprint1.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 2.034;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}