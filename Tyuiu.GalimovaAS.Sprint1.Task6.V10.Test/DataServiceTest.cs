using Tyuiu.GalimovaAS.Sprint1.Task6.V10.Lib;
namespace Tyuiu.GalimovaAS.Sprint1.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string strTest = "����� ����� ����";
            DataService ds = new DataService();
            string res = ds.DeleteMiddleLetter(strTest);
            string wail = "���� ���� ����";
            Assert.AreEqual(wail, res);
        }
    }
}