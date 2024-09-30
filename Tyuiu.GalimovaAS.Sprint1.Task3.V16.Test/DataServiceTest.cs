using Tyuiu.GalimovaAS.Sprint1.Task3.V16.Lib;
namespace Tyuiu.GalimovaAS.Sprint1.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x1 = 1.111;
            double x2 = 1.334;
            var res = ds.CoeffOfQuadraticEquation(x1, x2);
            Assert.AreEqual(-2.445, res);
        }
    }
}