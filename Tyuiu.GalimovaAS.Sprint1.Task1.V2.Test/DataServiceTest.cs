using Tyuiu.GalimovaAS.Sprint1.Task1.V2.Lib;
namespace Tyuiu.GalimovaAS.Sprint1.Task1.V2.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();
        double x = 1.0;
        double y = 6.0;
        var res = ds.Calculate(x, y);
        Assert.AreEqual(1, res);
    }
}