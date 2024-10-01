using Tyuiu.GalimovaAS.Sprint1.Task5.V4.Lib;
namespace Tyuiu.GalimovaAS.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int time = 13257;
            int h = 3;
            int res = ds.SecondsToHours(time);

            int result = Convert.ToInt32(res);
            Assert.AreEqual(h, result);
        }
    }
}